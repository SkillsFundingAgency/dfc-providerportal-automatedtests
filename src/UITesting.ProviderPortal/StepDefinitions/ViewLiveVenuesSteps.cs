using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Models.Venue_Management;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.StepDefinitions.Venue_Management
{
    [Binding]
    public class ViewLiveVenuesSteps : BaseTest 
    {
        //ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        //Venue_Data VenueData = new Venue_Data();
        [Given(@"I have accessed the Course Directory")]
        public void GivenIHaveAccessedTheCourseDirectory()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
        }
        
        [Given(@"I have searched for a PRN Number ""(.*)""")]
        public void GivenIHaveSearchedForAPRNNumber(string p0)
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            ViewAllLiveVenuesPage.SearchProvider(VenueData.UKPRNNo);
        }
        
        [Then(@"all venues for that provider should be displayed with complete address")]
        public void ThenAllVenuesForThatProviderShouldBeDisplayedWithCompleteAddress()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.ValidateVenue();
        }
        
        [Then(@"links to Edit and Archive should be visible")]
        public void ThenLinksToEditAndArchiveShouldBeVisible()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.CheckEditLink();
            ViewAllLiveVenuesPage.CheckArchiveLink();
        }
        
        [Then(@"Add Venue Button should be visible")]
        public void ThenAddVenueButtonShouldBeVisible()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.CheckAddVenueButton();
        }
        
        [Then(@"I should be able to view my archived venues")]
        public void ThenIShouldBeAbleToViewMyArchivedVenues()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage.ViewArchivedVenues();
        }

        [Then(@"I am on the View All Live Venues Page")]
        public void ThenIAmOnTheViewAllLiveVenuesPage()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        }

        [Then(@"System displays new Venue added (.*)")]
        public void ThenSystemDisplaysNewVenueAdded(string venueName)
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.VenueAdded(venueName);
        }

        [Then(@"System displays banner message")]
        public void DisplaysBannerMessageVenueAdded()
        {
            ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.VenueAddedBanner();
        }

    }
}
