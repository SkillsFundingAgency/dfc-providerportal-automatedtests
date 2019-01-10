using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Qualification_Management
{
    public class SearchforQualificationPage : TestSupport.BasePage 
    {
        private static String PAGE_TITLE = "Find a Qualification";
        private static By LARSSearchTerm = By.Id("LarsSearchTerm");
        private By SearchValidationMsg = By.XPath("//*[@id='error-summary-title']");
        //private By QualLevelFilter = By.XPath("//*[@id='tab0']/h3");
        private By QualLevelFilter = By.XPath("//*[@id='LarsSearchResultContainer']/div/div[2]/div[1]/div[1]"); 
        //private By AwardBodyFilter = By.XPath("//*[@id='tab1']/h3");
        private By AwardBodyFilter = By.XPath(".//*[@id='LarsSearchResultContainer']/div/div[2]/div[2]/div[1]");
        private By AddQualLink = By.XPath(".//*[@id='LarsSearchResultContainer']/div/div[3]/div/div[1]/a");
        private By ClickQualFilter = By.XPath("//*[@id='tab0']/h3/span");
        private By ResultsMessage = By.XPath("//*[@id='LarsSearchResultContainer']/div/div[1]");
        private By LARSQANlabel = By.XPath("//*[@id='LarsSearchResultContainer']/div/div[3]/div/div[1]/p[1]");
        private By LevelLabel = By.XPath("//*[@id='LarsSearchResultContainer']/div/div[3]/div/div[1]/p[2]");
        private By AwardBodyLabel = By.XPath("//*[@id='LarsSearchResultContainer']/div/div[3]/div/div[1]/p[3]");
        private By ClearFilters = By.Id("ClearAllFilters");
        private By FirstFilter = By.XPath(".//*[@id='NotionalNVQLevelv2Filter-0']");

        public SearchforQualificationPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal void CheckSearchTermField()
        {
            PageInteractionHelper.IsElementPresent(LARSSearchTerm);
        }
        internal void EnterLARS_QANNumber(string searchTerm)
        {
            FormCompletionHelper.EnterText(LARSSearchTerm, searchTerm);
        }
        internal void CheckValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(SearchValidationMsg, validationMsg);
        }
        internal  void LookForQualificationLevelFilter(string QualLevelFilterName)
        {
            PageInteractionHelper.VerifyText(QualLevelFilter, QualLevelFilterName);
        }
        internal void LookForAwardingBodyFilter(string AwardBodyFilterName)
        {
            PageInteractionHelper.VerifyText(AwardBodyFilter, AwardBodyFilterName);
        }
        internal void CheckAddQualificationLink()
        {
            PageInteractionHelper.VerifyElementPresent(AddQualLink);
        }

        public void AddQualificationLink()
        {
            FormCompletionHelper.ClickElement(AddQualLink);
        }

        internal void ClickQualLevelFilter()
        {
            //FormCompletionHelper.IsElementPresent(QualLevelFilter);
        }

        internal void CheckResultsMessage(string resultsMsg)
        {
          //  FormCompletionHelper.VerifyText(ResultsMessage, resultsMsg);
        }

        internal void ValidateLabels(string lARSQAN_Lbl, string levelLbl, string awardBodyLbl)
        {
            FormCompletionHelper.VerifyText(LARSQANlabel, lARSQAN_Lbl);
            FormCompletionHelper.VerifyText(LevelLabel, levelLbl);
            FormCompletionHelper.VerifyText(AwardBodyLabel, awardBodyLbl);
        }

        internal void ClearAllFilters()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(ClearFilters);
        }

        internal SearchforQualificationPage FiltersCleared()
        {
            PageInteractionHelper.WaitForPageToLoad();
            if (!(webDriver.FindElement(ClearFilters).Displayed))
            {
                throw new Exception("Filters not cleared");
            }
            return new SearchforQualificationPage(webDriver);
        }

        internal SearchforQualificationPage ClickFirstFilter()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(FirstFilter);
            return new SearchforQualificationPage(webDriver);
        }

    }
}
