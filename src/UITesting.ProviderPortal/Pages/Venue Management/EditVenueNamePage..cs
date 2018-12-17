using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class EditVenueNamePage : BasePage
    {
        private static String PAGE_TITLE = "Edit Venue Name";
        private By venueName = By.Id("VenueName");
        private By continueButton = By.ClassName("govuk-button");


        public EditVenueNamePage(IWebDriver webDriver) : base(webDriver)
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

        public AddVenuePage ClearName()
        {
            FormCompletionHelper.ClickElement(venueName);
            
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage ClickContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
            return new AddVenuePage(webDriver);
        }


    }
}