using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;


namespace UITesting.CourseDirectory.Steps 
{
    [Binding]
    public class LoginAsProviderSteps : BaseClass
    {
        [Given(@"I have accessed the course directory")]
        public void GivenIHaveAccessedTheCourseDirectory()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage WelcomePage = new Pages.WelcomePage(webDriver);
        }
        
        [Given(@"I have entered valid provider credentials and clicked Login")]
        public void GivenIHaveEnteredValidProviderCredentialsAndClickedLogin()
        {
            
            Pages.LoginPage LoginPage = new Pages.LoginPage(webDriver);
            LoginPage.LoginAsProvider();
        }
        
        [Then(@"I should be logged in as Provider")]
        public void ThenIShouldBeLoggedInAsProvider()
        {
           // PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath("/html/body/div[3]/div[1]/h2")).Text, "Mark Paddock - Test Provider");
        }
        
       
    
       
    }
}
