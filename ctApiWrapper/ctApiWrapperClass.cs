using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace ctApiWrapper
{
    public class CitectApi : IDisposable
    {
        #region Constructors
        public CitectApi(string host, string user, string password, uint mode)
        {
            Host = host;
            User = user;
            Password = password;
            Mode = mode;
            Debug = string.Format("{0} {1} {2} {3}", Host, User, Password, Mode);
        }
        #endregion
        #region Properties
        private const int BUFFER_SIZE = 32;

        public string Host { get; private set; }

        public string User { get; private set; }

        private string Password { get; set; }

        private uint Mode { get; set; }

        private IntPtr hCtapi { get; set; }

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
            if (hCtapi.ToInt32() == 0)
                return false;
            else
            {
                StringBuilder result = new StringBuilder(BUFFER_SIZE);
                NativeMethods.ctCicode(hCtapi, "Abs(-8)", 0, 0, result, (uint)result.Capacity, 0);
                return (Marshal.GetLastWin32Error() == 0 && result.ToString()[0].Equals('8'));
            }
        }

        public string TagRead(string Tag)
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            NativeMethods.ctTagRead(hCtapi, Tag, result, (uint)result.Capacity);
            return result.ToString();
        }

        public void TagWrite(string Tag, string Value)
        {
            NativeMethods.ctTagWrite(hCtapi, Tag, Value);
        }

        private void Open()
        {
            if (IsConnected())
            {
                Close();
            }
            hCtapi = NativeMethods.ctOpen(Host, User, Password, Mode);
        }

        public void Open(int timeout = 5000)
        {
            Stopwatch sw = new Stopwatch();
            bool connectSuccess = false;
            Thread t = new Thread(delegate()
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
            NativeMethods.ctClose(hCtapi);
            hCtapi = IntPtr.Zero;
        }

        public int FindFirst(string TableName, string Filter, out uint ObjectHandle)
        {
            IntPtr ret = NativeMethods.ctFindFirst(hCtapi, TableName, Filter, out ObjectHandle);
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
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            uint retLen;
            IntPtr ret = NativeMethods.ctGetProperty(new IntPtr(handle), Name, result, (uint)result.Capacity, out retLen, ReturnType);
            return result.ToString();
        }

        private int GetSamplePeriod(string tag)
        {
            uint obj;
            int hFind = FindFirst(Tables.Trend.TableName, tag, out obj);
            if (hFind > 0)
            {
                string s = GetProperty(obj, Tables.Trend.SAMPLEPER, DbType.DBTYPE_STR);
                return (int)s.ToFloat();
            }
            else return 0;
        }

        public DateTime GetDateTime()
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            NativeMethods.ctCicode(hCtapi, "TimeCurrent()", 0, 0, result, (uint)result.Capacity, 0);
            int uxTime = int.Parse(result.ToString());
            return uxTime.ToDateTime();
        }

        public List<TrendEntry> TrendRead(string tag, DateTime dateRight, int length)
        {
            string query = CtApiTrend.Query(tag, dateRight, GetSamplePeriod(tag), length);
            uint obj;
            List<TrendEntry> list = new List<TrendEntry>();
            int hFind = FindFirst(query, null, out obj);
            while (hFind != 0)
            {
                string date = GetProperty(obj, "DATE", DbType.DBTYPE_STR);
                string time = GetProperty(obj, "TIME", DbType.DBTYPE_STR);
                string val = GetProperty(obj, tag, DbType.DBTYPE_STR);
                TrendEntry entry = new TrendEntry(date, time, val);
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

        public List<TrendEntry> TrendRead(string tag, DateTime dateRight, DateTime dateLeft)
        {
            double secondSpan = (dateRight - dateLeft).TotalSeconds;
            int period = GetSamplePeriod(tag);
            double length = secondSpan / period;
            return TrendRead(tag, dateRight, (int)length);
        }

        public List<TrendEntryQual> TrendRead(string tag, DateTime dateRight, int length, bool interpolate, bool legacy = true)
        {
            string query = CtApiTrend.Query(tag, dateRight, GetSamplePeriod(tag), length, interpolate, legacy);
            uint obj;
            List<TrendEntryQual> list = new List<TrendEntryQual>();
            int hFind = FindFirst(query, null, out obj);
            while (hFind != 0)
            {
                string datetime = GetProperty(obj, "DateTime", DbType.DBTYPE_STR);
                string val = GetProperty(obj, "Value", DbType.DBTYPE_STR);
                string quality = GetProperty(obj, "Quality", DbType.DBTYPE_STR);
                TrendEntryQual entry = new TrendEntryQual(datetime, val, quality);
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

        public List<TrendEntryQual> TrendRead(string tag, DateTime dateRight, DateTime dateLeft, bool interpolate, bool legacy = true)
        {
            double secondSpan = (dateRight - dateLeft).TotalSeconds;
            int period = GetSamplePeriod(tag);
            double length = secondSpan / period;
            return TrendRead(tag, dateRight, (int)length, interpolate, legacy);
        }
        #endregion

        #region IDisposable
        private bool disposed = false;

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
                NativeMethods.ctClose(hCtapi);
                hCtapi = IntPtr.Zero;
                disposed = true;
            }
        }

        ~CitectApi()
        {
            Dispose(false);
        }
        #endregion
    }
}