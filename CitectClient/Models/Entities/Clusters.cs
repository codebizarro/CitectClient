using System.Reflection;

namespace System.Net.CitectClient.Entities
{
    public static partial class CitectEntities
    {
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
    }
}
