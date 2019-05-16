using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class CopyCoursePage : BasePage 
    {
        private static String PAGE_TITLE = "Copy course";
        private static By SaveButton = By.Id("save");
        private static By AddNewVenueLink = By.Id("addNewVenue");
        private static By Venue = By.Id("VenueId");

        public CopyCoursePage(IWebDriver  webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void ClickAddNewVenueLink()
        {
            FormCompletionHelper.ClickElement(AddNewVenueLink);
        }

        internal void SelectVenueByName(string strVenueName)
        {
            FormCompletionHelper.SelectFromDropDownByText(webDriver.FindElement(Venue), strVenueName);
        }

        internal void ClickSave()
        {
            FormCompletionHelper.ClickElement(SaveButton);
        }
    }
}
