using OpenQA.Selenium;
using System;
using System.IO;
using System.Threading;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.Pages.Bulk_Upload
{
    public class UploadAFilePage : BasePage
    {
        private static String PAGE_TITLE = "Bulk upload course information";
        private By ChooseFileBtn = By.Id("bulkUploadFile");
        private By UploadFileBtn = By.Id("uploadButton");
        private By ErrorMsg = By.XPath(".//*[@id='groupServerSideError']/span");  
        private By ErrorSummaryMsg = By.Id("name-error"); 

        private string errortxt;

        public UploadAFilePage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
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
            DirectoryInfo parentDir = fileInfo.Directory;
            string uploadFile = parentDir.FullName + "\\Test Data\\" + filename;

            IWebElement element = webDriver.FindElement(ChooseFileBtn);
            element.SendKeys(uploadFile);
            Thread.Sleep(1000);

            return new UploadAFilePage(webDriver);
        }

        public BulkUploadFixPublishPage UploadFile()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new BulkUploadFixPublishPage(webDriver);
        }


        public BulkUploadPublishPage UploadFileNoErrors()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new BulkUploadPublishPage(webDriver);
        }


        public UploadAFilePage UploadFileError()
        {
            FormCompletionHelper.ClickElement(UploadFileBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new UploadAFilePage(webDriver);
        }


        public UploadAFilePage ConfirmErrorMsg(string errorMsg)
        {
            PageInteractionHelper.WaitForElementToBePresent(ErrorMsg);
            PageInteractionHelper.IsElementDisplayed(ErrorMsg);
            errortxt = webDriver.FindElement(ErrorMsg).GetAttribute("innerText");
            if (!errortxt.Contains(errorMsg))
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

            string[] strArr = null;
            char[] splitchar = { '\n' };
            strArr = errortxt.Replace("\r\n", "\n").Split(splitchar);

            if (!strArr[1].Contains(errorMsg))
            {
                throw new Exception("No Error Summary message displayed or Incorrect error message displayed"
                                    + "\n Expected: " + errorMsg
                                    + "\n Found: " + errortxt);
            }
            return new UploadAFilePage(webDriver);
        }

    }
}