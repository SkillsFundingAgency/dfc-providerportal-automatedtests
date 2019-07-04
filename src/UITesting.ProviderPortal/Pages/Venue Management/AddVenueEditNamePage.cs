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
        private static String PAGE_TITLE = "Edit venue name";
        private By venueName = By.Id("VenueName");
        private By submitButton = By.Id("editVenueNameSubmit");
        
        public AddVenueEditNamePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }


        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
            
        }

        public AddVenueEditNamePage ClearVenueName()
        {
            //FormCompletionHelper.ClearContents(venueName);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenueEditNamePage EnterVenueName(String name)
        {
            name = name + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenueConfirmAddressPage ClickSubmit()
        {
            FormCompletionHelper.ClickElement(submitButton);

            return new AddVenueConfirmAddressPage(webDriver);
            //return new AddVenuePage(webDriver);
        }

        public EditVenueConfirmAddressPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(submitButton);
            return new EditVenueConfirmAddressPage(webDriver);
        }

    }
}