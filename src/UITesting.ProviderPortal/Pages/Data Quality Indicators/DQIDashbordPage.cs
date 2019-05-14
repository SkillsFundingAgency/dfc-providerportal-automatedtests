using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Provider_Management;

namespace UITesting.ProviderPortal.Pages.Data_Quality_Indicators


{
    public class DQIDashbordPage : BasePage
    {
        private static String PAGE_TITLE = "Course management dashboard";
        private By DQIUpdateStartDateLink = By.PartialLinkText("courses need their start date updating");
        private By providerDetails = By.XPath("/html/body/div[1]/div/a");

        public DQIDashbordPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public DQIFixPublishPage NavigateToDQI()
        {
            FormCompletionHelper.ClickElement(DQIUpdateStartDateLink);
            return new DQIFixPublishPage(webDriver);
        }

        public ProviderDetailsPage NavigateToProviderDetails()
        {
            FormCompletionHelper.ClickElement(providerDetails);
            return new ProviderDetailsPage(webDriver);
        }
    }
}