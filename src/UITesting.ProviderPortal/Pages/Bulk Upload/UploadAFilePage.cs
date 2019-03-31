using System;
using System.Threading;
using System.IO;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class UploadAFilePage : BasePage
    {
        private static String PAGE_TITLE = "Upload a file";
        private By ChooseFileBtn = By.Id("bulkUploadFile");
        private By UploadFileBtn = By.Id("uploadButton");
        private By ErrorMsg = By.XPath(".//*[@id='bulkUploadForm']/div[1]/span");
        private By ErrorSummaryMsg = By.XPath(".//*[@id='errorSummary']/div/ul/li/a");

        private string errortxt;

        public UploadAFilePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public UploadAFilePage ChooseFile(string filename)
        {

            string dirName = AppDomain.CurrentDomain.BaseDirectory;
            FileInfo fileInfo = new FileInfo(dirName);
            DirectoryInfo parentDir = fileInfo.Directory.Parent.Parent;
            string uploadFile = parentDir.FullName + "\\Test Data\\" + filename;
            //System.Console.WriteLine(uploadFile);

            IWebElement element = webDriver.FindElement(ChooseFileBtn);
            element.SendKeys(uploadFile);
            Thread.Sleep(1000);

            return new UploadAFilePage(webDriver);
        }

        public BulkUploadFixPublishPage UploadFile()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            return new BulkUploadFixPublishPage(webDriver);
        }


        public BulkUploadPublishPage UploadFileNoErrors()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            return new BulkUploadPublishPage(webDriver);
        }


        public UploadAFilePage UploadFileError()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            return new UploadAFilePage(webDriver);
        }


        public UploadAFilePage ConfirmErrorMsg(string errorMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(ErrorMsg);
            PageInteractionHelper.IsElementDisplayed(ErrorMsg);
            errortxt = webDriver.FindElement(ErrorMsg).GetAttribute("innerText");
            if (errorMsg != errortxt)
            {
                throw new Exception("No Error message displayed or Incorrect error message displayed"
                                    + "\n Expected: " + errorMsg
                                    + "\n Found: " + errortxt);
            }
            return new UploadAFilePage(webDriver);
        }

        public UploadAFilePage ConfirmErrorSummaryMsg(string errorMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(ErrorSummaryMsg);
            PageInteractionHelper.IsElementDisplayed(ErrorSummaryMsg);
            errortxt = webDriver.FindElement(ErrorSummaryMsg).GetAttribute("innerText");
            if (errorMsg != errortxt)
            {
                throw new Exception("No Error Summary message displayed or Incorrect error message displayed"
                                    + "\n Expected: " + errorMsg
                                    + "\n Found: " + errortxt);
            }
            return new UploadAFilePage(webDriver);
        }

    }
}