using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenueSteps : BaseTest
    {

        [Given(@"I have logged into course directory as a provider")]
        public void LoginToCourseDirectory()
        {
           // webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }

        [Given(@"I have navigated to the Your Venues Pages")]
        public void NavigateToYourVenuesPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }

        [When(@"I click Add Venue")]
        public void GoToAddVenuePage(string searchText)
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
    }
}