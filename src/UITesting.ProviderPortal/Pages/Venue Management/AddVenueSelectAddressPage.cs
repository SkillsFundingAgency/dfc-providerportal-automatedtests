using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenueSelectAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Add a venue";
        private By venueName = By.Id("name");
        private By addressSelector = By.Id("address-selector");
        private By clickChange = By.LinkText("Change");
        private By continueButton = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/div/div[3]/button");
        private By AddressSelectionValidationMessage = By.Id("validation-msg");
        private By AddressSelectionVenueValidationMessage = By.Id("venue-validation-msg");
        private readonly By addressList = By.CssSelector("#address-list");

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
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage selectAddress(string address)
        {
            IList<IWebElement> all = webDriver.FindElements(addressList);
            FormCompletionHelper.SelectFromDropDownList(all, address, addressList);
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

        public AddVenueSelectAddressPage SelectAddressValidationMessage(string validationMsg)
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyText(AddressSelectionValidationMessage, validationMsg);
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