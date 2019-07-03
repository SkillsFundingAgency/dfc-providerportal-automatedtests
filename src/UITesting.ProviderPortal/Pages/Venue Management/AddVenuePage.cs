using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenuePage : BasePage
    {
        private static String PAGE_TITLE = "Add venue";
        private By venueName = By.Id("VenueName");
        private By UKPRN = By.Id("UKPrn");
        private By venuePostcode = By.Id("Postcode");
        private By FindAddressButton = By.Id("findAddress");
        //private By PostcodeValidationMessage = By.CssSelector("#Postcode-error");
        private By PostcodeValidationMessage = By.XPath(".//*[@id='AddVenue']/div[2]/div/div[1]/span");
        private By ClickEnterAddressManually = By.LinkText("Enter address manually");


        public AddVenuePage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public AddVenuePage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage EnterPostCode(String postcode)
        {
            FormCompletionHelper.EnterText(venuePostcode, postcode);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage ClickFindAddress()
        {
            FormCompletionHelper.ClickElement(FindAddressButton);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage AddressValidationMessage(string validationMsg)
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyText(PostcodeValidationMessage, validationMsg);
            return new AddVenuePage(webDriver);
        }
        internal void ClickEnterAddressManuallyLink()
        {
            FormCompletionHelper.ClickElement(ClickEnterAddressManually);
        }

    }
}