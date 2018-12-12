using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Models.Venue_Management;


namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement
{
    [Binding]
    public class AddVenue_EnterAddressManuallySteps : TestSupport.BaseTest
    {
        AddVenue_EnterAddressManuallyPage EnterAddressManually = new AddVenue_EnterAddressManuallyPage(webDriver);
        AddVenuePage AddVenuePage = new AddVenuePage(webDriver);
        Venue_Data VenueData = new Venue_Data();
        ViewAllLiveVenuesPage ViewAllLiVeVenuesPage = new ViewAllLiveVenuesPage(webDriver);
        AddVenueManualAddressPage AddVenueManualAddressPage = new AddVenueManualAddressPage(webDriver);
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
            AddVenuePage.ClickEnterAddressManuallyLink();
           
        }
        
        [When(@"the Add Venue page displays the fields to enter address")]
        public void WhenTheAddVenuePageDisplaysTheFieldsToEnterAddress()
        {
            AddVenueManualAddressPage.ValidateFields();
        }
        
        [When(@"I enter Valid Venue Name")]
        public void WhenIEnterValidVenueName()
        {
            AddVenueManualAddressPage.AddVenueName(VenueData.VenueName);
        }
        
        [When(@"I enter valid Address Line(.*)")]
        public void WhenIEnterValidAddressLine(int p0)
        {
            AddVenueManualAddressPage.AddAddressLine1(VenueData.AddressLine1);
        }
        
        [When(@"I enter Town or City")]
        public void WhenIEnterTownOrCity()
        {
            AddVenueManualAddressPage.AddTownCity(VenueData.TownCity);
        }
        
        [When(@"I Enter a Valid postcode")]
        public void WhenIEnterAValidPostcode()
        {
            AddVenueManualAddressPage.AddPostCode(VenueData.PostCode);
        }
        
        [When(@"I Click Continue")]
        public void WhenIClickContinue()
        {
            AddVenueManualAddressPage.ClickContinue();
        }
        
        [When(@"I do not enter Venue Name")]
        public void WhenIDoNotEnterVenueName()
        {
            AddVenueManualAddressPage.AddVenueName("");
        }
        
        [When(@"I leave Address Line (.*) as blank")]
        public void WhenILeaveAddressLineAsBlank(int p0)
        {
            AddVenueManualAddressPage.AddAddressLine1("");

        }
        
        [When(@"I leave Town or City as blank")]
        public void WhenILeaveTownOrCityAsBlank()
        {
            AddVenueManualAddressPage.AddTownCity("");
        }
        
        [When(@"I leave PostCode as blank")]
        public void WhenILeavePostCodeAsBlank()
        {
            AddVenueManualAddressPage.AddPostCode("");

        }
        
        [When(@"I enter the following PostCode ""(.*)""")]
        public void WhenIEnterTheFollowingPostCode(string postcode)
        {
            AddVenueManualAddressPage.AddPostCode(postcode);
        }
        
        [Then(@"Add Venue screen with the entered details should be displayed")]
        public void ThenAddVenueScreenWithTheEnteredDetailsShouldBeDisplayed()
        {
            
        }
        
        [Then(@"a venue name validation message should be displayed ""(.*)""")]
        public void ThenAVenueNameValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage.VenueNameValidationMessage(validationMsg);
        }
        
        [Then(@"a Address Line validation message should be displayed ""(.*)""")]
        public void ThenAAddressLineValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage.AddressLineValidationMessage(validationMsg);
        }
        
        [Then(@"a Town or City validation message should be displayed ""(.*)""")]
        public void ThenATownOrCityValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage.TownOrCityValidationMessage(validationMsg);
        }
        
        [Then(@"a postcode validation message should be displayed ""(.*)""")]
        public void ThenAPostcodeValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage.PostcodeValidationMessage(validationMsg);
        }
        
        [Then(@"a valid postcode validation message should be displayed ""(.*)""")]
        public void ThenAValidPostcodeValidationMessageShouldBeDisplayed(string validationMsg)
        {
            AddVenueManualAddressPage.PostcodeValidationMessage(validationMsg);
        }
    }
}
