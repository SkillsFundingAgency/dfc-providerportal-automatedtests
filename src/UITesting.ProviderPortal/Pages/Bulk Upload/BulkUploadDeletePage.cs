using System;
using System.Threading;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class BulkUploadDeletePage : BasePage
    {
        private static String PAGE_TITLE = "Delete this file";
        private By ContinueBtn = By.Id("next");


        public BulkUploadDeletePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public BulkUploadFileDeletedPage Delete()
        {

            FormCompletionHelper.ClickElement(ContinueBtn);
            return new BulkUploadFileDeletedPage(webDriver);
        }

    }
}