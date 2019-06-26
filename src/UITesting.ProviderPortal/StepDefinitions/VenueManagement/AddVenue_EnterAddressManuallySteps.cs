using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Models.Venue_Management;


namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenue_EnterAddressManuallySteps : TestSupport.BaseTest
    {

        [Given(@"I have logged as a provider")]
        public void GivenIHaveLoggedAsAProvider()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
        }
        
        [Given(@"I have navigated to Your Venues page")]
        public void GivenIHaveNavigatedToYourVenuesPage()
        {
            ViewAllLiveVenuesPage ViewAllLiVeVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            ViewAllLiVeVenuesPage.SearchProvider(VenueData.UKPRNNo);
            
        }
        
        [When(@"I have select Add Venue")]
        public void WhenIHaveSelectAddVenue()
        {
            ViewAllLiveVenuesPage ViewAllLiVeVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            ViewAllLiVeVenuesPage.ClickAddVenueButton();
        }
        
        [When(@"on the Add Venue page I want to enter address manually")]
        public void WhenOnTheAddVenuePageIWantToEnterAddressManually()
        {
            AddVenuePage AddVenuePage = new AddVenuePage(webDriver);
            AddVenuePage.ClickEnterAddressManuallyLink();
           
        }
        
        [When(@"the Add Venue page displays the fields to enter address")]
        public void WhenTheAddVenuePageDisplaysTheFieldsToEnterAddress()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.ValidateFields();
        }
        
        [When(@"I enter Valid Venue Name")]
        public void WhenIEnterValidVenueName()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            string venueName = VenueData.VenueName + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            AddVenueManualAddressPage.AddVenueName(venueName);
        }
        
        [When(@"I enter valid Address Line(.*)")]
        public void WhenIEnterValidAddressLine(int p0)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            AddVenueManualAddressPage.AddAddressLine1(VenueData.AddressLine1);
        }
        
        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            AddVenueManualAddressPage.AddTownCity(VenueData.TownCity);
        }
        
        [When(@"I Enter a Valid postcode")]
        public void WhenIEnterAValidPostcode()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            Venue_Data VenueData = new Venue_Data();
            AddVenueManualAddressPage.AddPostCode(VenueData.PostCode);
        }
        
        [When(@"I Click Continue")]
        public void WhenIClickContinue()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.ClickContinue();
        }
        
        [When(@"I do not enter Venue Name")]
        public void WhenIDoNotEnterVenueName()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddVenueName("");
        }
        
        [When(@"I leave Address Line (.*) as blank")]
        public void WhenILeaveAddressLineAsBlank(int p0)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddAddressLine1("");

        }
        
        [When(@"I leave Town or City as blank")]
        public void WhenILeaveTownOrCityAsBlank()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddTownCity("");
        }
        
        [When(@"I leave PostCode as blank")]
        public void WhenILeavePostCodeAsBlank()
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddPostCode("");

        }
        
        [When(@"I enter the following PostCode ""(.*)""")]
        public void WhenIEnterTheFollowingPostCode(string postcode)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddPostCode(postcode);
        }
        
        [Then(@"Add Venue screen with the entered details should be displayed")]
        public void ThenAddVenueScreenWithTheEnteredDetailsShouldBeDisplayed()
        {
            
        }
        
        [Then(@"a venue name validation message should be displayed ""(.*)""")]
        public void ThenAVenueNameValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.VenueNameValidationMessage(validationMsg);
        }
        
        [Then(@"a Address Line validation message should be displayed ""(.*)""")]
        public void ThenAAddressLineValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.AddressLineValidationMessage(validationMsg);
        }
        
        [Then(@"a Town or City validation message should be displayed ""(.*)""")]
        public void ThenATownOrCityValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.TownOrCityValidationMessage(validationMsg);
        }
        
        [Then(@"a postcode validation message should be displayed ""(.*)""")]
        public void ThenAPostcodeValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.PostcodeValidationMessage(validationMsg);
        }
        
        [Then(@"a valid postcode validation message should be displayed ""(.*)""")]
        public void ThenAValidPostcodeValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
            AddVenueManualAddressPage.PostcodeValidationMessage(validationMsg);
        }
    }
}
