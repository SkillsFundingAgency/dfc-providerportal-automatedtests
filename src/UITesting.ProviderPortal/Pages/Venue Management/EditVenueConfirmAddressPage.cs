using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Venue_Management
{
    public class EditVenueConfirmAddressPage : BasePage
    {
        private static String PAGE_TITLE = "Edit venue details";

        public EditVenueConfirmAddressPage(IWebDriver webDriver) : base(webDriver)
        {
            //SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        private By changeNameLink = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/table/tbody/tr[1]/td[2]/button");  
        private By changeAddressLink = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/table/tbody/tr[2]/td[2]/button");
        private By continueButton = By.XPath(".//*[@id='postCodeSearchResultForm']/div/div/div/button"); 


        public AddVenueEditNamePage ChangeName()
        {
            FormCompletionHelper.ClickElement(changeNameLink);
            return new AddVenueEditNamePage(webDriver);
        }

        public ViewAllLiveVenuesPage ClickContinue()
        {
            FormCompletionHelper.ClickElement(continueButton);
            return new ViewAllLiveVenuesPage(webDriver);
        }


        public AddVenueEditAddressPage ChangeAddress()
        {
            FormCompletionHelper.ClickElement(changeAddressLink);
            return new AddVenueEditAddressPage(webDriver);
        }
    }
}