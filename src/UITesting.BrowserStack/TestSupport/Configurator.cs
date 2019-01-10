using System;
using System.Configuration;

namespace UITesting.BrowserStack.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;

        private readonly String baseUrl;
        private readonly String baseUrlVenues;

        private Configurator()
        {
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            baseUrlVenues = ConfigurationManager.AppSettings["BaseUrlVenues"];
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

        public String GetBaseUrlVenues()
        {
            return baseUrlVenues;
        }

    }
}