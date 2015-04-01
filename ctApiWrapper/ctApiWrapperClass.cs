using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.ComponentModel;

namespace ctApiWrapper
{
    /// <summary>
    ///
    /// </summary>
    public class CitectApi
    {
        #region Fields
        private string FComputer;
        private string FUser;
        private string FPassword;
        private uint FMode;
        private IntPtr FhCtapi;
        #endregion
        #region Constructors
        public CitectApi()
        {

        }
        public CitectApi(string Computer, string User, string Password, uint Mode)
        {
            this.Computer = Computer;
            this.User = User;
            this.Password = Password;
            this.Mode = Mode;
        }
        #endregion
        #region Properties
        public string Computer
        {
            get
            {
                return FComputer;
            }
            set
            {
                FComputer = value;
            }
        }

        public string User
        {
            get
            {
                return FUser;
            }
            set
            {
                FUser = value;
            }
        }

        private string Password
        {
            get
            {
                return FPassword;
            }
            set
            {
                FPassword = value;
            }
        }

        public uint Mode
        {
            get
            {
                return FMode;
            }
            set
            {
                FMode = value;
            }
        }

        private IntPtr hCtapi
        {
            get
            {
                return FhCtapi;
            }
            set
            {
                FhCtapi = value;
            }
        }

        public bool Connected
        {
            get
            {
                return IsConnected();
            }
            set
            {
                if (true == value)
                {
                    if (IsConnected())
                    {
                        ctClose(hCtapi);
                        hCtapi = (IntPtr)0;
                    }
                    hCtapi = ctOpen(Computer, User, Password, Mode);
                    int lastError = Marshal.GetLastWin32Error();
                    if (lastError != 0)
                    {
                        throw new Exception(new Win32Exception(lastError).Message);
                    }
                }
                else
                {
                    ctClose(hCtapi);
                    int lastError = Marshal.GetLastWin32Error();
                    if (lastError != 0)
                    {
                        throw new Exception(new Win32Exception(lastError).Message);
                    }
                    hCtapi = (IntPtr)0;
                }
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
        #endregion
        #region External imports
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
        #endregion
    }
}