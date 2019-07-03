using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenueManualAddressPage :TestSupport.BasePage
    {
        private By venueNameText = By.Id("VenueName");
        private By addressLine1Text = By.Id("AddressLine1");
        private By addressLine2Text = By.Id("AddressLine2");
        private By towncityText = By.Id("TownOrCity");
        private By CountyText = By.Id("County");
        private By postcodeText = By.Id("Postcode");
        private By VenueNameValidationMsg = By.XPath(".//*[@id='ManualAddVenueForm']/div[1]/span");               //("//*[@id='VenueName-error']");
        private By AddressLineValidationMsg = By.XPath(".//*[@id='ManualAddVenueForm']/div[2]/span");             //("//*[@id='AddressLine1-error']");
        private By TownOrCityValidationMsg = By.XPath(".//*[@id='ManualAddVenueForm']/div[4]/span");              //("//*[@id='TownOrCity-error']");
        private By PostcodeValidationMsg = By.XPath(".//*[@id='ManualAddVenueForm']/div[6]/span");                //("//*[@id='Postcode-error']");
        private By ClickContinueButton = By.Id("ManualAddressContinue");                                          //("//*[@id='main-content']/form/div[7]/button");
        private static String PAGE_TITLE = "Add venue";


        public AddVenueManualAddressPage(IWebDriver webDriver):base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal void AddVenueName(string VenueName)
        {
            FormCompletionHelper.EnterText(venueNameText, VenueName);
            
        }
       internal void AddAddressLine1(string AddressLine1)
        {
            FormCompletionHelper.EnterText(addressLine1Text, AddressLine1);
            
        }
       internal void AddTownCity(string TownCity)
        {
            FormCompletionHelper.EnterText(towncityText, TownCity);            
        }
        internal void AddPostCode(string Postcode)
        {
            FormCompletionHelper.EnterText(postcodeText,Postcode);
        }
        internal void AddCounty(string County)
        {
            FormCompletionHelper.EnterText(CountyText, County);
        }
        internal void AddAddressLine2(string AddressLine2)
        {
            FormCompletionHelper.EnterText(addressLine2Text,AddressLine2);
        }

        internal void ValidateFields()
        {
            PageInteractionHelper.VerifyElementPresent(venueNameText);
            PageInteractionHelper.VerifyElementPresent(addressLine1Text);
            PageInteractionHelper.VerifyElementPresent(addressLine2Text);
            PageInteractionHelper.VerifyElementPresent(towncityText);
            PageInteractionHelper.VerifyElementPresent(CountyText);
            PageInteractionHelper.VerifyElementPresent(postcodeText);            
        }

        internal void VenueNameValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(VenueNameValidationMsg, validationMsg);
        }

        internal void AddressLineValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(AddressLineValidationMsg,validationMsg);
        }
        internal void TownOrCityValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(TownOrCityValidationMsg, validationMsg);
        }
        internal void PostcodeValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(PostcodeValidationMsg, validationMsg);
        }

       /* internal void PostCodeFormatValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText 
        }*/
        internal void ClickContinue()
        {
            FormCompletionHelper.ClickElement(ClickContinueButton);
        }
    }
}
