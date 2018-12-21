using System.Threading;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using UITesting.Framework.Helpers;
using UITesting.BrowserStack.TestSupport;
using UITesting.BrowserStack.Pages;
using UITesting.ProviderPortal.Pages;
using System.Linq;
using UITesting.ProviderPortal.Pages.Venue_Management;

namespace UITesting.BrowserStack.StepDefinitions
{
    [Binding]
    public class BrowserStackSteps
    {
       // private IWebDriver _driver;
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


        [Given(@"I have navigated to the landing page for (.*) and (.*)")]
        public void GivenIAmOnTheLandingPage(string profile, string environment)
        {
            webDriver = _bsDriver.Init(profile, environment);
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrlVenues());
            PageInteractionHelper.SetDriver(webDriver);
        }


        [Given(@"I have navigated to the landing page")]
        public void GivenIAmOnTheLandingPage2()
        {
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrlVenues());
        }


        //[When(@"I do a LARS Search for (.*)"), Scope(Tag = "BrowserStack")]
        //public void WhenISearchForBrowserStack(string searchTerm)
        //{
        //        LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
        //        larsSearchPage.EnterSearchTextAndSubmit(searchTerm);
        //        Thread.Sleep(10);
        //}


        [When(@"I do a LARS Search for (.*)")]
        public void WhenISearchFor(string searchTerm)
        {
            LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
            larsSearchPage.EnterSearchTextAndSubmit(searchTerm);
            larsSearchPage.Submit();
            Thread.Sleep(10);
        }


        //[Then(@"I should see title (.*)"), Scope(Tag = "BrowserStack")]
        //public void ThenIShouldSeeTitleBrowserstack(string searchTerm)
        //{
        //    LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
        //    larsSearchPage.ConfirmLARSdisplayed(searchTerm);
        //}


        [Then(@"I should see title (.*)")]
        public void ThenIShouldSeeTitle(string searchTerm)
        {
            LARSSearchPage larsSearchPage = new LARSSearchPage(webDriver);
            larsSearchPage.ConfirmLARSdisplayed();
        }


        [Given(@"I navigate to GOV\.UK home page")]
        public void GivenINavigateToGOV_UKHomePage()
        {
            webDriver.Navigate().GoToUrl("https://www.gov.uk");
        }


        [When(@"I search for (.*)")]
        public void SearchForText(string searchText)
        {
            WelcomeToGovUkPage welcomeToGovUkPage = new WelcomeToGovUkPage(webDriver);
            welcomeToGovUkPage.EnterSearchTextAndSubmit(searchText);
        }


        [When(@"I click on DFE link")]
        public void ClickOnDfeLink()
        {
            SearchResultsPage searchResultsPage = new SearchResultsPage(webDriver);
            searchResultsPage.ClickDfeLink();
        }


        [Then(@"I should be on (.*) home page")]
        public void ShouldBeOnDfeHomePage(string onPage)
        {
            PageInteractionHelper.VerifyPageHeading(By.TagName("h1"), onPage);
        }


        //[When(@"I click Add Venue")]
        //public void GoToAddVenuePage()
        //{
        //    ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        //    viewAllLiveVenuesPage.ClickAddVenueButton();
        //}


        //[Then(@"I am on the Add Venue page")]
        //public void ThenIAmOnTheAddVenuePage()
        //{
        //    PageInteractionHelper.WaitForPageToLoad();
        //    AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        //}


        //[Then(@"the Add Venue page displays the expected content")]
        //public void AddVenuePageContent()
        //{
        //    AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        //}


        //[When(@"I click Find Address")]
        //public void WhenIClickFindAddress()
        //{
        //    AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        //    addVenuePage.ClickFindAddress();
        //}

        //[Then(@"Address validation message is displayed (.*)")]
        //public void MessageIsDisplayedPostcodeMustBeEntered(string validationMsg)
        //{
        //    AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        //    addVenuePage.AddressValidationMessage(validationMsg);
        //}

        //[When(@"I enter the following postcode (.*)")]
        //public void WhenIEnterTheFollowingPostcode(string postcode)
        //{
        //    AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        //    addVenuePage.EnterPostCode(postcode);
        //}


        //[Then(@"I am on the Select Address page")]
        //public void ThenIAmOnTheSlectAddressPage()
        //{
        //    PageInteractionHelper.WaitForPageToLoad();
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //}


        //[When(@"I click continue")]
        //public void WhenIClickContinue()
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.ClickContinue();
        //}


        //[When(@"I click continue to confirm page")]
        //public void WhenIClickContinueIClickContinueToConfirmPage()
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.ClickContinueConfirm();
        //}


        //[Then(@"Select Address validation message is displayed (.*)")]
        //public void SelectAddressValidationMessageIsDisplayed(string selectValidationMsg)
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.SelectAddressValidationMessage(selectValidationMsg);
        //}


        //[When(@"I select the address (.*)")]
        //public void WhenISelectTheFirstAddressReturned(string address)
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.selectAddress(address);

        //}

        //[Then(@"Venue Name validation message is displayed (.*)")]
        //public void VenueNameValidationMessageIsDisplayed(string venueValidationMsg)
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.SelectAddressVenueValidationMessage(venueValidationMsg);
        //}

        //[When(@"I enter venue name (.*)")]
        //public void WhenIEnterVenueName(string venueName)
        //{
        //    if (venueName == "space")
        //    {
        //        venueName = " ";
        //    }
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.EnterVenueName(venueName);
        //}

        //[Then(@"I am on the Add Venue Confirm details page")]
        //public void ThenIAmOnTheAddVenueConfirmDetailsPage()
        //{
        //    AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        //}


        //[When(@"I Click Change")]
        //public void WhenIClickChange()
        //{
        //    AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        //    addVenueSelectAddressPage.ClickChange();
        //}


        //[When(@"I am on the Add Venue Confirm details page")]
        //public void WhenIAmOnTheAddVenueConfirmDetailsPage()
        //{
        //    AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        //}


        //[Then(@"the Add venue confirm details page displays the expected content")]
        //public void AddVenueConfirmPageContent()
        //{
        //    AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        //}


        //[When(@"On the Confirmation Page I click continue")]
        //public void WhenOnTheConfirmationPageIClickContinue()
        //{
        //    AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        //    addVenueConfirmAddressPage.ClickContinue();
        //}


        //[When(@"I enter (.*) and click search")]
        //public void WhenIEnterAndClickSearch(string ukprn)
        //{
        //    ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        //    viewAllLiveVenuesPage.SearchProvider(ukprn);
        //}


    }
}