using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class AddVenueConfirmAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Add a venue";

        public AddVenueConfirmAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By changeNameLink = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/table/tbody/tr[1]/td[2]/button");  
        private By changeAddressLink = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/table/tbody/tr[2]/td[2]/button");
        private By continueButton = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/div/button");
        
        internal void ClickConfirmContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
        }

        public AddVenueEditNamePage ChangeName()
        {
            FormCompletionHelper.ClickElement(changeNameLink);
            return new AddVenueEditNamePage(webDriver);
        }

        public AddVenueConfirmAddressPage ChangeAddress()
        {
            FormCompletionHelper.ClickElement(changeAddressLink);
            return new AddVenueConfirmAddressPage(webDriver);
        }


        public ViewAllLiveVenuesPage ClickContinue()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(continueButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new ViewAllLiveVenuesPage(webDriver);
        }


        public AddVenueEditAddressPage EditAddress()
        {
            FormCompletionHelper.ClickElement(changeAddressLink);
            return new AddVenueEditAddressPage(webDriver);
        }
    }
}