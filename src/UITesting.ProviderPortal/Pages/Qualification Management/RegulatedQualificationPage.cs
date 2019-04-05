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
    public class RegulatedQualificationPage : TestSupport.BasePage 
    {
        private static String PAGE_TITLE = "What are you awarding with this course";
        private By RegQualOption = By.Id("Regulated");
        private By NonRegOption = By.Id("NonRegulated");
        private By NextButton = By.Id("next");
        private By ErrMsg = By.XPath("//*[@id='QualificationType']/div/fieldset/span");
        public RegulatedQualificationPage(IWebDriver webDriver ): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void SelectRegulatedOption()
        {
            FormCompletionHelper.ClickElement(RegQualOption);
        }

        internal void ClickNext()
        {
            FormCompletionHelper.ClickElement(NextButton);
        }

        internal void SelectNonRegulatedOption()
        {
            FormCompletionHelper.ClickElement(NonRegOption);
        }

        internal void CheckNoOptionSelected()
        {
            //PageInteractionHelper.IsObjectSelected
        }

        internal void CheckOption(string strOption)
        {
            if (strOption =="Regulated")
            {
                FormCompletionHelper.IsElementPresent(RegQualOption);
            }
            else if(strOption =="NonRegulated")
            {
                FormCompletionHelper.IsElementPresent(NonRegOption);
            }
        }

        
        internal void CheckNextButton()
        {
            FormCompletionHelper.IsElementPresent(NextButton);
        }

        internal void ValidateErrorMessage(string errMsg)
        {
            FormCompletionHelper.VerifyText(ErrMsg, errMsg);
        }
    }
}
