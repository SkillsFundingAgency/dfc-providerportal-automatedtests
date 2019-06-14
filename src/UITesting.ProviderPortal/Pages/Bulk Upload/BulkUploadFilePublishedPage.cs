using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class BulkUploadFilePublishedPage : BasePage
    {
        private static String PAGE_TITLE = "Publish complete";
        private By PublishBtn = By.Id("publish");


        public BulkUploadFilePublishedPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

    }
}