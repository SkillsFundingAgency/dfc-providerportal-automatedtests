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
    public class CompleteApprenticeshipsDetailsSteps : BaseTest
    {
        [Given(@"I have selected an apprenticeship")]
        public void GivenIHaveSelectedAnApprenticeship()
        {
            SearchApprenticeshipPage searchApprenticeshipPage = new SearchApprenticeshipPage(webDriver);
            searchApprenticeshipPage.SelectApprenticeship();
        }
        
        [Given(@"I have accessed the Apprenticeships training details page")]
        public void GivenIHaveAccessedTheApprenticeshipsTrainingDetailsPage()
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
        }
        
        [When(@"I enter apprenticeships information ""(.*)""")]
        public void WhenIEnterApprenticeshipsInformation(string appInfo)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EnterInfo(appInfo);
        }
        
        [When(@"I have entered a website ""(.*)""")]
        public void WhenIHaveEnteredAWebsite(string webSite)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EnterWebsite(webSite);
        }
        
        [When(@"I have entered an email ""(.*)""")]
        public void WhenIHaveEnteredAnEmail(string email)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EnterEmail(email);
        }
        
        [When(@"I have entered a telephone ""(.*)""")]
        public void WhenIHaveEnteredATelephone(string Phone)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EnterPhone(Phone);
        }
        
        [When(@"I have entered contact details ""(.*)""")]
        public void WhenIHaveEnteredContactDetails(string contact)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EnterContactUs(contact);
        }
        
        [When(@"I have clicked continue")]
        public void WhenIHaveClickedContinue()
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.Continue();
        }
        [When(@"I have clicked continue error")]
        public void WhenIHaveClickedContinueError()
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.ContinueError();
        }


        [Then(@"the apprenticeship delivery screen should be visible")]
        public void ThenTheApprenticeshipDeliveryScreenShouldBeVisible()
        {
            AppDeliveryMethodPage appDeliveryMethodPage = new AppDeliveryMethodPage(webDriver);
        }
        
        [Then(@"a App Info error message should be displayed ""(.*)""")]
        public void ThenAAppInfoErrorMessageShouldBeDisplayed(string errMsg)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.AppInfoErrorDisplayed(errMsg,"AddlChar");
        }
        [Then(@"a Blank App Info error message should be displayed ""(.*)""")]
        public void ThenABlankAppInfoErrorMessageShouldBeDisplayed(string errMsg)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.AppInfoErrorDisplayed(errMsg, "Blank");
        }


        [Then(@"a email Info error message should be displayed ""(.*)""")]
        public void ThenAEmailInfoErrorMessageShouldBeDisplayed(string errMsg)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.EmailErrorDisplayed(errMsg);
        }
        
        [Then(@"a phone Info error message should be displayed ""(.*)""")]
        public void ThenAPhoneInfoErrorMessageShouldBeDisplayed(string errMsg)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.PhoneErrorDisplayed(errMsg);
        }
        [Then(@"a website error message should be displayed ""(.*)""")]
        public void ThenAWebsiteErrorMessageShouldBeDisplayed(string errMsg)
        {
            AddApprenticeshipPage addApprenticeshipPage = new AddApprenticeshipPage(webDriver);
            addApprenticeshipPage.WebsiteErrorDisplayed();
        }

    }
}
