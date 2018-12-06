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
        private static String PAGE_TITLE = "Your Venues";
        private static String PAGE_TITLE_ELEMENT = "//*[@id='main-content']/div/div[1]/div/div/h1";
        private static String VENUE_DATA = "//*[@id='live']/div[1]/label";
        private static String ARCH_TAB= "//*[@id='tab_archived']";
        private static String ADD_VENUE_BUTTON = "//*[@id='venueSearchResultForm']/div/div/div/div[2]/button";
        Models.Venue_Management.Venue_Data VenueData = new Models.Venue_Management.Venue_Data();
        
        public ViewAllLiveVenuesPage(IWebDriver webDriver) : base(webDriver)
        {
            
        }
        internal void SearchProvider(string UKPRNNO)
        {
            webDriver.FindElement(By.Id("UKPrn")).SendKeys(UKPRNNO.ToString());
            webDriver.FindElement(By.Id("search")).Click();
            PageInteractionHelper.VerifyPageTitle(webDriver.FindElement(By.XPath(PAGE_TITLE_ELEMENT)).Text, PAGE_TITLE);
        }
        internal void CheckEditLink()
        {
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, "Edit");            
        }
        internal void CheckArchiveLink()
        {
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, "Archive");
        }

        internal void ValidateVenue()
        {
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.VenueName);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.AddressLine1);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.City);
            PageInteractionHelper.VerifyText(webDriver.FindElement(By.XPath(VENUE_DATA)).Text, VenueData.PostCode);
        }

        internal void CheckAddVenueButton()
        {
            PageInteractionHelper.VerifyElementPresent(By.XPath(ADD_VENUE_BUTTON));
        }

        internal void ViewArchivedVenues()
        {
            webDriver.FindElement(By.XPath(ARCH_TAB)).Click();
        }
        /* protected override bool SelfVerify()
         {
            //return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
             //
            // return PageInteractionHelper.VerifyPageTitle(By.XPath("//*[@id='main - content']/div/div[1]/div/div/h1")),PAGE_TITLE)
         }*/
    }
}
