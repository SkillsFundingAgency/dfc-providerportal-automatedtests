using System;
using System.IO;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using UITesting.Framework.Helpers;
//km
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
//km

namespace UITesting.BrowserStack.TestSupport
{
    [Binding]
    public class BaseTest
    {
        protected static IWebDriver webDriver;
        public BrowserStackDriver bsDriver;
        private static string screenshotPath;
        //km
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        protected static string reportLocation;
        //km

        [BeforeTestRun]
        //km
        public static void InitializeReport(object sender, EventArgs e)
        {
            //Create extent report
            string reportPath = "\\BrowserStackReports\\";
            reportLocation = FileSystemHelper.CreateFilePath(reportPath);
            var htmlReporter = new ExtentHtmlReporter(reportLocation);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            htmlReporter.Config.DocumentTitle = reportLocation;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Test Environment", Configurator.GetConfiguratorInstance().GetBaseUrl());
        }
        //km

        [BeforeFeature]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }


        [BeforeScenario, Scope(Tag = "BrowserStack")]
        public void BeforeScenarioBrowserStack()
        {
            bsDriver = new BrowserStackDriver(ScenarioContext.Current);
            ScenarioContext.Current["bsDriver"] = bsDriver;
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
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


        [BeforeScenarioBlock]
        public void BeforeScenarioBlock()
        {
            //TO DO
        }


        [BeforeStep]
        public void BeforeStep()
        {
            //TO DO
        }


        [AfterStep]
        public static void InsertReportingSteps(object sender, EventArgs e)
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "But")
                    scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail((ScenarioContext.Current.TestError.Message)
                                                                                            + (ScenarioContext.Current.TestError.StackTrace));
                    TakeScreenshotOnFailure();
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioStepContext.Current.StepInfo.Text).AddScreenCaptureFromPath(screenshotPath);
                }
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                else if (stepType == "But")
                    scenario.CreateNode<But>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
            }

            if (ScenarioContext.Current.ScenarioExecutionStatus.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            }
        }


        [AfterScenarioBlock]
        public void AfteScenarioBlock()
        {
            //TO DO
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
            extent.Flush();
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