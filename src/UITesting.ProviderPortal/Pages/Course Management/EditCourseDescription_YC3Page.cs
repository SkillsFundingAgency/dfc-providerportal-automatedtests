﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    

    public class EditCourseDescription_YC3Page: BasePage
    {
        private static String PAGE_TITLE = "Edit Course";

        private By AdultEducationBudget = By.Id("AdultEducationBudget");
        private By AdvancedLearnerLoan = By.Id("AdvancedLearnerLoan");
        private By SaveButton = By.Id("save");
        private By CancelLink = By.LinkText("Cancel");
        private By CourseForText = By.Id("CourseFor");
        private By EntryReqText = By.Id("EntryRequirements");
        private By HowYouWillLearnText = By.Id("HowYouWillLearn");
        private By WhatWillLearnText = By.Id("WhatWillLearn");
        private By WhatYouNeedText = By.Id("WhatYouNeed");
        private By HowAssessedText = By.Id("HowAssessed");
        private By WhereNextText = By.Id("WhereNext");

        private By CourseForErrMsg = By.XPath("//*[@id='sectionCourseFor']/div/div/span[2]");
        private By EntryReqErrMsg = By.XPath("//*[@id='sectionEntryRequirements']/div/div/span[2]");
        private By WhatYouWillLearnErrMsg = By.XPath("//*[@id='sectionWhatWillLearn']/div/div/span[2]");
        private By HowYouWillLearnErrMsg = By.XPath("//*[@id='sectionHowYouWillLearn']/div/div/span[2]");
        private By WhatYouWillNeedtoBringErrMsg = By.XPath("//*[@id='sectionWhatYouNeed']/div/div/span[2]");
        private By HowYouWillBeAssessedErrMsg = By.XPath("//*[@id='sectionHowAssessed']/div/div/span[2]);
        private By WhereNextErrMsg = By.XPath("//*[@id='sectionWhereNext']/div/div/span[2]");


        public EditCourseDescription_YC3Page(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void EnterWhatWillYouLearn(string strData)
        {
            FormCompletionHelper.EnterText(WhatWillLearnText, strData);
        }

        internal void EnterCourseDescription(string strData)
        {
            FormCompletionHelper.EnterText ( CourseForText, strData);
        }
        internal void EnterEntryRequirements(string strData)
        {
            FormCompletionHelper.EnterText(EntryReqText,strData)
        }

        internal void EnterHowYouWillLearn(string strData)
        {
            FormCompletionHelper.EnterText(HowYouWillLearnText, strData);
        }

        internal void EnterWhatYouWillNeedToBring(string strData)
        {
            FormCompletionHelper.EnterText(WhatYouNeedText, strData);
        }

        internal void EnterHowYouWillBeAssessed(string strData)
        {
            FormCompletionHelper.EnterText(HowAssessedText, strData);
        }

        internal void EnterWhereNext(string strData)
        {
            FormCompletionHelper.EnterText(WhereNextText, strData);
        }

        internal void SelectAdvancedLearnerOption()
        {
            FormCompletionHelper.ClickElement(AdvancedLearnerLoan);
        }

        internal void SelectAdultEducationOption()
        {
            FormCompletionHelper.ClickElement(AdultEducationBudget);
        }

        internal void ClickCancel()
        {
            FormCompletionHelper.ClickElement(CancelLink);
        }

        internal void CheckFundingOptions()
        {
            PageInteractionHelper.IsElementPresent(AdultEducationBudget);
            PageInteractionHelper.IsElementPresent(AdvancedLearnerLoan);
        }

        internal void ValidateButtons()
        {
            PageInteractionHelper.IsElementPresent(SaveButton);
            PageInteractionHelper.IsElementPresent(CancelLink);
        }       

        internal void ClickSave()
        {
            FormCompletionHelper.ClickElement(SaveButton);
        }

        internal void ValidateCourseForError(string errMsg)
        {
            PageInteractionHelper.VerifyText(CourseForErrMsg, errMsg);
        }

        internal void ValidateEntryRequirementsError(string errMsg)
        {
            PageInteractionHelper.VerifyText(EntryReqErrMsg, errMsg);
        }

        internal void WhatYouWillLearnError(string errMsg)
        {
            PageInteractionHelper.VerifyText(WhatYouWillLearnErrMsg, errMsg);
        }

        internal void HowYouWillLearnError(string errMsg)
        {
            PageInteractionHelper.VerifyText(HowYouWillLearnErrMsg, errMsg);
        }

        internal void WhatYouWillNeedToBringError(string errMsg)
        {
            PageInteractionHelper.VerifyText(WhatYouWillNeedtoBringErrMsg, errMsg);
        }

        internal void HowYouWillBeAssessedError(string errMsg)
        {
            PageInteractionHelper.VerifyText(HowYouWillBeAssessedErrMsg, errMsg);
        }

        internal void WhereNextError(string errMsg)
        {
            PageInteractionHelper.VerifyText(WhereNextErrMsg, errMsg);
        }
    }
}
