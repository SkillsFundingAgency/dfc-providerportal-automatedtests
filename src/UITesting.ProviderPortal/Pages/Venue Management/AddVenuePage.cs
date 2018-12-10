using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenuePage : BasePage
    {
        private static String PAGE_TITLE = "Add venue";
        private By venueName = By.Id("name");
        
        private By venuePostcode = By.Id("Postcode");
        private By addressLine1Text = By.Id("AddressLine1");
        private By towncityText = By.Id("TownCity");
        private By FindAddressButton = By.Id("PostcodeLookupFindAddress");
        private By PostcodeValidationMessage = By.Id("validation-msg");
        private By ManualAddressEntryLink = By.XPath("//*[@id='postCodeSearchResultForm']/div/div/div/div[4]/a");

        public AddVenuePage(IWebDriver webDriver) : base(webDriver)
        {
            //SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public AddVenuePage EnterVenueName(String name)
        {
            FormCompletionHelper.EnterText(venueName, name);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage EnterAddressLine1(string AddLine1)
        {
            FormCompletionHelper.EnterText(addressLine1Text, AddLine1);
            return new AddVenuePage(webDriver);
        }
        public AddVenuePage EnterTownCity(string TownCity)
        {
            FormCompletionHelper.EnterText(towncityText, TownCity);
            return new AddVenuePage(webDriver);
        }
        public AddVenuePage EnterPostCode(String postcode)
        {
            FormCompletionHelper.EnterText(venuePostcode, postcode);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage ClickFindAddress()
        {
            FormCompletionHelper.ClickElement(FindAddressButton);
            return new AddVenuePage(webDriver);
        }
        

        public AddVenuePage AddressValidationMessage(string validationMsg)
        {
            PageInteractionHelper.WaitForPageToLoad();
            PageInteractionHelper.VerifyText(PostcodeValidationMessage, validationMsg);
            return new AddVenuePage(webDriver);
        }

        public AddVenuePage ClickEnterAddressManually()
        {
            FormCompletionHelper.ClickElement(ManualAddressEntryLink);
            return new AddVenuePage(webDriver);
        }
    }
}