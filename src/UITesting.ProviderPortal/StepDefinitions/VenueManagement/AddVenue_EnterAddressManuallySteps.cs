using System;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenue_EnterAddressManuallySteps : TestSupport.BaseTest
    {
        Pages.Venue_Management.AddVenue_EnterAddressManually EnterAddressManually = new Pages.Venue_Management.AddVenue_EnterAddressManually(webDriver);
        [Given(@"I have logged as a provider")]
        public void GivenIHaveLoggedAsAProvider()
        {
            //webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }
        
        [Given(@"I want to add a new venue")]
        public void GivenIWantToAddANewVenue()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();            
        }
        
        [When(@"I have select Add Venue")]
        public void WhenIHaveSelectAddVenue()
        {
            Pages.Venue_Management.ViewAllLiveVenuesPage ViewAllLiVeVenuesPage = new Pages.Venue_Management.ViewAllLiveVenuesPage(webDriver);
            ViewAllLiVeVenuesPage.ClickAddVenueButton();
        }
        
        [When(@"on the Add Venue page I want to enter address manually")]
        public void WhenOnTheAddVenuePageIWantToEnterAddressManually()
        {
            EnterAddressManually.ClickEnterAddressManually();
        }
        
        [When(@"the Add Venue page displays the fields to enter address")]
        public void WhenTheAddVenuePageDisplaysTheFieldsToEnterAddress()
        {
            Pages.Venue_Management.AddVenuePage AddVenuePage = new  Pages.Venue_Management.AddVenuePage(webDriver);
        }
        
        [When(@"I enter Valid Venue Name")]
        public void WhenIEnterValidVenueName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter valid Address Line(.*)")]
        public void WhenIEnterValidAddressLine(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Enter a Valid postcode")]
        public void WhenIEnterAValidPostcode()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I Click Continue")]
        public void WhenIClickContinue()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I do not enter Venue Name")]
        public void WhenIDoNotEnterVenueName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I leave Address Line (.*) as blank")]
        public void WhenILeaveAddressLineAsBlank(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I leave Town or City as blank")]
        public void WhenILeaveTownOrCityAsBlank()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I leave PostCode as blank")]
        public void WhenILeavePostCodeAsBlank()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter the following PostCode ""(.*)""")]
        public void WhenIEnterTheFollowingPostCode(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"Add Venue screen with the entered details should be displayed")]
        public void ThenAddVenueScreenWithTheEnteredDetailsShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
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
