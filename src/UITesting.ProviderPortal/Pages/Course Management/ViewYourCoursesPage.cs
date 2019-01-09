using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    
    public class ViewYourCoursesPage : TestSupport.BasePage 
    {
        private static String PAGE_TITLE = "Your courses";
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='main-content']/div/div/div[2]/div/ul/li[2]/div/div/p/a");
        //elt added - View Description...
        private By courseDescription = By.XPath("---");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");

        private By ClickViewURLLink = By.Id("URLLink");
        private By ViewCourseURLText = By.Id("courseRun_CourseURL");
        private By ClickURLClose = By.LinkText("Close");
        private By ClickCostDescriptionLink = By.Id("CostDetailLink");
        private By ViewCostDescriptionText = By.Id("courseRun_CostDescription");
        private By ClickCostDescriptionClose = By.LinkText("Close");





        private By courseFor = By.Id("CourseFor");
        private By entryRequirements = By.Id("EntryRequirements");

       

        private By whatWillLearn = By.Id("WhatWillLearn");
        private By howWillLearn = By.Id("HowYouWillLearn");
        private By equipmentNeeded = By.Id("WhatYouNeed");
        private By howAssessed = By.Id("HowAssessed");
        private By nextSteps = By.Id("WhereNext");

        

        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");
        

        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        internal void ClickCloseCostDescription()
        {
            FormCompletionHelper.ClickElement(ClickCostDescriptionClose);
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void HideCostDescription()
        {
            PageInteractionHelper.VerifyElementNotPresent(ViewCostDescriptionText);
        }
        internal void ClickCourseCostDescriptionLink()
        {
            FormCompletionHelper.ClickElement(ClickCostDescriptionLink);
        }

        
        internal void CloseURL()
        {
            FormCompletionHelper.ClickElement(ClickURLClose);
        }

        internal void ClickViewURL()
        {
            FormCompletionHelper.ClickElement(ClickViewURLLink);
        }

        internal void ViewCourseURL()
        {
            FormCompletionHelper.IsElementPresent(ViewCourseURLText);
        }

        internal void CheckViewCourseDescription()
        {
            PageInteractionHelper.IsElementPresent(ViewCostDescriptionText);
        }

        internal void ConfirmURLReadOnly()
        {
            //throw new NotImplementedException();
            PageInteractionHelper.IsElementReadOnly(ViewCourseURLText);            
        }

        //Elt view Description->
        internal void ClickViewCourseDescription()
        {
            FormCompletionHelper.ClickElement(ViewCourseDescriptionLink);
            Thread.Sleep(5000);
        }

        internal void ViewCourseCostDetail()
        {
            PageInteractionHelper.VerifyElementPresent(ViewCostDescriptionText);
        }

        internal void HideURLText()
        {
            
            PageInteractionHelper.VerifyElementNotPresent(ViewCourseURLText);
        }

        internal void ConfirmCourseCostDescReadOnly()
        {
            PageInteractionHelper.IsElementReadOnly(ViewCostDescriptionText);
        }

        internal void ClickShowCourseDescriptionPopup()
        {
            FormCompletionHelper.ClickElement(showCourseDescriptionPopupLink);
            Thread.Sleep(5000);
        }

        internal void ClickOpenAccordianDiploma()
        {
            FormCompletionHelper.ClickElement(DiplomaAccordianLink);
            Thread.Sleep(5000);
        }

        public ViewYourCoursesPage VerifyCourseDescription(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new ViewYourCoursesPage(webDriver);
        }
        public ViewYourCoursesPage VerifyWhoCourseFor(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new ViewYourCoursesPage(webDriver);
        }
        public ViewYourCoursesPage VerifyEntryRequirements(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new ViewYourCoursesPage(webDriver);
        }
        public ViewYourCoursesPage VerifyWhatWillLearn(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new ViewYourCoursesPage(webDriver);
        }
        public ViewYourCoursesPage VerifyHowWillLearn(String whoText)
        {
            FormCompletionHelper.EnterText(courseFor, whoText);
            return new ViewYourCoursesPage(webDriver);
        }

    }
}
