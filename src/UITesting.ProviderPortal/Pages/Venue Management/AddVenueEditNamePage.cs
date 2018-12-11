using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenueEditNamePage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Edit Venue Name";
        private By venueName = By.Id("VenueName");
        private By submitButton = By.Id("submit");


        public AddVenueEditNamePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }


        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
            //return true;
        }

        public AddVenueEditNamePage ClearVenueName()
        {
            Console.WriteLine("debug2");
            //FormCompletionHelper.ClearContents(venueName);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenueEditNamePage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenueEditNamePage ClickSubmit()
        {
            FormCompletionHelper.ClickElement(submitButton);
            return new AddVenueEditNamePage(webDriver);
        }


    }
}