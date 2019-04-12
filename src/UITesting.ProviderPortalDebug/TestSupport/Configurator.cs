using System;
using System.Configuration;

namespace UITesting.ProviderPortalDebug.Debug.TestSupport
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
        private readonly String dFEUser;
        private readonly String dFEPassword;
        private readonly String adminUser;
        private readonly String adminPassword;

        private Configurator()
        {
            browser = ConfigurationManager.AppSettings["config_setting"];
            useBS = ConfigurationManager.AppSettings["useBS"];
            baseUrl = ConfigurationManager.AppSettings["BaseUrl"];
            QualUrl = ConfigurationManager.AppSettings["QualUrl"];
            baseUrlVenues = ConfigurationManager.AppSettings["BaseUrlVenues"];
            baseUrlCourses = ConfigurationManager.AppSettings["BaseUrlCourses"];
            providerbaseUrl = ConfigurationManager.AppSettings["BaseUrlProviders"];
            dFEUser = ConfigurationManager.AppSettings["dFEUser"];
            dFEPassword = ConfigurationManager.AppSettings["dFEPassword"];
            adminUser = ConfigurationManager.AppSettings["AdminUser"];
            adminPassword = ConfigurationManager.AppSettings["AdminPassword"];

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

        public String GetdFEUser()
        {
            return dFEUser;
        }

        public String GetdFEPassword()
        {
            return dFEPassword;
        }

        public String GetadminUser()
        {
            return adminUser;
        }

        public String GetadminPassword()
        {
            return adminPassword;
        }
    }
}