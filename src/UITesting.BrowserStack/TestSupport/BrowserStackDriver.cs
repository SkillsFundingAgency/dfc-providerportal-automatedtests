using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Configuration;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Collections.Specialized;
using BrowserStack;
using System.IO;

namespace UITesting.BrowserStack.TestSupport
{

    public class BrowserStackDriver
    {
        private IWebDriver webDriver;
        private Local browserStackLocal;
        //private string profile;
        //private string environment;
        private ScenarioContext context;

        public BrowserStackDriver(ScenarioContext context)
        {
            this.context = context;

        }

        public IWebDriver Init(string profile, string environment)
        {
            NameValueCollection caps = ConfigurationManager.GetSection("capabilities/" + profile) as NameValueCollection;
            NameValueCollection settings = ConfigurationManager.GetSection("environments/" + environment) as NameValueCollection;

            DesiredCapabilities capability = new DesiredCapabilities();

            foreach (string key in caps.AllKeys)
            {
                capability.SetCapability(key, caps[key]);
            }

            foreach (string key in settings.AllKeys)
            {
                capability.SetCapability(key, settings[key]);
            }

            String username = Environment.GetEnvironmentVariable("BROWSERSTACK_USERNAME");
            if (username == null)
            {
                username = ConfigurationManager.AppSettings.Get("user");
            }

            String accesskey = Environment.GetEnvironmentVariable("BROWSERSTACK_ACCESS_KEY");
            if (accesskey == null)
            {
                accesskey = ConfigurationManager.AppSettings.Get("key");
            }

            capability.SetCapability("browserstack.user", username);
            capability.SetCapability("browserstack.key", accesskey);

            //File.AppendAllText("C:\\Users\\Admin\\Desktop\\sf.log", "Starting local");

            if (capability.GetCapability("browserstack.local") != null && capability.GetCapability("browserstack.local").ToString() == "true")
            {
                browserStackLocal = new Local();
                List<KeyValuePair<string, string>> bsLocalArgs = new List<KeyValuePair<string, string>>() {
          new KeyValuePair<string, string>("key", accesskey)
        };
                browserStackLocal.start(bsLocalArgs);
            }

            // File.AppendAllText("C:\\Users\\Admin\\Desktop\\sf.log", "Starting driver");
            webDriver = new RemoteWebDriver(new Uri("http://" + ConfigurationManager.AppSettings.Get("server") + "/wd/hub/"), capability);
            return webDriver;
        }

        public void Cleanup()
        {
            webDriver.Quit();
            if (browserStackLocal != null)
            {
                browserStackLocal.stop();
            }
        }
    }
}