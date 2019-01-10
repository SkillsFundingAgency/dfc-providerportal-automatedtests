using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions.VenueManagement

{
    [Binding]
    public class EditVenueNameSteps : BaseTest
    {
        [Given(@"I am on the edit venue name page")]
        public void GivenIAmOnTheEditVenueNamePage()
        {
            webDriver.Url = (Configurator.GetConfiguratorInstance().GetBaseUrl()+ "\\editvenuename");
            Console.WriteLine("set URL");

            EditVenueNamePage editVenueNamePage = new EditVenueNamePage(webDriver);

        }





        [Given(@"I have entered a venue name")]
        public void GivenIHaveEnteredAVenueName()
        {
            EditVenueNamePage editVenueNamePage = new EditVenueNamePage(webDriver);
           
            editVenueNamePage.EnterVenueName("Test Venue Name");
        }

        [When(@"I press commit venue name")]
        public void WhenIPressCommitVenueName()
        {
            EditVenueNamePage editVenueNamePage = new EditVenueNamePage(webDriver);

            editVenueNamePage.ClickContinue();
        }

        [Then(@"I am taken to the next page stub")]
        public void ThenIAmTakenToTheNextPageStub()
        {
            EditVenueNamePage editVenueNamePage = new EditVenueNamePage(webDriver);

            PageInteractionHelper.VerifyElementPresent(By.ClassName, "text-danger");
        }
        



        [Given(@"I have entered a venue name and address")]
        public void GivenIHaveEnteredAVenueNameAndAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"I am on the venue name and address screen")]
        public void GivenIAmOnTheVenueNameAndAddressScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press edit venue name")]
        public void WhenIPressEditVenueName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press edit address")]
        public void WhenIPressEditAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am taken to the change venue name screen")]
        public void ThenIAmTakenToTheChangeVenueNameScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can change the venue name manually")]
        public void ThenICanChangeTheVenueNameManually()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"my new venue name is shown on name screen")]
        public void ThenMyNewVenueNameIsShownOnNameScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am taken to the change address screen")]
        public void ThenIAmTakenToTheChangeAddressScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I click on cancel")]
        public void ThenIClickOnCancel()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"original venue name is shown on the venue name and address screen")]
        public void ThenOriginalVenueNameIsShownOnTheVenueNameAndAddressScreen()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can change the venue name to blank and click commit")]
        public void ThenICanChangeTheVenueNameToBlankAndClickCommit()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I am shown a message (.*)")]
        public void ThenIAmShownAMessage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I can change the venue name to (.*) and click commit")]
        public void ThenICanChangeTheVenueNameToAndClickCommit(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
