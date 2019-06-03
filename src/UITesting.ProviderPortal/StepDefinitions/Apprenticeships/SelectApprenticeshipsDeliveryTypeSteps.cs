using System;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Apprenticeships;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.Apprenticeships
{
    [Binding]
    public class SelectApprenticeshipsDeliveryTypeSteps : BaseTest
    {
        [Given(@"I have accessed the apprenticeship delivery screen")]
        public void GivenIHaveAccessedTheApprenticeshipDeliveryScreen()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Given(@"I have selected locations as delivery type")]
        public void GivenIHaveSelectedLocationsAsDeliveryType()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.clickYourLocation();
        }
        
        [Given(@"I have selected employers address as delivery type")]
        public void GivenIHaveSelectedEmployersAddressAsDeliveryType()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.clickEmployer();
        }
        [When(@"I press continue error")]
        public void WhenIPressContinueError()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.ContinueError();
        }


        [Given(@"I have not selected an option")]
        public void GivenIHaveNotSelectedAnOption()
        {
            //ScenarioContext.Current.Pending();
        }

        [When(@"I press continue location")]
        public void WhenIPressContinueLocation()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.ContinueYourLocation();
        }

        [When(@"I press continue employer address")]
        public void WhenIPressContinueEmployerAddress()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.ContinueEmployer();
        }


        [Then(@"the Apprenticeships delivery options screen is displayed")]
        public void ThenTheApprenticeshipsDeliveryOptionsScreenIsDisplayed()
        {
            ClassroomDeliveryOptionPage classroomDeliveryOptionPage = new ClassroomDeliveryOptionPage(webDriver);
        }
        
        [Then(@"I am on the National Provider capability page")]
        [Then(@"the national provider capability page should be delivered")]
        public void ThenTheNationalProviderCapabilityPageShouldBeDelivered()
        {
            NationalProviderCapabilityPage nationalProviderCapabilityPage = new NationalProviderCapabilityPage(webDriver);
        }


        [Then(@"an apprenticeships error message should be displayed ""(.*)""")]
        public void ThenAnApprenticeshipsErrorMessageShouldBeDisplayed(string errMsg)
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
            appDeliveryMethodPage.AppInfoErrorDisplayed(errMsg);
        }

    }
}
