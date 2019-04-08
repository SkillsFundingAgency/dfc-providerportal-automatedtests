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
    public class UnKnownZCodePage : BasePage 
    {
        private static String PAGE_TITLE = "Choose a non-regulated provision";
        private By BackLink = By.XPath("//a[@href='/UnregulatedCourses']");
        private By FirstLevelSelect = By.Id("LevelOneSelect");
        private By SecondLevelSelect = By.Id("LevelTwoSelect");
        private By AddThisProvisionLink = By.LinkText("Add this provison");
        private By LevelSelect = By.Id("LevelsSelect");
        private By CategoriesSelect = By.Id("CategoriesSelect");

        private By PageNumber = By.LinkText("2");

        
        public UnKnownZCodePage(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void ClickBackLink()
        {
            FormCompletionHelper.ClickElement(BackLink);
        }

        internal void ClickFirstLevel()
        {
            FormCompletionHelper.ClickElement(FirstLevelSelect);
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(FirstLevelSelect), 1);
            
        }

        internal void ClickSecondLevel()
        {
            FormCompletionHelper.ClickElement(SecondLevelSelect);
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(SecondLevelSelect), 1);
        }

        internal void ClickAddThisProvision()
        {
            FormCompletionHelper.ClickElement(AddThisProvisionLink);
        }

        internal void SelectPage(string pgNum)
        {
            FormCompletionHelper.ClickElement(PageNumber);
        }

        internal void CheckFirstLevelDropDown()
        {
            PageInteractionHelper.IsElementPresent(FirstLevelSelect);
        }
        internal void CheckSecondLevelDropDown()
        {
            FormCompletionHelper.ClickElement(FirstLevelSelect);
            PageInteractionHelper.IsElementPresent(SecondLevelSelect);
        }

        internal void CheckBackLink()
        {
            PageInteractionHelper.IsElementPresent(BackLink);
        }

        internal void ValidateLevelFilter()
        {
            PageInteractionHelper.IsElementPresent(LevelSelect);
        }

        internal void ValidateCategoryFilter()
        {
            PageInteractionHelper.IsElementPresent(CategoriesSelect);
        }

        internal void ValidateAddThisProvisionLink()
        {
            PageInteractionHelper.IsElementPresent(AddThisProvisionLink);
        }
    }
}
