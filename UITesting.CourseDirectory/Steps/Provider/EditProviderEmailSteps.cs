using System;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;


namespace UITesting.CourseDirectory.Steps
{
    [Binding]
    public class EditProviderEmailSteps:BaseClass
    {
        [Given(@"I have logged in as a provider")]
        public void GivenIHaveLoggedInAsAProvider()
        {
            webDriver.Url = ConfiguratorClass.GetConfiguratorInstance().GetBaseUrl();
            Pages.WelcomePage welcomePage = new Pages.WelcomePage(webDriver);
            Pages.LoginPage loginPage = new Pages.LoginPage(webDriver);
            loginPage.LoginAsProvider();
            
        }
        
        [Given(@"I have accessed the provider details")]
        public void GivenIHaveAccessedTheProviderDetails()
        {
            Pages.ProviderPage ProviderPage = new Pages.ProviderPage(webDriver);
            ProviderPage.AccessProviderDetails();
        }
        
        [Given(@"I have added email to the provider details and clicked Save")]
        public void GivenIHaveAddedEmailToTheProviderDetailsAndClickedSave()
        {
            Pages.ProviderPage ProviderPage = new Pages.ProviderPage(webDriver);
            ProviderClass.GetProviderInstance().EmailValue = RandomDataGenerator.GenerateRandomEmail();
            ProviderPage.UpdateProvider(ProviderClass.GetProviderInstance().GetEmail(), ProviderClass.GetProviderInstance().EmailValue);
           
        }
        
        [Then(@"the provider details should be updated with the email")]
        public void ThenTheProviderDetailsShouldBeUpdatedWithTheEmail()
        {
            Pages.ProviderPage ProviderPage = new Pages.ProviderPage(webDriver);
            ProviderPage.AccessProviderDetails();
            PageInteractionHelper.VerifyEditFieldText(OpenQA.Selenium.By.Id("Email"), ProviderClass.GetProviderInstance().EmailValue);
        }
    }
}
