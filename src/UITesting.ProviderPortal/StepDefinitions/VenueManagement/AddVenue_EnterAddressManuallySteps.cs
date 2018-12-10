using System;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenue_EnterAddressManuallySteps : TestSupport.BaseTest
    {
        Pages.Venue_Management.AddVenue_EnterAddressManuallyPage EnterAddressManually = new Pages.Venue_Management.AddVenue_EnterAddressManuallyPage(webDriver);
        Models.Venue_Management.Venue_Data VenueData = new Models.Venue_Management.Venue_Data();
        Pages.Venue_Management.ViewAllLiveVenuesPage ViewAllLiVeVenuesPage = new Pages.Venue_Management.ViewAllLiveVenuesPage(webDriver);
        Pages.Venue_Management.AddVenuePage AddVenuePage = new Pages.Venue_Management.AddVenuePage(webDriver);
        [Given(@"I have logged as a provider")]
        public void GivenIHaveLoggedAsAProvider()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I have navigated to Your Venues page")]
        public void GivenIHaveNavigatedToYourVenuesPage()
        {
            ViewAllLiVeVenuesPage.SearchProvider(VenueData.UKPRNNo);
            
        }
        
        [When(@"I have select Add Venue")]
        public void WhenIHaveSelectAddVenue()
        {
            ViewAllLiVeVenuesPage.ClickAddVenueButton();
        }
        
        [When(@"on the Add Venue page I want to enter address manually")]
        public void WhenOnTheAddVenuePageIWantToEnterAddressManually()
        {
            // EnterAddressManually.ClickEnterAddressManually();
            AddVenuePage.ClickEnterAddressManually();
        }
        
        [When(@"the Add Venue page displays the fields to enter address")]
        public void WhenTheAddVenuePageDisplaysTheFieldsToEnterAddress()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Valid Venue Name")]
        public void WhenIEnterValidVenueName()
        {
            AddVenuePage.EnterVenueName(VenueData.VenueName);
        }
        
        [When(@"I enter valid Address Line(.*)")]
        public void WhenIEnterValidAddressLine(int p0)
        {
            AddVenuePage.EnterAddressLine1(VenueData.AddressLine1);
        }
        
        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {
            AddVenuePage.EnterTownCity(VenueData.City);
        }
        
        [When(@"I Enter a Valid postcode")]
        public void WhenIEnterAValidPostcode()
        {
            AddVenuePage.EnterPostCode(VenueData.PostCode);
        }
        
        [When(@"I Click Continue")]
        public void WhenIClickContinue()
        {
            EnterAddressManually.ClickContinue();
        }
        
        [When(@"I do not enter Venue Name")]
        public void WhenIDoNotEnterVenueName()
        {
            AddVenuePage.EnterVenueName("");
        }
        
        [When(@"I leave Address Line (.*) as blank")]
        public void WhenILeaveAddressLineAsBlank(int p0)
        {
            AddVenuePage.EnterAddressLine1(""); 
        }
        
        [When(@"I leave Town or City as blank")]
        public void WhenILeaveTownOrCityAsBlank()
        {
            AddVenuePage.EnterTownCity("");
        }
        
        [When(@"I leave PostCode as blank")]
        public void WhenILeavePostCodeAsBlank()
        {
            AddVenuePage.EnterPostCode("");
        }
        
        [When(@"I enter the following PostCode ""(.*)""")]
        public void WhenIEnterTheFollowingPostCode(string p0)
        {
            AddVenuePage.EnterPostCode("XXXXX");
        }
        
        [Then(@"Add Venue screen with the entered details should be displayed")]
        public void ThenAddVenueScreenWithTheEnteredDetailsShouldBeDisplayed()
        {
            
        }
        
        [Then(@"a venue name validation message should be displayed ""(.*)""")]
        public void ThenAVenueNameValidationMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Address Line validation message should be displayed ""(.*)""")]
        public void ThenAAddressLineValidationMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a Town or City validation message should be displayed ""(.*)""")]
        public void ThenATownOrCityValidationMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a postcode validation message should be displayed ""(.*)""")]
        public void ThenAPostcodeValidationMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a valid postcode validation message should be displayed ""(.*)""")]
        public void ThenAValidPostcodeValidationMessageShouldBeDisplayed(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
