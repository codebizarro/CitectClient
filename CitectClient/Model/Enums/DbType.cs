using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ctApiWrapper
{
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
}
