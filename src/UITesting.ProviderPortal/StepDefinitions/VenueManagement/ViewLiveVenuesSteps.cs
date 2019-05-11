using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Models.Venue_Management;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class ViewLiveVenuesSteps : BaseTest
    {
        [Given(@"I have navigated to the Venues Pages")]
        public void GivenIHaveNavigatedToTheVenuesPages()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
        }

        [Then(@"links to Edit and Archive should be visible")]
        public void ThenLinksToEditAndArchiveShouldBeVisible()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.CheckEditLink();
        }

        [Then(@"I am on the View All Live Venues Page")]
        public void ThenIamontheViewAllLiveVenuesPage()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        }
        
        [Then(@"Add Venue Button should be visible")]
        public void ThenAddVenueButtonShouldBeVisible()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.CheckAddVenueButton();
        }

        [Then(@"System displays banner message")]
        public void SystemDisplaysBannerMessage()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.VenueAddedBanner();
        }

        [Then(@"System displays new Venue added (.*)")]
        public void SystemDisplaysNewVenueAdded(string venueName)
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.VenueEdited(venueName);
        }

        [When(@"I delete the following venue (.*)")]
        public void CountVenues(string venue)
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.DeleteVenue(venue);
        }

    }
}
