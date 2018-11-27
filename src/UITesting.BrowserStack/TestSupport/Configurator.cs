using System;
using System.Configuration;

namespace UITesting.BrowserStack.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;

        private readonly String baseUrl;

        private Configurator()
        {
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
        }

        public static Configurator GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new Configurator();
            }
            return configuratorInstance;
        }

        public String GetBaseUrl()
        {
            return baseUrl;
        }

    }
}