﻿using System.Reflection;

namespace System.Net.CitectClient
{
    public static partial class CitectEntities
    {
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
    }
}
