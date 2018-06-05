using System.Reflection;

namespace System.Net.CitectClient
{
    public static class Tables
    {
        const string GET = "get_";
        public static class Tag
        {
            public static string TableName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().DeclaringType.Name;
                }
            }
            public static string Name
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string FullName
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string Network
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string BitWidth
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string UnitType
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string UnitAddress
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string UnitCount
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RawType
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string Raw_Zero
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string Raw_Full
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string Eng_Zero
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string Eng_Full
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CLUSTER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TRIGGER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RUNNING
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STARTS
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TOTALISER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RAW_ZERO
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RAW_FULL
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ENG_ZERO
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ENG_FULL
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ENG_UNITS
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string SAMPLEPER
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string MILLISEC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC0
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC1
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC2
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC3
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC4
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC5
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC6
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC7
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }

            }
            public static string ALARMTYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
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
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TAG
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HELP
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string CATEGORY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string TIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string AREA
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string VALUE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string HIGHHIGH
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string LOWLOW
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEADBAND
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string RATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DEVIATION
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string PRIORITY
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string STATE_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OLD_DESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALARMTYPE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ONDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ONDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ONTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ONMILLI
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OFFDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OFFDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OFFTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string OFFMILLI
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string DELTATIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ACKDATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ACKDATEEXT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ACKTIME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string ALMCOMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string USERNAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string FULLNAME
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string USERDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string SUMSTATE
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string SUMDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NATIVE_SUMDESC
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
            public static string NATIVE_COMMENT
            {
                get
                {
                    return MethodBase.GetCurrentMethod().Name.Replace(GET, "");
                }
            }
        }
    }
}
