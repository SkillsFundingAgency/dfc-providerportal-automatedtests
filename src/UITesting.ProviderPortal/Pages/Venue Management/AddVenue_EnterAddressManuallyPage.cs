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
            Pages.Venue_Management.AddVenuePage AddVenuePage = new Pages.Venue_Management.AddVenuePage(webDriver);
            
        }
       /* public AddVenue_EnterAddressManuallyPage AddVenueName(string VenueName)
        {
            FormCompletionHelper.EnterText(venueNameText, VenueName);
            return new AddVenue_EnterAddressManuallyPage(webDriver);
        }
        public AddVenue_EnterAddressManuallyPage AddAddressLine1(string AddressLine1)
        {
            FormCompletionHelper.EnterText(addressLine1Text, AddressLine1);
            return new AddVenue_EnterAddressManuallyPage(webDriver);
        }
        public AddVenue_EnterAddressManuallyPage AddTownCity(string TownCity)
        {
            FormCompletionHelper.EnterText(towncityText, TownCity);
            return new AddVenue_EnterAddressManuallyPage(webDriver);
        }*/
        internal void ClickContinue()
        {
            webDriver.FindElement(clickContinueButton).Click();
        }
    }
}
