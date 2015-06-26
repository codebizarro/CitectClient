using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

    public static class Tables
    {
        public static class Tag
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
        }
        public static class LocalTag
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
        }
        public static class Clusters
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
        }
        public static class Accum
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string PRIV
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TRIGGER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RUNNING
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STARTS
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TOTALISER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class Trend
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RAW_ZERO
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RAW_FULL
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ENG_ZERO
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ENG_FULL
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ENG_UNITS
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string SAMPLEPER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class DigAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class AdvAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class HResAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string MILLISEC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class ArgDigAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class TsDigAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class TsAnaAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class AnaAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class ArgAnaAlm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class ArgDigAlmStateDesc
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC0
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC1
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC2
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC3
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC4
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC5
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC6
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC7
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
        public static class Alarm
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
            public static string ALARMTYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }

            }
        }
        public static class AlarmSummary
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALARMTYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ONDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ONDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ONTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ONMILLI
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OFFDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OFFDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OFFTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string OFFMILLI
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string DELTATIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ACKDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ACKDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ACKTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string USERNAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string FULLNAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string USERDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string SUMSTATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string SUMDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NATIVE_SUMDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
            public static string NATIVE_COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace("get_", "");
                }
            }
        }
    }

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

    [Flags]
    public enum Quality
    {
        None = 0x1,
        Interpolated = 0x2,
        SingleRaw = 0x4,
        MultipleRaw = 0x8,
        Bad = 0x10,
        Good = 0x20,
        LastBad = 0x100,
        LastGood = 0x200,
        NotAvailable = 0x400,
        Gated = 0x800,
        Changed = 0x1000
    }
}
