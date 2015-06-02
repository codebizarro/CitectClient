using System;
using System.Runtime.InteropServices;
using System.Text;

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
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            Native.ctCicode(hCtapi, "Abs(1)", 0, 0, result, (uint)result.Capacity, 0);
            return (Marshal.GetLastWin32Error() == 0/* && result.ToString() == "1"*/);
        }

        public string TagRead(string Tag)
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            Native.ctTagRead(hCtapi, Tag, result, (uint)result.Capacity);
            return result.ToString();
        }

        public void TagWrite(string Tag, string Value)
        {
            Native.ctTagWrite(hCtapi, Tag, Value);
        }

        public void Open()
        {
            if (IsConnected())
            {
                Close();
            }
            hCtapi = Native.ctOpen(Host, User, Password, Mode);
        }

        public void Close()
        {
            Native.ctClose(hCtapi);
            hCtapi = IntPtr.Zero;
        }

        public int FindFirst(string TableName, string Filter, out uint ObjectHandle)
        {
            IntPtr ret = Native.ctFindFirst(hCtapi, TableName, Filter, out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindNext(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = Native.ctFindNext(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindPrev(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = Native.ctFindPrev(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindScroll(int Handle, uint Mode, int Offset, out uint ObjectHandle)
        {
            IntPtr ret = Native.ctFindScroll(new IntPtr(Handle), Mode, Offset, out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindClose(int Handle)
        {
            IntPtr ret = Native.ctFindClose(new IntPtr(Handle));
            return ret.ToInt32();
        }

        public string GetProperty(uint handle, string Name, int ReturnType) 
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            uint retLen;
            IntPtr ret = Native.ctGetProperty(new IntPtr(handle), Name, result, (uint)result.Capacity, out retLen, ReturnType);
            return result.ToString();
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
                Native.ctClose(hCtapi);
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