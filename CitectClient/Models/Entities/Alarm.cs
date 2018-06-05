using System.Reflection;

namespace System.Net.CitectClient
{
    public static partial class CitectEntities
    {
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
    }
}
