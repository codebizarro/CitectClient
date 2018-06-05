using System.Configuration;

namespace CitectClientTest
{
    public static class Configuration
    {
        public static string Address => ConfigurationManager.AppSettings["address"];
        public static bool DoWrite => bool.Parse(ConfigurationManager.AppSettings["dowrite"]);
        public static string User => ConfigurationManager.AppSettings["user"];
        public static string Password => ConfigurationManager.AppSettings["pass"];
        public static string TagRead => ConfigurationManager.AppSettings["tagread"];
        public static string TagWrite => ConfigurationManager.AppSettings["tagwrite"];
    }
}
