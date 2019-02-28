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
        
        [Then(@"Add Venue Button should be visible")]
        public void ThenAddVenueButtonShouldBeVisible()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.CheckAddVenueButton();
        }
    }
}
