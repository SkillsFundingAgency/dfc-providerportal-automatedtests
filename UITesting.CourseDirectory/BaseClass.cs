using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;
using NUnit.Framework;

namespace UITesting.CourseDirectory
{
    [Binding]
    public class BaseClass
    {
        protected static IWebDriver webDriver;

        [BeforeTestRun]
        public static void SetUp()
        {
            String browser = ConfiguratorClass.GetConfiguratorInstance().GetBrowser();
            switch (browser)
            {
                case "debug":
                    webDriver = new ChromeDriver();
                    webDriver.Manage().Window.Maximize();
                    webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                    webDriver.Manage().Cookies.DeleteAllCookies();
                    String currentWindow = webDriver.CurrentWindowHandle;
                    webDriver.SwitchTo().Window(currentWindow);
                    break;

                case "firefox":
                    webDriver = new FirefoxDriver();
                    webDriver.Manage().Window.Maximize();
                    break;

                case "ie":
                    webDriver = new InternetExplorerDriver();
                    webDriver.Manage().Window.Maximize();
                    break;

                default:
                    throw new Exception("Driver name does not match OR this framework does not support the webDriver specified");
            }
            PageInteractionHelper.SetDriver(webDriver);
        }
        [AfterTestRun]
        public static void TearDown()
        {
            try
            {
               // TakeScreenshotOnFailure();
            }
            finally
            {
                webDriver.Quit();
            }
        }
    }
}
