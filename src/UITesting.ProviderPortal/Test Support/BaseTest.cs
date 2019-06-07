using System;
using System.IO;
using UITesting.Framework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;




namespace UITesting.ProviderPortal.TestSupport
{
    [Binding]
    public class BaseTest
    {
        protected static IWebDriver webDriver;
        private static string screenshotPath;

        [Scope(Tag ="CI")]
        [BeforeScenario]
        //[BeforeTestRun]
        public static void SetUp()
        {
            String browser = Configurator.GetConfiguratorInstance().GetBrowser();
            switch (browser)
            {
                case "debug":
                    //webDriver = new ChromeDriver();
                    webDriver = new FirefoxDriver();
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

        [Scope(Tag = "CI")]
        [AfterScenario]
        [AfterTestRun]
        public static void TearDown()
        {
            try
            {
                TakeScreenshotOnFailure();
            }
            finally
            {
                webDriver.Quit();
            }
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //TODO: implement logic that has to run before each scenario
        }

        //[Scope(Tag = "CI")]
        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
           // webDriver.Dispose();
        }


        [BeforeStep]
        public void BeforeStep()
        {
            //TODO: implement logic that has to run before executing each step
        }


        [AfterStep]
        public static void AfterStep()
        {
            //TODO: implement logic that has to run after each test step
        }

        public static void TakeScreenshotOnFailure()
        {
            if (ScenarioContext.Current.TestError != null)
            {
                try
                {
                    DateTime dateTime = DateTime.Now;
                    String featureTitle = FeatureContext.Current.FeatureInfo.Title;
                    String scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
                    String failureImageName = dateTime.ToString("HH-mm-ss")
                        + "_"
                        + scenarioTitle
                        + ".png";
                    String screenshotsDirectory = AppDomain.CurrentDomain.BaseDirectory
                        + "../../"
                        + "\\Project\\Screenshots\\"
                        + dateTime.ToString("dd-MM-yyyy")
                        + "\\";
                    if (!Directory.Exists(screenshotsDirectory))
                    {
                        Directory.CreateDirectory(screenshotsDirectory);
                    }

                    ITakesScreenshot screenshotHandler = webDriver as ITakesScreenshot;
                    Screenshot screenshot = screenshotHandler.GetScreenshot();
                    screenshotPath = Path.Combine(screenshotsDirectory, failureImageName);
                    screenshot.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception occurred while taking screenshot - " + exception);
                }
            }
        }

    }
}