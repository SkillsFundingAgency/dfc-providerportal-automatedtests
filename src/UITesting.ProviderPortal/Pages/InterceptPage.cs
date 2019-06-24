using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.Pages.Data_Quality_Indicators


{
    public class InterceptPage : BasePage
    {
        private static String PAGE_TITLE = "Data transfer";
        private By continueLink = By.LinkText("Continue to course directory");

        public InterceptPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public DQIDashbordPage NavigateToDQI()
        {
            FormCompletionHelper.ClickElement(continueLink);
            return new DQIDashbordPage(webDriver);
        }

    }
}