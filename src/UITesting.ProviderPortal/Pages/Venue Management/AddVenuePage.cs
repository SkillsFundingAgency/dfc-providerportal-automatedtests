using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenuePage : BasePage
    {
        private static String PAGE_TITLE = "Add venue";
        private By venueName = By.Id("name");
        private By venuePostcode = By.Id("PostCode");
        private By FindAddressButton = By.Id("postcode-search");
        private By PostcodeValidationMessage = By.Id("validation-msg");

        public AddVenuePage(IWebDriver webDriver) : base(webDriver)
        {
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
    }
}