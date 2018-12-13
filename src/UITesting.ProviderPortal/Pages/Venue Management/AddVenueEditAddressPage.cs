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
    public class AddVenueEditAddressPage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Edit Venue Address";
        private By submitButton = By.XPath("//*[@id=\"postCodeSearchResultForm\"]/div/div/table/tbody/tr[2]/td[2]/button");
        private By venueName = By.Id("name");
        private By UKPRN = By.Id("UKPrn");
        private By venuePostcode = By.Id("Postcode");
        private By FindAddressButton = By.XPath("//*[@id=\"findAddress\"]");
       // private By postcodeBox = By.Id("#Postcode-error");
        private By ClickEnterAddressManually = By.XPath("//a[@href='/Venues/AddVenueManualAddress']");

        public AddVenueEditAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }


        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
            
        }

        public AddVenueEditAddressPage EditingEnterPostCode(String postcode)
        {
            FormCompletionHelper.EnterText(venuePostcode, postcode);
            return new AddVenueEditAddressPage(webDriver);
        }

        public AddVenueEditAddressPage ClickFindAddress()
        {
            FormCompletionHelper.ClickElement(FindAddressButton);
            return new AddVenueEditAddressPage(webDriver);
        }



        public AddVenueEditAddressPage ClickSubmit()
        {
            FormCompletionHelper.ClickElement(submitButton);
            return new AddVenueEditAddressPage(webDriver);
        }

        public AddVenueEditAddressPage SelectAddressFromList()
        {
            FormCompletionHelper.ClickElement(venuePostcode);
            //FormCompletionHelper.ClickElement(
            return new AddVenueEditAddressPage(webDriver);
        }


    }
}