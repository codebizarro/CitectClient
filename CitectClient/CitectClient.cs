using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Net.CitectClient.Platform;

namespace System.Net.CitectClient
{
    public class CitectClient : ICitectClient
    {
        private readonly string _host;
        private readonly string _user;
        private readonly string _password;
        private readonly uint _mode;

        #region Constructors
        public CitectClient(string host, string user, string password, uint mode)
        {
            _host = host;
            _user = user;
            _password = password;
            _mode = mode;
            Debug = $"{_host} {_user} {_mode}";
        }
        #endregion
        #region Properties
        private const int BUFFER_SIZE = 32;

        private IntPtr Handle { get; set; }

        public bool Connected
        {
            get
            {
                return IsConnected();
            }
        }

        public string Debug
        {
            set
            {
                System.Diagnostics.Debug.WriteLine(value);
            }
        }
        #endregion
        #region Methods

        private bool IsConnected()
        {
            if (Handle.ToInt32() == 0)
                return false;
            else
            {
                var result = new StringBuilder(BUFFER_SIZE);
                NativeMethods.ctCicode(Handle, "Abs(-8)", 0, 0, result, (uint)result.Capacity, 0);
                return (Marshal.GetLastWin32Error() == 0 && result.ToString()[0].Equals('8'));
            }
        }

        public string TagRead(string Tag)
        {
            var result = new StringBuilder(BUFFER_SIZE);
            NativeMethods.ctTagRead(Handle, Tag, result, (uint)result.Capacity);
            return result.ToString();
        }

        public void TagWrite(string Tag, string Value)
        {
            NativeMethods.ctTagWrite(Handle, Tag, Value);
        }

        private void Open()
        {
            if (IsConnected())
            {
                Close();
            }
            Handle = NativeMethods.ctOpen(_host, _user, _password, _mode);
        }

        public void Open(int timeout = 5000)
        {
            var sw = new Stopwatch();
            bool connectSuccess = false;
            var t = new Thread(delegate ()
            {
                try
                {
                    sw.Start();
                    Open();
                    connectSuccess = true;
                }
                catch { }
            });
            t.IsBackground = true;
            t.Start();
            while (timeout > sw.ElapsedMilliseconds)
                if (t.Join(1))
                    break;
            if (!connectSuccess)
                throw new TimeoutException("Timed out while trying to connect.");
        }

        public void Close()
        {
            NativeMethods.ctClose(Handle);
            Handle = IntPtr.Zero;
        }

        public int FindFirst(string TableName, string Filter, out uint ObjectHandle)
        {
            IntPtr ret = NativeMethods.ctFindFirst(Handle, TableName, Filter, out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindNext(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = NativeMethods.ctFindNext(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindPrev(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = NativeMethods.ctFindPrev(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindScroll(int Handle, uint Mode, int Offset, out uint ObjectHandle)
        {
            IntPtr ret = NativeMethods.ctFindScroll(new IntPtr(Handle), Mode, Offset, out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindClose(int Handle)
        {
            IntPtr ret = NativeMethods.ctFindClose(new IntPtr(Handle));
            return ret.ToInt32();
        }

        public string GetProperty(uint handle, string Name, int ReturnType)
        {
            var result = new StringBuilder(BUFFER_SIZE);
            uint retLen;
            IntPtr ret = NativeMethods.ctGetProperty(new IntPtr(handle), Name, result, (uint)result.Capacity, out retLen, ReturnType);
            return result.ToString();
        }

        private int GetSamplePeriod(string tag)
        {
            var hFind = FindFirst(CitectEntities.Trend.TableName, tag, out uint obj);
            if (hFind > 0)
            {
                var s = GetProperty(obj, CitectEntities.Trend.SAMPLEPER, DbTypeEnum.DBTYPE_STR);
                return (int)s.ToFloat();
            }
            else return 0;
        }

        public DateTime GetDateTime()
        {
            var result = new StringBuilder(BUFFER_SIZE);
            NativeMethods.ctCicode(Handle, "TimeCurrent()", 0, 0, result, (uint)result.Capacity, 0);
            var uxTime = int.Parse(result.ToString());
            return uxTime.ToDateTime();
        }

        public IEnumerable<TrendEntry> TrendRead(string tag, DateTime dateRight, int length)
        {
            var query = TrendHelper.Query(tag, dateRight, GetSamplePeriod(tag), length);
            var list = new List<TrendEntry>();
            var hFind = FindFirst(query, null, out uint obj);
            while (hFind != 0)
            {
                var date = GetProperty(obj, "DATE", DbTypeEnum.DBTYPE_STR);
                var time = GetProperty(obj, "TIME", DbTypeEnum.DBTYPE_STR);
                var val = GetProperty(obj, tag, DbTypeEnum.DBTYPE_STR);
                var entry = new TrendEntry(date, time, val);
                list.Add(entry);
                if (FindNext(hFind, out obj) == 0)
                {
                    FindClose(hFind);
                    hFind = 0;
                    break;
                }
            }
            return list;
        }

        public IEnumerable<TrendEntry> TrendRead(string tag, DateTime dateRight, DateTime dateLeft)
        {
            var secondSpan = (dateRight - dateLeft).TotalSeconds;
            var period = GetSamplePeriod(tag);
            var length = secondSpan / period;
            return TrendRead(tag, dateRight, (int)length);
        }

        public IEnumerable<TrendEntryQual> TrendRead(string tag, DateTime dateRight, int length, bool interpolate, bool legacy = true)
        {
            var query = TrendHelper.Query(tag, dateRight, GetSamplePeriod(tag), length, interpolate, legacy);
            var list = new List<TrendEntryQual>();
            var hFind = FindFirst(query, null, out uint obj);
            while (hFind != 0)
            {
                var datetime = GetProperty(obj, "DateTime", DbTypeEnum.DBTYPE_STR);
                var val = GetProperty(obj, "Value", DbTypeEnum.DBTYPE_STR);
                var quality = GetProperty(obj, "Quality", DbTypeEnum.DBTYPE_STR);
                var entry = new TrendEntryQual(datetime, val, quality);
                list.Add(entry);
                if (FindNext(hFind, out obj) == 0)
                {
                    FindClose(hFind);
                    hFind = 0;
                    break;
                }
            }
            list.Reverse();
            return list;
        }

        public IEnumerable<TrendEntryQual> TrendRead(string tag, DateTime dateRight, DateTime dateLeft, bool interpolate, bool legacy = true)
        {
            var secondSpan = (dateRight - dateLeft).TotalSeconds;
            var period = GetSamplePeriod(tag);
            var length = secondSpan / period;
            return TrendRead(tag, dateRight, (int)length, interpolate, legacy);
        }
        #endregion

        #region IDisposable
        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    //component.Dispose();
                }
                //CloseHandle(handle);
                NativeMethods.ctClose(Handle);
                Handle = IntPtr.Zero;
                disposed = true;
            }
        }

        ~CitectClient()
        {
            Dispose(false);
        }
        #endregion
    }
}