﻿using System.Reflection;

namespace System.Net.CitectClient
{
    public static partial class CitectEntities
    {
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
    }
}
