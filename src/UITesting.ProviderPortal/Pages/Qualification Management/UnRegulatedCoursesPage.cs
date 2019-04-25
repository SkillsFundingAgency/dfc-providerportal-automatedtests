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

namespace UITesting.ProviderPortal.Pages.Qualification_Management
{
    public class UnRegulatedCoursesPage : TestSupport.BasePage
    {

        private static String PAGE_TITLE = "Search for a course provision";
        private By UnRegBackLink = By.XPath("//*[@id='main-content']/div/div/header/div/a");
        private By ZCodeText = By.Id("Search");
        private By SearchButton = By.Id("searchZCode");
        private By DontKnowZCode = By.XPath("//a[@href='/UnregulatedCourses/UnknownZCode']");

        private By ChooseButton = By.XPath("//*[@id='results']/div[2]/a[1]");
        private By CancelLink = By.LinkText("Cancel");

        public UnRegulatedCoursesPage(IWebDriver  webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void ClickUnRegBackLink()
        {
            FormCompletionHelper.ClickElement(UnRegBackLink);
        }

        internal void EnterZCode(string strZCode)
        {
            FormCompletionHelper.EnterText(ZCodeText, strZCode);
        }

        internal void clickSearch()
        {
            FormCompletionHelper.ClickElement(SearchButton);
        }

        internal void clickDontKnowZCode()
        {
            FormCompletionHelper.ClickElement(DontKnowZCode);
        }

        internal void ValidateBackLink()
        {
            PageInteractionHelper.IsElementPresent(UnRegBackLink);
        }

        internal void ValidateZSearchCodeText()
        {
            PageInteractionHelper.IsElementPresent(ZCodeText);
        }

        internal void ValidateUnknownZCodeLink()
        {
            PageInteractionHelper.IsElementPresent(DontKnowZCode);
        }

        internal void validateZCodeTextBlank()
        {
            FormCompletionHelper.VerifyText(ZCodeText, "");
        }

        internal void clickCancelLink()
        {
            FormCompletionHelper.ClickElement(CancelLink);
        }
        internal void ValidateChooseButton()
        {
            FormCompletionHelper.IsElementPresent(ChooseButton);
        }

        internal void ValidateCancelLink()
        {
            FormCompletionHelper.IsElementPresent(CancelLink);
        }
    }
}
