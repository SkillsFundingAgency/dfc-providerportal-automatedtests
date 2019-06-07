using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenueSelectAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Add venue";
        private By venueName = By.Id("VenueName");
        private By addressSelector = By.Id("address-selector");
        private By clickChange = By.LinkText("Change");


        private By continueButton = By.Id("venueAddressConfirmationSelection");
        private By AddressSelectionPCValidationMessage = By.Id("PostcodeId-error");
        private By AddressSelectionVenueValidationMessage = By.Id("VenueName-error");
        //private By addressList = By.CssSelector("#address-list");
        private By addressList = By.XPath(".//*[@id='PostcodeLookupContainer']/div/div[2]/select");

        public AddVenueSelectAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public AddVenueSelectAddressPage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterTextWithoutClearing(venueName, name);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage EnterVenueName2(String name)
        {

            string venName = name + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            FormCompletionHelper.EnterTextWithoutClearing(venueName, name);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage selectAddress(string address)
        {
            PageInteractionHelper.WaitForPageToLoad(10);
            FormCompletionHelper.SelectFromDropDownByText(webDriver.FindElement(By.XPath(".//*[@id='PostcodeId']")),address);
            return new AddVenueSelectAddressPage(webDriver);
        }


        public AddVenueSelectAddressPage ClickChange()
        {
            FormCompletionHelper.ClickElement(clickChange);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueConfirmAddressPage ClickContinueConfirm()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(continueButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddVenueConfirmAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage SelectAddressValidationMessage(string validationMsg)
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyText(AddressSelectionPCValidationMessage, validationMsg);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage SelectAddressVenueValidationMessage(string validationMsg)
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyText(AddressSelectionVenueValidationMessage, validationMsg);
            return new AddVenueSelectAddressPage(webDriver);
        }
    }
}