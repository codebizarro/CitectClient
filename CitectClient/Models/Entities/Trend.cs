using System.Reflection;

namespace System.Net.CitectClient.Entities
{
    public static partial class CitectEntities
    {
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
    }
}
