using System.Reflection;

namespace System.Net.CitectClient.Entities
{
    public static partial class CitectEntities
    {
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
    }
}
