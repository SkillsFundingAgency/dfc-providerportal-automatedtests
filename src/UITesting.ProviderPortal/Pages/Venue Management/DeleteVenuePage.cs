using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class DeleteVenuePage : BasePage
    {
        private static String PAGE_TITLE = "Your Venues";
        private By DeleteLink = By.LinkText("Delete");
        private By DeleteId = By.CssSelector("a[class='govuk-link delete']");
        private By CancelLink = By.LinkText("Cancel");
        private By EditLink = By.LinkText("Edit");
        private By ConfirmDelete = By.LinkText("Confirm delete");
        private By CourseMessage = By.XPath("//*[@id='LiveCoursesExistMessage']/div/div/p");
        private By DeleteMessage = By.XPath("//*[@id='venueSearchResultForm']/div[1]/div/p");
        //private By VenueTable = By.XPath("//*[@id='live']/table/thead/tr/th[1]");
        private By VenueNameColumn = By.ClassName("govuk-table__cell");

        public DeleteVenuePage(IWebDriver webDriver ): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal Boolean  CheckVenuePresent(string strVenueName)
        {
            if (PageInteractionHelper.VerifyTableData(VenueNameColumn, strVenueName)== true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal void ClickDeleteLink(string strVenueName)
        {
            
            FormCompletionHelper.ClickElement(By.Id(FormCompletionHelper.GetID(DeleteId, strVenueName, VenueNameColumn)));
        }
        internal void ClickCancelLink()
        {
            FormCompletionHelper.ClickElement(CancelLink);
        }
        internal void ClickConfirmDelete()
        {
            FormCompletionHelper.ClickElement(ConfirmDelete);
        }

        internal void ValidateEditandDeleteLink()
        {
            FormCompletionHelper.IsElementPresent(DeleteLink);
            FormCompletionHelper.IsElementPresent(EditLink);
        }

        internal void ValidateConfirmDeleteandCancelLink()
        {
            FormCompletionHelper.IsElementPresent(ConfirmDelete);
            FormCompletionHelper.IsElementPresent(CancelLink);
        }

        internal void CheckVenueNotPresent(object strVenueName)
        {
            throw new NotImplementedException();
        }

        internal void ValidateMessage(string strMsg)
        {
            FormCompletionHelper.VerifyText(CourseMessage,strMsg);
        }

        internal void ValidateDeleteMessage(string strMsg)
        {
            FormCompletionHelper.VerifyText(DeleteMessage, strMsg);
        }
    }
}
