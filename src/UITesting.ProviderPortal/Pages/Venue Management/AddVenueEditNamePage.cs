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
        private By submitButton = By.XPath("//*[@id=\"edit-venue\"]/div/div/div[2]/button");
        
        public AddVenueEditNamePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }


        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
            
        }

        public AddVenueEditNamePage ClearVenueName()
        {
            //FormCompletionHelper.ClearContents(venueName);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenueEditNamePage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenueEditNamePage(webDriver);
        }


        public AddVenuePage ClickSubmit()
        {
            FormCompletionHelper.ClickElement(submitButton);
            return new AddVenuePage(webDriver);
        }


    }
}