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
        private static String PAGE_TITLE = "Your venues";
        private By DeleteLink = By.PartialLinkText("Delet");
        private By CancelLink = By.PartialLinkText("Cance");
        private By EditLink = By.LinkText("Edit");
        private By ConfirmDelete = By.XPath(".//*[starts-with(@id,'venue-delete')]");
        private By CourseMessage = By.XPath("//*[@id='LiveCoursesExistMessage']/div/div/span[1]");
       
        private By DeleteMessage = By.XPath("//*[@id='venueSearchResultForm']/div[1]/div/span[1]");
        private By VenueTable = By.XPath("//*[@id='live']/table");
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
            IWebElement venTable = webDriver.FindElement(VenueTable);
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
            {
                IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                //var count = 0;
                for (int c = 0; c < tdCollection.Count; c++)
                {
                    string column = tdCollection[c].Text;
                    if (column == strVenueName)
                    {
                        return true;
                    }
                }
            }
            return false;
            //throw new Exception("Venue does not exists:" + strVenueName);
        }
        internal void ClickDeleteLink(string strVenueName)
        {
            IWebElement venTable = webDriver.FindElement(VenueTable);
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
                {
                    IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                //var count = 0;
                    for (int c = 0; c < tdCollection.Count; c++)
                    {
                        string column = tdCollection[c].Text;
                        if (column == strVenueName)
                        {
                            tableRows[i].FindElement(By.PartialLinkText("Delet")).Click();
                            //System.Threading.Thread.Sleep(1000);
                        }
                    }
                }
        }
        internal void ClickCancelLink(string strVenueName)
        {
            IWebElement venTable = webDriver.FindElement(VenueTable);
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
            {
                IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                //var count = 0;
                for (int c = 0; c < tdCollection.Count; c++)
                {
                    string column = tdCollection[c].Text;
                    if (column == strVenueName)
                    {
                        //tableRows[i].FindElement(DeleteLink).Click();
                        tableRows[i].FindElement(CancelLink).Click();
                        //System.Threading.Thread.Sleep(1000);
                    }
                }
            }
        }
        internal void DeleteVenue(string strVenueName)
        {

            IWebElement venTable = webDriver.FindElement(VenueTable);
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();

            for (int i = 0; i < tableRows.Count; i++)
            {
                IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                var count = 0;

                for (int c = 0; c < tdCollection.Count; c++)
                {
                    string column = tdCollection[c].Text;

                    if (column == strVenueName)
                    {
                       // tableRows[i].FindElement(DeleteLink).Click();
                        System.Threading.Thread.Sleep(1000);
                        tableRows[i].FindElement(ConfirmDelete).Click();

                        try
                        {
                            tableRows[i].FindElement(ConfirmDelete).Click();
                            PageInteractionHelper.WaitForPageToLoad();
                            count = 1;
                            break;
                        }
                        catch (StaleElementReferenceException)
                        {
                            count = 1;
                            webDriver.Navigate().Refresh();
                            break;
                        }
                        finally
                        {
                            Console.WriteLine("COLUMN TEXT = " + column);
                        }
                    }
                }
                if (count == 1)
                {
                    break;
                }
            }
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

        internal Boolean CheckVenueNotPresent(string strVenueName)
        {
            IWebElement venTable = webDriver.FindElement(VenueTable);
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();
            for (int i = 0; i < tableRows.Count; i++)
            {
                IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                //var count = 0;
                for (int c = 0; c < tdCollection.Count; c++)
                {
                    string column = tdCollection[c].Text;
                    if (column != strVenueName)
                    {
                        return true;
                    }
                }
            }
            return false;
            throw new Exception("Venue still exists:" + strVenueName);
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
