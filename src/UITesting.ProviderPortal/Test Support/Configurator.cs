using System;
using System.Configuration;

namespace UITesting.ProviderPortal.TestSupport
{
    public class Configurator
    {
        private static Configurator configuratorInstance = null;

        private readonly String browser;
        private readonly String baseUrlVenues;
        private readonly String baseUrlCourses;
        private readonly String baseUrl;
        private readonly String providerbaseUrl;
        private readonly String useBS;
        private readonly String QualUrl;
        private readonly String YourCoursesUrl;
        

        private Configurator()
        {
            browser = ConfigurationManager.AppSettings["config_setting"];
            useBS = ConfigurationManager.AppSettings["useBS"];
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            QualUrl = ConfigurationManager.AppSettings["QualUrl"];
            baseUrlVenues = ConfigurationManager.AppSettings["BaseUrlVenues"];
            baseUrlCourses = ConfigurationManager.AppSettings["BaseUrlCourses"];
            providerbaseUrl = ConfigurationManager.AppSettings["BaseUrlProviders"];
            
        }

        public static Configurator GetConfiguratorInstance()
        {
            if (configuratorInstance == null)
            {
                configuratorInstance = new Configurator();
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

        public String GetBaseUrlVenues()
        {
            return baseUrlVenues;
        }

        public String GetBaseUrlCourses()
        {
            return baseUrlCourses;
        }

        public String GetProviderBaseUrl()
        {
            return providerbaseUrl; 
        }
       

        public String GetUseBS()
        {
            return useBS;
        }

        public String GetQualUrl()
        {
            return QualUrl;
        }

    }
}