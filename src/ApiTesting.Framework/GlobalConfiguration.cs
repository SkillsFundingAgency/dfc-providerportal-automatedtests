using System;
using System.Configuration;

namespace ApiTesting.Framework
{
    public class GlobalConfiguration
    {
        public static Uri Url => new Uri(ConfigurationManager.AppSettings["Url"]);
        public static Uri LARS => new Uri(ConfigurationManager.AppSettings["LARS"]);
        public static Uri UKRLP => new Uri(ConfigurationManager.AppSettings["UKRLP"]);

        public static string UKRLP_Key = ConfigurationManager.AppSettings["UKRLP_Key"];

        public static string LARS_Key = ConfigurationManager.AppSettings["LARS_Key"];
    }
}
