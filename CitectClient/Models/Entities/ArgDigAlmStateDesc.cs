using System.Reflection;

namespace System.Net.CitectClient
{
    public static partial class CitectEntities
    {
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
    }
}
