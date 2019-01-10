﻿using System;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.Venue_Management
{
    [Binding]
    public class ViewLiveVenuesSteps : TestSupport.BaseTest 
    {
        Pages.Venue_Management.ViewAllLiveVenuesPage ViewAllLiveVenuesPage = new Pages.Venue_Management.ViewAllLiveVenuesPage(webDriver);
        Models.Venue_Management.Venue_Data VenueData = new Models.Venue_Management.Venue_Data();
        [Given(@"I have accessed the Course Directory")]
        public void GivenIHaveAccessedTheCourseDirectory()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I have searched for a PRN Number ""(.*)""")]
        public void GivenIHaveSearchedForAPRNNumber(string p0)
        {
            ViewAllLiveVenuesPage.SearchProvider(VenueData.UKPRNNo);
        }
        
        [Then(@"all venues for that provider should be displayed with complete address")]
        public void ThenAllVenuesForThatProviderShouldBeDisplayedWithCompleteAddress()
        {
            ViewAllLiveVenuesPage.ValidateVenue();
        }
        
        [Then(@"links to Edit and Archive should be visible")]
        public void ThenLinksToEditAndArchiveShouldBeVisible()
        {
            ViewAllLiveVenuesPage.CheckEditLink();
            ViewAllLiveVenuesPage.CheckArchiveLink();
        }
        
        [Then(@"Add Venue Button should be visible")]
        public void ThenAddVenueButtonShouldBeVisible()
        {
            ViewAllLiveVenuesPage.CheckAddVenueButton();
        }
        
        [Then(@"I should be able to view my archived venues")]
        public void ThenIShouldBeAbleToViewMyArchivedVenues()
        {
            ViewAllLiveVenuesPage.ViewArchivedVenues();
        }
    }
}
