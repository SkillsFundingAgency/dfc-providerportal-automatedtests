using System;
using System.IO;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITesting.Framework.Helpers;

namespace UITesting.BrowserStack.TestSupport
{
    [Binding]
    public class BaseTest
    {
        protected static IWebDriver webDriver;
        public BrowserStackDriver bsDriver;
        //private string[] tags;
        private static string screenshotPath;


        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            //TODO
        }


        [BeforeScenario, Scope(Tag = "BrowserStack")]
        public void BeforeScenarioBrowserStack()
        {
            bsDriver = new BrowserStackDriver(ScenarioContext.Current);
            ScenarioContext.Current["bsDriver"] = bsDriver;           
        }


        [BeforeScenario, Scope(Tag = "Regression")]
        public void BeforeScenario()
        {
            webDriver = new ChromeDriver();
            ScenarioContext.Current["_driver"] = webDriver;
            webDriver.Manage().Window.Maximize();
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Manage().Cookies.DeleteAllCookies();
            String currentWindow = webDriver.CurrentWindowHandle;
            webDriver.SwitchTo().Window(currentWindow);

            PageInteractionHelper.SetDriver(webDriver);
        }
        

        [AfterScenario, Scope(Tag = "BrowserStack")]
        public void AfterScenarioBrowserStack()
        {
            bsDriver.Cleanup();
        }


        [AfterScenario, Scope(Tag = "Regression")]
        public void AfterScenario()
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

        [AfterTestRun]
        public static void TearDown()
        {
            //TODO
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
                    Console.WriteLine(scenarioTitle
                        + " -- Scenario failed and the screenshot is available at -- "
                        + screenshotPath);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Exception occurred while taking screenshot - " + exception);
                }
            }
        }
    }
}