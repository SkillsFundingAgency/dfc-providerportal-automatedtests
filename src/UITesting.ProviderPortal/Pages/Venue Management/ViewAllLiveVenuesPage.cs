using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class ViewAllLiveVenuesPage : TestSupport.BasePage 
    {
        private static String PAGE_TITLE = "Your venues";
        private static String PAGE_TITLE_ELEMENT = "//*[@id='main-content']/div/div[1]/div/div/h1";
        private static String VENUE_DATA = "//*[@id='live']/table/tbody/tr[1]/td[2]";  //"//*[@id='live']/div[1]/label"
        private static String ARCH_TAB= "//*[@id='tab_archived']";
        private static String ADD_VENUE_BUTTON = "//*[@id='venueSearchResultForm']/div/div[1]/button";   //*[@id="venueSearchResultForm"]/div/div[1]/button/text()
        private By venueBanner = By.XPath(".//*[@id='qual']");
        private By firstRecord = By.XPath(".//*[@id='live']/table/tbody/tr[1]/td[2]");   //(".//*[@id='live']/div[1]/label"); 
        private By firstVenue = By.XPath(".//*[@id='live']/table/tbody/tr[1]/td[1]");    
        private By prnText = By.Id("SearchTerm");//UKPrn
        private By searchButton = By.Id("venueProvider");//search
        private By firstEditlink = By.XPath(".//*[@id='live']/table/tbody/tr[1]/td[4]/a");   //(".//*[@id='live']/div[1]/label/a[1]"); 
        private By EditLink = By.LinkText("Edit");
        Models.Venue_Management.Venue_Data VenueData = new Models.Venue_Management.Venue_Data();
        
        public ViewAllLiveVenuesPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public void SearchProvider(string UKPRNNO)
        {
            webDriver.FindElement(prnText).SendKeys(UKPRNNO.ToString());
            webDriver.FindElement(searchButton).Click();
            PageInteractionHelper.TurnOnSleep();
            //PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(PAGE_TITLE_ELEMENT)).Text, PAGE_TITLE);
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.ClassName(PAGE_TITLE_ELEMENT)).Text, PAGE_TITLE);
        }
        internal void CheckEditLink()
        {
            //PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, "Edit");     
            PageInteractionHelper.IsElementPresent(EditLink);
        }
        internal void CheckArchiveLink()
        {
            //PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, "Archive");
        }

        internal void ValidateVenue()
        {
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.VenueName);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.AddressLine1);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.TownCity);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.PostCode);
        }

        public void CheckAddVenueButton()
        {
            PageInteractionHelper.VerifyElementPresent(By.XPath(ADD_VENUE_BUTTON));
        }

        public AddVenuePage ClickAddVenueButton()
        {
            FormCompletionHelper.ClickElement(By.XPath(ADD_VENUE_BUTTON));
            return new AddVenuePage(webDriver);
        }

        public EditVenueConfirmAddressPage ClickFirstEdit()
        {
            FormCompletionHelper.ClickElement(firstEditlink);
            return new EditVenueConfirmAddressPage(webDriver);
        }

        internal void ViewArchivedVenues()
        {
            webDriver.FindElement(By.XPath(ARCH_TAB)).Click();
        }

        internal void VenueAddedBanner()
        {
            PageInteractionHelper.IsElementDisplayed(venueBanner);
        }


        internal void VenueAdded(string venueName)
        {
            PageInteractionHelper.IsElementDisplayed(firstRecord);
            FormCompletionHelper.VerifyText(firstRecord, venueName);
        }

        internal void VenueEdited(string venueName)
        {
            PageInteractionHelper.IsElementDisplayed(firstVenue);
            //string venName = webDriver.FindElement(firstVenue).GetAttribute("innerText");
            FormCompletionHelper.VerifyText(firstVenue, venueName);
        }

        internal void DeleteVenue(string venue)
        {
            IWebElement venTable = webDriver.FindElement(By.XPath("//*[@id='live']/table"));
            IList<IWebElement> tableRows = venTable.FindElements(By.TagName("tr")).ToList();

            for (int i = 0; i < tableRows.Count; i++)
            {
                IList<IWebElement> tdCollection = tableRows[i].FindElements(By.TagName("td"));
                var count = 0;

                for (int c = 0; c < tdCollection.Count; c++)
                {
                    string column = tdCollection[c].Text;
                    
                    if (column == venue)
                    {
                        tableRows[i].FindElement(By.PartialLinkText("Delet")).Click();
                        System.Threading.Thread.Sleep(1000);
                        tableRows[i].FindElement(By.XPath(".//*[starts-with(@id,'venue-delete')]")).Click();  

                        try
                        {
                            tableRows[i].FindElement(By.XPath(".//*[starts-with(@id,'venue-delete')]")).Click();
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



    /* protected override bool SelfVerify()
     {
        //return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
         //
        // return PageInteractionHelper.VerifyPageTitle(By.XPath("//*[@id='main - content']/div/div[1]/div/div/h1")),PAGE_TITLE)
     }*/
}
}
