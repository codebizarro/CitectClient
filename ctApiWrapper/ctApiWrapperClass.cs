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
            ctCicode(hCtapi, "Abs(1)", 0, 0, result, (uint)result.Capacity, 0);
            return (Marshal.GetLastWin32Error() == 0/* && result.ToString() == "1"*/);
        }

        public string TagRead(string Tag)
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            ctTagRead(hCtapi, Tag, result, (uint)result.Capacity);
            return result.ToString();
        }

        public void TagWrite(string Tag, string Value)
        {
            ctTagWrite(hCtapi, Tag, Value);
        }

        public void Open()
        {
            if (IsConnected())
            {
                Close();
            }
            hCtapi = ctOpen(Host, User, Password, Mode);
        }

        public void Close()
        {
            ctClose(hCtapi);
            hCtapi = IntPtr.Zero;
        }

        public int FindFirst(string TableName, string Filter, out uint ObjectHandle)
        {
            IntPtr ret = ctFindFirst(hCtapi, TableName, Filter, out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindNext(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = ctFindNext(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindPrev(int Handle, out uint ObjectHandle)
        {
            IntPtr ret = ctFindPrev(new IntPtr(Handle), out ObjectHandle);
            return ret.ToInt32();
        }

        public int FindClose(int Handle)
        {
            IntPtr ret = ctFindClose(new IntPtr(Handle));
            return ret.ToInt32();
        }

        public string GetProperty(uint handle, string Name, int ReturnType) 
        {
            StringBuilder result = new StringBuilder(BUFFER_SIZE);
            uint retLen;
            IntPtr ret = ctGetProperty(new IntPtr(handle), Name, result, (uint)result.Capacity, out retLen, ReturnType);
            return result.ToString();
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
        private static extern IntPtr ctFindFirst(IntPtr hCtapi, [MarshalAs(UnmanagedType.LPStr)]string szTableName, [MarshalAs(UnmanagedType.LPStr)]string szFilter, out uint pObjHnd, uint dwFlags = 0);

        [DllImport("ctapi.dll", EntryPoint = "ctFindNext", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctFindNext(IntPtr handle, out uint pObjHnd);

        [DllImport("ctapi.dll", EntryPoint = "ctFindPrev", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctFindPrev(IntPtr handle, out uint pObjHnd);

        [DllImport("ctapi.dll", EntryPoint = "ctFindClose", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctFindClose(IntPtr handle);

        [DllImport("ctapi.dll", EntryPoint = "ctGetProperty", SetLastError = true, CharSet = CharSet.Ansi, ThrowOnUnmappableChar = true)]
        private static extern IntPtr ctGetProperty(IntPtr handle, string szName, [MarshalAs(UnmanagedType.LPStr)] StringBuilder pData, uint dwBufferLength, out uint dwResultLength, int dwType);

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

    #region Enums
    public static class TableName
    {
        public const string Cluster = "Cluster";
        public const string Tag = "Tag";
        public const string LocalTag = "LocalTag";
        public const string Accum = "Accum";
        public const string Trend = "Trend";
        public const string Alarm = "Alarm";
        public const string AlarmSummary = "AlarmSummary";
        public const string DigAlm = "DigAlm";
        public const string AnaAlm = "AnaAlm";
        public const string AdvAlm = "AdvAlm";
        public const string HResAlm = "HResAlm";
        public const string ArgDigAlm = "ArgDigAlm";
        public const string ArgAnaAlm = "ArgAnaAlm";
        public const string TsDigAlm = "TsDigAlm";
        public const string TsAnaAlm = "TsAnaAlm";
        public const string ArgDigAlmStateDesc = "ArgDigAlmStateDesc";
    }
    /*
Trend - Trend Tags 
CLUSTER, NAME/TAG, RAW_ZERO, RAW_FULL, ENG_ZERO, ENG_FULL, ENG_UNITS, COMMENT, SAMPLEPER, TYPE

DigAlm - Digital Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, DATE, AREA, ALMCOMMENT

AnaAlm - Analog Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, DATE, AREA, VALUE, HIGH, LOW, HIGHHIGH, LOWLOW, DEADBAND, RATE, DEVIATION, ALMCOMMENT

AdvAlm - Advanced Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, DATE, AREA, ALMCOMMENT

HResAlm - Time-Stamped Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, MILLISEC, DATE, AREA, ALMCOMMENT

ArgDigAlm - Argyle Digital Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, DATE, AREA, ALMCOMMENT, PRIORITY, STATE_DESC, OLD_DESC

ArgAnaAlm - Argyle Analog Alarm Tags 
CLUSTER, TAG, NAME, HELP, ALMCOMMENT, CATEGORY, STATE, TIME, DATE, AREA, VALUE, PRIORITY, HIGH, LOW, HIGHHIGH, LOWLOW, DEADBAND, RATE, DEVIATION

TsDigAlm - Time-Stamped Digital Alarm Tags 
CLUSTER, TAG, NAME, DESC, CATEGORY, AREA, ALMCOMMENT

TsAnaAlm - Time-Stamped Analog Alarm Tags 
CLUSTER, TAG, NAME, DESC, CATEGORY, AREA, ALMCOMMENT

ArgDigAlmStateDesc - Argyle Digital Alarm Tag State Descriptions 
CLUSTER, TAG, STATE_DESC0, STATE_DESC1, STATE_DESC2, STATE_DESC3, STATE_DESC4, STATE_DESC5, STATE_DESC6, STATE_DESC7

Alarm - Alarm Tags 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, STATE, TIME, DATE, AREA, ALMCOMMENT, VALUE, HIGH, LOW, HIGHHIGH, LOWLOW, DEADBAND, RATE, DEVIATION, PRIORITY, STATE_DESC, OLD_DESC, ALARMTYPE

AlarmSummary - Alarm Summary 
CLUSTER, TAG, NAME, DESC, HELP, CATEGORY, TIME, DATE, AREA, VALUE, HIGH, LOW, HIGHHIGH, LOWLOW, DEADBAND, RATE, DEVIATION, PRIORITY, STATE_DESC, OLD_DESC, ALARMTYPE, ONDATE, ONDATEEXT, ONTIME, ONMILLI, OFFDATE, OFFDATEEXT, OFFTIME, OFFMILLI, DELTATIME, ACKDATE, ACKDATEEXT, ACKTIME, ALMCOMMENT, USERNAME, FULLNAME, USERDESC, SUMSTATE, SUMDESC, NATIVE_SUMDESC, COMMENT, NATIVE_COMMENT

Accum - Accumulators 
PRIV, AREA, CLUSTER, NAME, TRIGGER, VALUE, RUNNING, STARTS, TOTALISER

Tag - Variable Tags 
LocalTag - Local Tags 
Cluster - Clusters  
    */

    public static class PropertyName
    {
        public const string Name = "Name";
        public const string FullName = "FullName";
        public const string Network = "Network";
        public const string BitWidth = "BitWidth";
        public const string UnitType = "UnitType";
        public const string UnitAddress = "UnitAddress";
        public const string UnitCount = "UnitCount";
        public const string RawType = "RawType";
        public const string Raw_Zero = "Raw_Zero";
        public const string Raw_Full = "Raw_Full";
        public const string Eng_Zero = "Eng_Zero";
        public const string Eng_Full = "Eng_Full";
    }

    public static class OpenOptions
    {
        public const int CT_OPEN_CRYPT = 0x00000001; /* use encryption */
        public const int CT_OPEN_RECONNECT = 0x00000002; /* reconnect on failure */
        public const int CT_OPEN_READ_ONLY = 0x00000004; /* read only mode */
        public const int CT_OPEN_BATCH = 0x00000008; /* batch mode */
    }

    public static class FindOptions
    {
        public const int CT_FIND_SCROLL_NEXT = 0x00000001; /* scroll to next record	*/
        public const int CT_FIND_SCROLL_PREV = 0x00000002; /* scroll to prev record	*/
        public const int CT_FIND_SCROLL_FIRST = 0x00000003; /* scroll to first record */
        public const int CT_FIND_SCROLL_LAST = 0x00000004; /* scroll to last record	*/
        public const int CT_FIND_SCROLL_ABSOLUTE = 0x00000005; /* scroll to absolute record	*/
        public const int CT_FIND_SCROLL_RELATIVE = 0x00000006; /* scroll to relative record	*/
    }

    public static class DbType
    {
        public const int DBTYPE_EMPTY = 0;
        public const int DBTYPE_NULL = 1;
        public const int DBTYPE_I2 = 2;
        public const int DBTYPE_I4 = 3;
        public const int DBTYPE_R4 = 4;
        public const int DBTYPE_R8 = 5;
        public const int DBTYPE_CY = 6;
        public const int DBTYPE_DATE = 7;
        public const int DBTYPE_BSTR = 8;
        public const int DBTYPE_IDISPATCH = 9;
        public const int DBTYPE_ERROR = 10;
        public const int DBTYPE_BOOL = 11;
        public const int DBTYPE_VARIANT = 12;
        public const int DBTYPE_IUNKNOWN = 13;
        public const int DBTYPE_DECIMAL = 14;
        public const int DBTYPE_UI1 = 17;
        public const int DBTYPE_ARRAY = 0x2000;
        public const int DBTYPE_BYREF = 0x4000;
        public const int DBTYPE_I1 = 16;
        public const int DBTYPE_UI2 = 18;
        public const int DBTYPE_UI4 = 19;
        public const int DBTYPE_I8 = 20;
        public const int DBTYPE_UI8 = 21;
        public const int DBTYPE_GUID = 72;
        public const int DBTYPE_VECTOR = 0x1000;
        public const int DBTYPE_RESERVED = 0x8000;
        public const int DBTYPE_BYTES = 128;
        public const int DBTYPE_STR = 129;
        public const int DBTYPE_WSTR = 130;
        public const int DBTYPE_NUMERIC = 131;
        public const int DBTYPE_UDT = 132;
        public const int DBTYPE_DBDATE = 133;
        public const int DBTYPE_DBTIME = 134;
        public const int DBTYPE_DBTIMESTAMP = 135;
    };
    #endregion
}