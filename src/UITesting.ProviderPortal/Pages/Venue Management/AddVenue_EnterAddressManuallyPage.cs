using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenue_EnterAddressManuallyPage: TestSupport.BasePage 
    {
        private By venueNameText= By.Id("VenueName");
        private By clickContinueButton = By.XPath("//*[@id='manualAddVenueForm']/div/div/div/div[2]/button");
        
        public AddVenue_EnterAddressManuallyPage(IWebDriver webDriver) : base(webDriver)
        {
            //SelfVerify();
        }



        protected override bool SelfVerify()
        {
            throw new NotImplementedException();
        }

        internal void  ClickEnterAddressManually()
        {
            Pages.Venue_Management.AddVenueManualAddressPage  AddManualAddressVenuePage = new Pages.Venue_Management.AddVenueManualAddressPage(webDriver);
            
        }
       
        internal void ClickContinue()
        {
            webDriver.FindElement(clickContinueButton).Click();
        }
    }
}
