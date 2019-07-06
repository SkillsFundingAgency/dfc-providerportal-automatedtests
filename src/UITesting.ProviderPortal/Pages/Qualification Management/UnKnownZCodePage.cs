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
        private By AddThisProvisionLink = By.LinkText("Choose this provision");
        // private By LevelSelect = By.Id("LevelsSelect");
        private By LevelFilter = By.XPath("//*[@id='results']/div/div[1]/div[1]/div[1]");
       // private By CategoriesSelect = By.Id("CategoriesSelect");
        private By CategoriesFilter = By.XPath("//*[@id='results']/div/div[1]/div[2]/div[1]");

        private By PageNumber = By.LinkText("2");

        //private By ResetLink = By.Id("ClearAllFilters");
        //private By ResetLink=By.XPath(("//a[@href='reset']"));
        private By ResetLink = By.LinkText("reset");
        private By FliterLevelCheckBox = By.Id("NotionalNVQLevelv2Filter-0");
        private By CategoryFilterCheckBox = By.Id("AwardOrgAimRefFilter-0");

        
        public UnKnownZCodePage(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        public void ClickBackLink()
        {
            FormCompletionHelper.ClickElement(BackLink);
        }

        public void ClickFirstLevel()
        {
            FormCompletionHelper.ClickElement(FirstLevelSelect);
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(FirstLevelSelect), 1);
            
        }

        public void ClickSecondLevel()
        {
            FormCompletionHelper.ClickElement(SecondLevelSelect);
            FormCompletionHelper.SelectFromDropDownByIndex(webDriver.FindElement(SecondLevelSelect), 1);
        }

        public void ClickAddThisProvision()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(AddThisProvisionLink);
        }

        public void SelectPage(string pgNum)
        {
            FormCompletionHelper.ClickElement(PageNumber);
            PageInteractionHelper.WaitForPageToLoad();
        }

        public void CheckFirstLevelDropDown()
        {
            PageInteractionHelper.IsElementPresent(FirstLevelSelect);
        }
        public void CheckSecondLevelDropDown()
        {
            FormCompletionHelper.ClickElement(FirstLevelSelect);
            PageInteractionHelper.IsElementPresent(SecondLevelSelect);
        }

        public void CheckBackLink()
        {
            PageInteractionHelper.IsElementPresent(BackLink);
        }

        public void ValidateLevelFilter()
        {
            PageInteractionHelper.IsElementPresent(LevelFilter);
        }

        internal void ValidateCategoryFilter()
        {
            PageInteractionHelper.IsElementPresent(CategoriesFilter);
        }

        internal void ValidateAddThisProvisionLink()
        {
            PageInteractionHelper.IsElementPresent(AddThisProvisionLink);
        }

        internal void SelectFilterLevel()
        {
            FormCompletionHelper.ClickElement(FliterLevelCheckBox);
        }

        internal void SelectCategoryLevel()
        {
            FormCompletionHelper.ClickElement(CategoryFilterCheckBox);
        }

        internal void ViewResetLink()
        {
            FormCompletionHelper.IsElementPresent(ResetLink);
        }

        internal void ClickResetLink()
        {
            FormCompletionHelper.ClickElement(ResetLink);
        }

        internal void CheckBoxDeselect()
        {
            
        }
    }
}
