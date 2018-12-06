using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.VenueManagement
{
    public class AddVenuePage : BasePage
    {
        private static String PAGE_TITLE = "Add venue";

        public AddVenuePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By venueName = By.Id("name");
        private By venuePostcode = By.Id("address-postcode");
        private By FindAddressButton = By.Id("find-address"); 

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


    }
}