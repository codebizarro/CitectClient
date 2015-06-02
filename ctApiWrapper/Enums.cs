using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ctApiWrapper
{
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
        public const uint CT_FIND_SCROLL_NEXT = 0x00000001; /* scroll to next record	*/
        public const uint CT_FIND_SCROLL_PREV = 0x00000002; /* scroll to prev record	*/
        public const uint CT_FIND_SCROLL_FIRST = 0x00000003; /* scroll to first record */
        public const uint CT_FIND_SCROLL_LAST = 0x00000004; /* scroll to last record	*/
        public const uint CT_FIND_SCROLL_ABSOLUTE = 0x00000005; /* scroll to absolute record	*/
        public const uint CT_FIND_SCROLL_RELATIVE = 0x00000006; /* scroll to relative record	*/
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
}
