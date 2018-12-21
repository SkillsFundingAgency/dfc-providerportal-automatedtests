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
    public class EditVenueSteps : BaseTest
    {

        [When(@"I click Edit against the first venue")]
        public void WhenIClickEditAgaisntTheFirstVenue()
        {
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.ClickFirstEdit();
        }


        [Then(@"I am on the Edit venue details page")]
        public void ThenIAmOnTheEditVenueDetailsPage()
        {
            EditVenueConfirmAddressPage editVenueConfirmAddressPage = new EditVenueConfirmAddressPage(webDriver);
            PageInteractionHelper.WaitForPageToLoad();
        }

        [When(@"I click Change Name on Edit Venue page")]
        public void WhenIClickChangeNameOnEditVenuePage()
        {
            EditVenueConfirmAddressPage editVenueConfirmAddressPage = new EditVenueConfirmAddressPage(webDriver);
            editVenueConfirmAddressPage.ChangeName();
        }

        [When(@"I click Change Address on Edit Venue page")]
        public void WhenIClickChangeAddressOnEditVenuePage()
        {
            EditVenueConfirmAddressPage editVenueConfirmAddressPage = new EditVenueConfirmAddressPage(webDriver);
            editVenueConfirmAddressPage.ChangeAddress();
        }


        [Then(@"I am on Edit Venue name page")]
        public void ThenIAmOnEditVenueNamePage()
        {
            AddVenueEditNamePage addVenueEditNamePage = new AddVenueEditNamePage(webDriver);
            PageInteractionHelper.WaitForPageToLoad();
        }

        [Then(@"I am on Edit Venue Address page")]
        public void ThenIAmOnEditVenueAddressPage()
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            PageInteractionHelper.WaitForPageToLoad();
        }


        [When(@"I edit the venue name to (.*)")]
        public void WhenIEditTheVenueName(string venueName)
        {
            AddVenueEditNamePage addVenueEditNamePage = new AddVenueEditNamePage(webDriver);
            addVenueEditNamePage.EnterVenueName(venueName);
        }

        [When(@"I edit the venue address to (.*)")]
        public void WhenIEditTheVenueAddressToNewVenueAddress(string postcode)
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            addVenueEditAddressPage.EditingEnterPostCode(postcode);
            addVenueEditAddressPage.ClickFindAddress();
        }

        [When(@"I chose the following address (.*)")]
        public void WhenIChoseTheFollowingAddress(string address)
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            addVenueEditAddressPage.selectAddress(address);
        }


        [When(@"I click continue on edit venue name page")]
        public void WhenIClickContinueOnEditVenueNamePage()
        {
            AddVenueEditNamePage addVenueEditNamePage = new AddVenueEditNamePage(webDriver);
            addVenueEditNamePage.ClickContinue();
        }

        [When(@"I click continue on edit venue address page")]
        public void WhenIClickContinueOnEditVenueAddressPage()
        {
            AddVenueEditAddressPage addVenueEditAddressPage = new AddVenueEditAddressPage(webDriver);
            addVenueEditAddressPage.ClickContinue();
        }



        [When(@"I click continue on the Edit venue details page")]
        public void WhenIClickContinueOnEditVenueDetailsPage()
        {
            EditVenueConfirmAddressPage editVenueConfirmAddressPage = new EditVenueConfirmAddressPage(webDriver);
            editVenueConfirmAddressPage.ClickContinue();
        }

    }
}