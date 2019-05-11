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
        private By FirstFilter = By.CssSelector("#NotionalNVQLevelv2Filter-0");

        public SearchforQualificationPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        public void CheckSearchTermField()
        {
            PageInteractionHelper.IsElementPresent(LARSSearchTerm);
        }
        public void EnterLARS_QANNumber(string searchTerm)
        {
            FormCompletionHelper.EnterText(LARSSearchTerm, searchTerm);
        }
        public void CheckValidationMessage(string validationMsg)
        {
            PageInteractionHelper.VerifyText(SearchValidationMsg, validationMsg);
        }
        public void LookForQualificationLevelFilter(string QualLevelFilterName)
        {
            PageInteractionHelper.VerifyText(QualLevelFilter, QualLevelFilterName);
        }
        public void LookForAwardingBodyFilter(string AwardBodyFilterName)
        {
            PageInteractionHelper.VerifyText(AwardBodyFilter, AwardBodyFilterName);
        }
        public void CheckAddQualificationLink()
        {
            PageInteractionHelper.VerifyElementPresent(AddQualLink);
        }

        public void AddQualificationLink()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(AddQualLink);
            PageInteractionHelper.WaitForPageToLoad();
        }

        public void ClickQualLevelFilter()
        {
            //FormCompletionHelper.IsElementPresent(QualLevelFilter);
        }

        public void CheckResultsMessage(string resultsMsg)
        {
          //  FormCompletionHelper.VerifyText(ResultsMessage, resultsMsg);
        }

        public void ValidateLabels(string lARSQAN_Lbl, string levelLbl, string awardBodyLbl)
        {
            FormCompletionHelper.VerifyText(LARSQANlabel, lARSQAN_Lbl);
            FormCompletionHelper.VerifyText(LevelLabel, levelLbl);
            FormCompletionHelper.VerifyText(AwardBodyLabel, awardBodyLbl);
        }

        public void ClearAllFilters()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(ClearFilters, 10);
            FormCompletionHelper.ClickElement(ClearFilters);
        }

        public SearchforQualificationPage FiltersCleared()
        {
            PageInteractionHelper.WaitForPageToLoad();
            if (!(webDriver.FindElement(ClearFilters).Displayed))
            {
                throw new Exception("Filters not cleared");
            }
            return new SearchforQualificationPage(webDriver);
        }

        public SearchforQualificationPage ClickFirstFilter()
        {
            if (webDriver.GetType().Name.ToString().Contains("RemoteWebDriver"))
            {
                //Thread.Sleep(3000);
                webDriver.FindElementWait(FirstFilter, 60);
                var element = this.webDriver.FindElement(FirstFilter);
                ((IJavaScriptExecutor)this.webDriver).ExecuteScript("arguments[0].click();", element);
            }
            else
            {
                PageInteractionHelper.WaitForPageToLoad();
                FormCompletionHelper.ClickElement(FirstFilter);
            }

            PageInteractionHelper.WaitForPageToLoad();
            return new SearchforQualificationPage(webDriver);
        }

    }
}
