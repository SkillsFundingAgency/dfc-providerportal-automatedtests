using System;
using System.Threading;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class BulkUploadPublishPage : BasePage
    {
        private static String PAGE_TITLE = "Publish your file";
        private By PublishBtn = By.Id("next");


        public BulkUploadPublishPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            webDriver.FindElementWait(PublishBtn, 60);
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public BulkUploadFilePublishedPage Publish()
        {

            FormCompletionHelper.ClickElement(PublishBtn);
            return new BulkUploadFilePublishedPage(webDriver);
        }

    }
}