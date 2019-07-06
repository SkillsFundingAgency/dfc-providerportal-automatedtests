using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using UITesting.ProviderPortal.Pages.Venue_Management;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCoursePage : BasePage
    {
        //page objects
        private static String PAGE_TITLE = "Complete qualification details";
        private By howWillLearn = By.Id("HowYouWillLearn");
        private By howWillLearnError = By.XPath(".//*[@id='sectionHowYouWillLearn']/div/div/span[2]");            
        private By howWillLearnInfo = By.Id("HowYouWillLearn-info");
        private By whatWillLearn = By.Id("WhatWillLearn");
        private By whatWillLearnError = By.XPath(".//*[@id='sectionWhatWillLearn']/div/div/span[2]");               
        private By whatWillLearnInfo = By.Id("WhatWillLearn-info");
        private By courseFor = By.Id("CourseFor");
        private By courseForError = By.XPath(".//*[@id='sectionCourseFor']/div/div/span[2]");                       
        private By courseForInfo = By.Id("CourseFor-info");
        private By entryRequirements = By.Id("EntryRequirements");
        private By entryRequirementsError = By.XPath(".//*[@id='sectionEntryRequirements']/div/div/span[2]");        
        private By entryRequirementsInfo = By.Id("EntryRequirements-info");
        private By equipmentNeeded = By.Id("WhatYouNeed");
        private By equipmentNeededError = By.XPath(".//*[@id='sectionWhatYouNeed']/div/div/span[2]");               
        private By equipmentNeededInfo = By.Id("WhatYouNeed-info");
        private By howAssessed = By.Id("HowAssessed");
        private By howAssessedError = By.XPath(".//*[@id='sectionHowAssessed']/div/div/span[2]");                   
        private By howAssessedInfo = By.Id("HowAssessed-info");
        private By nextSteps = By.Id("WhereNext");
        private By nextStepsError = By.XPath(".//*[@id='sectionWhereNext']/div/div/span[2]");                        
        private By nextStepsInfo = By.Id("WhereNext-info");
        private By nextButton = By.Id("goToSection2");
        private By HeaderMessage = By.XPath("//*[@id='error-summary-title']");
        
        //variables
        private string errortxt;

        public AddCoursePage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public AddCoursePage EnterWhoCourseFor(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterEntryRequirements(String entryText)
        {
            FormCompletionHelper.EnterText(entryRequirements, entryText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterWhatWillLearn(String whatText)
        {
            FormCompletionHelper.EnterText(whatWillLearn, whatText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterHowYoullLearn(String howText)
        {
            FormCompletionHelper.EnterText(howWillLearn, howText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage EnterEquipmentNeeded(String equipText)
        {
            FormCompletionHelper.EnterText(equipmentNeeded, equipText);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage HowAssessed(String assessment)
        {
            FormCompletionHelper.EnterText(howAssessed, assessment);
            return new AddCoursePage(webDriver);
        }


        public AddCoursePage NextSteps(String nextsteps)
        {
            FormCompletionHelper.EnterText(nextSteps, nextsteps);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage2 ClickNext()
        {
            FormCompletionHelper.ClickElement(nextButton);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage ClickNextFail()
        {
            FormCompletionHelper.ClickElement(nextButton);
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage ConfirmErrorMessage(string field, string errorMsg)
        {
            switch (field)
            {
                case "Who is the course for":
                    PageInteractionHelper.WaitForElementToBePresent(courseForError);
                    PageInteractionHelper.IsElementDisplayed(courseForError);
                    errortxt = webDriver.FindElement(courseForError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "Entry requirements":
                    PageInteractionHelper.WaitForElementToBePresent(entryRequirementsError);
                    PageInteractionHelper.IsElementDisplayed(entryRequirementsError);
                    errortxt = webDriver.FindElement(entryRequirementsError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "What you will learn":
                    PageInteractionHelper.WaitForElementToBePresent(whatWillLearnError);
                    PageInteractionHelper.IsElementDisplayed(whatWillLearnError);
                    errortxt = webDriver.FindElement(whatWillLearnError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "How you will learn":
                    PageInteractionHelper.WaitForElementToBePresent(howWillLearnError);
                    PageInteractionHelper.IsElementDisplayed(howWillLearnError);
                    errortxt = webDriver.FindElement(howWillLearnError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "What you need to bring":
                    PageInteractionHelper.WaitForElementToBePresent(equipmentNeededError);
                    PageInteractionHelper.IsElementDisplayed(equipmentNeededError);
                    errortxt = webDriver.FindElement(equipmentNeededError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "How you will be assessed":
                    PageInteractionHelper.WaitForElementToBePresent(howAssessedError);
                    PageInteractionHelper.IsElementDisplayed(howAssessedError);
                    errortxt = webDriver.FindElement(howAssessedError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "Where next":
                    PageInteractionHelper.WaitForElementToBePresent(nextStepsError);
                    PageInteractionHelper.IsElementDisplayed(nextStepsError);
                    errortxt = webDriver.FindElement(nextStepsError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage(webDriver);

                default:
                    throw new Exception("Field does not exist");
            }
        }

        internal void ValidateSummaryErrorMessage(string strSummErrMsg)
        {
            PageInteractionHelper.VerifyText(courseForError, strSummErrMsg);
        }

        internal void ValidateHeaderMessage(string strHeadMsg)
        {
            PageInteractionHelper.VerifyText(HeaderMessage,strHeadMsg);
        }

        public AddCoursePage ConfirmInfoMessage(string field, string infoMsg)
        {
            switch (field)
            {
                case "Who is the course for":
                    PageInteractionHelper.WaitForElementToBePresent(courseForInfo);
                    PageInteractionHelper.IsElementDisplayed(courseForInfo);
                    errortxt = webDriver.FindElement(courseForInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "Entry requirements":
                    PageInteractionHelper.WaitForElementToBePresent(entryRequirementsInfo);
                    PageInteractionHelper.IsElementDisplayed(entryRequirementsInfo);
                    errortxt = webDriver.FindElement(entryRequirementsInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "What you will learn":
                    PageInteractionHelper.WaitForElementToBePresent(whatWillLearnInfo);
                    PageInteractionHelper.IsElementDisplayed(whatWillLearnInfo);
                    errortxt = webDriver.FindElement(whatWillLearnInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "How you will learn":
                    PageInteractionHelper.WaitForElementToBePresent(howWillLearnInfo);
                    PageInteractionHelper.IsElementDisplayed(howWillLearnInfo);
                    errortxt = webDriver.FindElement(howWillLearnInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "What you need to bring":
                    PageInteractionHelper.WaitForElementToBePresent(equipmentNeededInfo);
                    PageInteractionHelper.IsElementDisplayed(equipmentNeededInfo);
                    errortxt = webDriver.FindElement(equipmentNeededInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "How you will be assessed":
                    PageInteractionHelper.WaitForElementToBePresent(howAssessedInfo);
                    PageInteractionHelper.IsElementDisplayed(howAssessedInfo);
                    errortxt = webDriver.FindElement(howAssessedInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                case "Where next":
                    PageInteractionHelper.WaitForElementToBePresent(nextStepsInfo);
                    PageInteractionHelper.IsElementDisplayed(nextStepsInfo);
                    errortxt = webDriver.FindElement(nextStepsInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage(webDriver);

                default:
                    throw new Exception("Field does not exist");

            }
        }

    }
}