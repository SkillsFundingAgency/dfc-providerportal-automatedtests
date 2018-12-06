using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.VenueManagement.Pages
{
    public class AddVenueConfirmAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Add a venue";

        public AddVenueConfirmAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By changeNameLink = By.XPath(".//*[@id='content']/div[2]/div/table/tbody/tr[1]/td[2]/a");
        private By changeAddressLink = By.XPath(".//*[@id='content']/div[2]/div/table/tbody/tr[2]/td[2]/a");
        private By continueButton = By.Id("continue"); 


        public AddVenueConfirmAddressPage ChangeName()
        {
            FormCompletionHelper.ClickElement(changeNameLink);
            return new AddVenueConfirmAddressPage(webDriver);
        }

        public AddVenueConfirmAddressPage ChangeAddress()
        {
            FormCompletionHelper.ClickElement(changeAddressLink);
            return new AddVenueConfirmAddressPage(webDriver);
        }


        public AddVenueConfirmAddressPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
            return new AddVenueConfirmAddressPage(webDriver);
        }


    }
}