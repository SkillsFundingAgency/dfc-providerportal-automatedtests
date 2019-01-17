using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.BrowserStack.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.Linq;

namespace UITesting.BrowserStack.StepDefinitions
{
    //[Scope(Tag = "Venues")]
    [Binding]
    public class BrowserStackSteps
    {
        //private IWebDriver _driver;
        public static IWebDriver webDriver;
        readonly BrowserStackDriver _bsDriver;

        public BrowserStackSteps()
        {

            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Regression"))
            {
                _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            }
            else
            {
                webDriver = (IWebDriver)ScenarioContext.Current["_driver"];
            }
        }


        [Given(@"I have navigated to the Home page using (.*) and (.*)")]
        public void GivenIAmOnTheLandingPage(string profile, string environment)
        {
            webDriver = _bsDriver.Init(profile, environment);
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrl());
            PageInteractionHelper.SetDriver(webDriver);
        }


        [Given(@"I have logged into course directory as a provider")]
        public void LoginToCourseDirectory()
        {
           // webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }

        #region Venues
        [Given(@"I have navigated to the Your Venues Pages")]
        public void NavigateToYourVenuesPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
        }

        [When(@"I click Add Venue")]
        public void GoToAddVenuePage()
        {
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.ClickAddVenueButton();
        }


        [Then(@"I am on the Add Venue page")]
        public void ThenIAmOnTheAddVenuePage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }


        [Then(@"the Add Venue page displays the expected content")]
        public void AddVenuePageContent()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }


        [When(@"I click Find Address")]
        public void WhenIClickFindAddress()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.ClickFindAddress();
        }
        
        [Then(@"Address validation message is displayed (.*)")]
        public void MessageIsDisplayedPostcodeMustBeEntered(string validationMsg)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.AddressValidationMessage(validationMsg);
        }

        [When(@"I enter the following postcode (.*)")]
        public void WhenIEnterTheFollowingPostcode(string postcode)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.EnterPostCode(postcode);
        }


        [Then(@"I am on the Select Address page")]
        public void ThenIAmOnTheSlectAddressPage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        }


        [When(@"I click continue")]
        public void WhenIClickContinue()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickContinue();
        }


        [When(@"I click continue to confirm page")]
        public void WhenIClickContinueIClickContinueToConfirmPage()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickContinueConfirm();
        }


        [Then(@"Select Address validation message is displayed (.*)")]
        public void SelectAddressValidationMessageIsDisplayed(string selectValidationMsg)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.SelectAddressValidationMessage(selectValidationMsg);
        }


        [When(@"I select the address (.*)")]
        public void WhenISelectTheFirstAddressReturned(string address)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.selectAddress(address);

        }

        [Then(@"Venue Name validation message is displayed (.*)")]
        public void VenueNameValidationMessageIsDisplayed(string venueValidationMsg)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.SelectAddressVenueValidationMessage(venueValidationMsg);
        }
        
        [When(@"I enter venue name (.*)")]
        public void WhenIEnterVenueName(string venueName)
        {
            if (venueName == "space")
            {
                venueName = " ";
            }
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.EnterVenueName(venueName);
        }

        [Then(@"I am on the Add Venue Confirm details page")]
        public void ThenIAmOnTheAddVenueConfirmDetailsPage()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [When(@"I Click Change")]
        public void WhenIClickChange()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickChange();
        }


        [When(@"I am on the Add Venue Confirm details page")]
        public void WhenIAmOnTheAddVenueConfirmDetailsPage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [Then(@"the Add venue confirm details page displays the expected content")]
        public void AddVenueConfirmPageContent()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [When(@"On the Confirmation Page I click continue")]
        public void WhenOnTheConfirmationPageIClickContinue()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
            addVenueConfirmAddressPage.ClickContinue();
        }


        [When(@"I enter (.*) and click search")]
        public void WhenIEnterAndClickSearch(string ukprn)
        {
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.SearchProvider(ukprn);
        }
        #endregion Venues

        #region Provider
        [Given(@"I have navigated to the Search Provider Page")]
        public void GivenIAmOnSearchAProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }


        [When(@"I enter (.*) and click search provider")]
        public void WhenIEnterAndClickSearchProvider(string UKPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(UKPRN);
            searchProviderPage.ClickSearchButton();
        }

        [When(@"I click to view my courses")]
        public void WhenIClickToViewMyCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }
        #endregion Provider


    }
}