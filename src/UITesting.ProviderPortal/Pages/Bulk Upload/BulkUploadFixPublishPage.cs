using System;
using System.Threading;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class BulkUploadFixPublishPage : BasePage
    {
        private static String PAGE_TITLE = "Fix errors and publish";
        private By PublishBtn = By.Id("publish");


        public BulkUploadFixPublishPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public BulkUploadFixPublishPage Publish()
        {

            FormCompletionHelper.ClickElement(PublishBtn);
            return new BulkUploadFixPublishPage(webDriver);
        }

    }
}