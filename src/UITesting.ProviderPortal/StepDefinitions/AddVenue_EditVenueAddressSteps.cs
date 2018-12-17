using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class AddVenue_EditVenueAddressSteps : BaseTest
    {
        [Given(@"I am on the edit venue address screen")]
        public void GivenIAmOnTheEditVenueAddressScreen()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
            addVenueConfirmAddressPage.EditAddress();
        }

        [When(@"I click Find Address to change to")]
        public void WhenIClickFindAddressToChangeTo()
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            addVenueEditAddressPage.ClickFindAddress();
        }

        [Then(@"I am on the Select Address to change to page")]
        public void ThenIAmOnTheSelectAddressToChangeToPage()
        {
            ScenarioContext.Current.Pending();
        }


        [When(@"Editing I enter the postcode(.*)")]
        public void WhenEditingIEnterThePostcode(string postcode)
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            addVenueEditAddressPage.EditingEnterPostCode(postcode);
        }


    }
}
