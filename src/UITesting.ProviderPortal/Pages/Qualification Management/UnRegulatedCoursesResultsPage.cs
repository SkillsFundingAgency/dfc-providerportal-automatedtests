using OpenQA.Selenium;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using System.Web;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.Pages.Qualification_Management
{
    public class UnRegulatedCoursesResultsPage : BasePage 
    {
        private static String PAGE_TITLE = "";
        private By ChooseButton = By.XPath("//*[@id='main-content']/div[2]/a[1]");
        private By CancelLink = By.LinkText("Cancel");
        private By SearchErrMessage = By.Id("Search-error");
        private By ZCodeNotExistErrMessage = By.Id("cd-error-summary-title");
        public UnRegulatedCoursesResultsPage(IWebDriver webDriver): base(webDriver)
        {
           // SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal void ClickBackLink()
        {
            throw new NotImplementedException();
        }

        internal void ValidateChooseButton()
        {
            FormCompletionHelper.IsElementPresent(ChooseButton);
        }

        internal void ValidateCancelLink()
        {
            FormCompletionHelper.IsElementPresent(CancelLink);
        }

        internal void ValidateErrorMessage(string errMsg)
        {
            PageInteractionHelper.VerifyText(SearchErrMessage, errMsg);
        }

        internal void ValidateDoesNotexistErrorMessage(string errMsg)
        {
            PageInteractionHelper.VerifyText(ZCodeNotExistErrMessage, errMsg);
        }

        internal void ClickChooseButton()
        {
            FormCompletionHelper.ClickElement(ChooseButton);
        }

        internal void clickCancelLink()
        {
            FormCompletionHelper.ClickElement(CancelLink);
        }
    }
}
