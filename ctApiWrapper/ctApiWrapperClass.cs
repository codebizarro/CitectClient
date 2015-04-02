using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;

namespace ctApiWrapper
{
    public class CitectApi : IDisposable
    {
        #region Constructors
        public CitectApi()
        {

        }
        public CitectApi(string host, string user, string password, uint mode)
        {
            Host = host;
            User = user;
            Password = password;
            Mode = mode;
        }
        #endregion
        #region Properties
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
        #endregion
        #region Methods
        private void dbg(string sDebug)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("{0}", sDebug));
        }

        private bool IsConnected()
        {
            StringBuilder result = new StringBuilder(256);
            ctCicode(hCtapi, "Abs(1)", 0, 0, result, (uint)result.Capacity, 0);
            //int lastError = Marshal.GetLastWin32Error();
            //if (lastError != 0)
            //{
            //    throw new Exception(new Win32Exception(lastError).Message);
            //}
            //return (result.ToString() == "1");
            return (Marshal.GetLastWin32Error() == 0);
        }

        public string TagRead(string Tag)
        {
            StringBuilder result = new StringBuilder(256);
            ctTagRead(hCtapi, Tag, result, (uint)result.Capacity);
            int lastError = Marshal.GetLastWin32Error();
            if (lastError != 0)
            {
                throw new Exception(new Win32Exception(lastError).Message);
            }
            return result.ToString();
        }

        public void TagWrite(string Tag, string Value)
        {
            ctTagWrite(hCtapi, Tag, Value);
            int lastError = Marshal.GetLastWin32Error();
            if (lastError != 0)
            {
                throw new Exception(new Win32Exception(lastError).Message);
            }
        }

        public void Open()
        {
            if (IsConnected())
            {
                ctClose(hCtapi);
                hCtapi = IntPtr.Zero;
            }
            hCtapi = ctOpen(Host, User, Password, Mode);
            int lastError = Marshal.GetLastWin32Error();
            if (lastError != 0)
            {
                throw new Exception(new Win32Exception(lastError).Message);
            }
        }

        public void Close()
        {
            ctClose(hCtapi);
            int lastError = Marshal.GetLastWin32Error();
            if (lastError != 0)
            {
                throw new Exception(new Win32Exception(lastError).Message);
            }
            hCtapi = IntPtr.Zero;
        }
        #endregion
        #region External imports DLL
        [DllImport("ctapi.dll", EntryPoint = "ctOpen", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctOpen(string sComputer, string sUser, string sPassword, uint nMode);

        [DllImport("ctapi.dll", EntryPoint = "ctClose", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctClose(IntPtr hCtapi);

        [DllImport("ctapi.dll", EntryPoint = "ctTagRead", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctTagRead(IntPtr hCtapi, string sTag, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sValue, uint dwLength);

        [DllImport("ctapi.dll", EntryPoint = "ctTagWrite", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctTagWrite(IntPtr hCtapi, string sTag, string sValue);

        [DllImport("ctapi.dll", EntryPoint = "ctCicode", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctCicode(IntPtr hCTAPI, string sCmd, uint hWin, uint nMode, [MarshalAs(UnmanagedType.LPStr)] StringBuilder sResult, uint dwLength, uint pctOverlapped);

        [DllImport("ctapi.dll", EntryPoint = "ctFindFirst", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctFindFirst(IntPtr hCtapi, string szTableName, string szFilter, out uint pObjHnd, uint dwFlags = 0);

        [System.Runtime.InteropServices.DllImport("Kernel32")]
        private extern static Boolean CloseHandle(IntPtr handle);

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
                ctClose(hCtapi);
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