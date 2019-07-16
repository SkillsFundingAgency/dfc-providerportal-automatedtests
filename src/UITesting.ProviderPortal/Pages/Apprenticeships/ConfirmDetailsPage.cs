using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Apprenticeships
{
    public class ConfirmDetailsPage : BasePage
    {
        private static String PAGE_TITLE = "Check and publish to the course directory";
        private By publishBtn = By.Id("next");


        public ConfirmDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
           SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public AppPublishedPage ClickPublish()
        {
            FormCompletionHelper.ClickElement(publishBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AppPublishedPage(webDriver);
        }

    }
}