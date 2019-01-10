using System;
using System.Collections.Generic;
using System.Configuration;


namespace UITesting.CourseDirectory 
{
    class ConfiguratorClass
    {
        private static ConfiguratorClass configuratorInstance = null;

        private readonly String browser;
        private readonly String baseUrl;


        private ConfiguratorClass()
        {
            browser = ConfigurationManager.AppSettings["config_setting"];
            //useBS = ConfigurationManager.AppSettings["useBS"];
            baseUrl = ConfigurationManager.AppSettings["url"];
        }

        public static ConfiguratorClass GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new ConfiguratorClass();
            }
            return configuratorInstance;
        }

       public String GetBrowser()
        {
            return browser;
        }

        public String GetBaseUrl()
        {
            return baseUrl;
        }

       /* public String GetUseBS()
        {
            return useBS;
        }*/
    }
}
