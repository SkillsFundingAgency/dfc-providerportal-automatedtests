using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.VenueManagement
{
    public class AddVenueSelectAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Add a venue";

        public AddVenueSelectAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By venueName = By.Id("name");
        private By addressSelector = By.Id("address-selector");
        private By continueButton = By.Id("continue"); 

		public AddVenueSelectAddressPage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage selectFirstAddress()
        {
            // TODO SELECT FIRST ADDRESS
            return new AddVenueSelectAddressPage(webDriver);
        }

        public AddVenueSelectAddressPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
            return new AddVenueSelectAddressPage(webDriver);
        }


    }
}