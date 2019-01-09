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
 
        //elt added - View Description... using links from prototype
        private By courseDescriptionTitle = By.ClassName("govuk-caption-l");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");
        private By courseDescriptionPopup = By.Id("popup-descript");
        private By courseFor = By.Id("descript");
        private By entryRequirements = By.Id("next");
        private By whatWillLearn = By.Id("learn");
        private By howWillLearn = By.Id("how");
        private By equipmentNeeded = By.Id("how");
        private By howAssessed = By.Id("how");
        private By nextSteps = By.Id("next");
        private By diplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");
        private By closeViewCourseDescriptionPopup = By.XPath("//*[@id=\"close-preview\"]"); 
        
        private By ClickViewURLLink = By.Id("URLLink");
        private By ViewCourseURLText = By.Id("courseRun_CourseURL");
        private By ClickURLClose = By.XPath("//a[contains(text(), 'Close')]/text()");


        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");
        

        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
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
            PageInteractionHelper.IsElementPresent(ViewCourseDescriptionLink);
        }

        internal void ConfirmURLReadOnly()
        {
            //throw new NotImplementedException();
           // PageInteractionHelper.IsElementReadOnly(ViewCourseURLText);            
        }

        //Elt view Description->
        internal void ClickViewCourseDescription()
        {
            FormCompletionHelper.ClickElement(ViewCourseDescriptionLink);
            
        }

        internal void HideURL()
        {
            throw new NotImplementedException();
        }

        internal void ClickShowCourseDescriptionPopup()
        {
            FormCompletionHelper.ClickElement(showCourseDescriptionPopupLink);
        
        }

        internal void ClickOpenAccordianDiploma()
        {
            FormCompletionHelper.ClickElement(diplomaAccordianLink);
           
        }

        internal void VerifyDescriptionPopupOpens()
        {
            PageInteractionHelper.IsElementPresent(courseDescriptionPopup);

        }
        public ViewYourCoursesPage VerifyCourseDescriptionShown()
        {
            //Title 'Course Description' shown
            PageInteractionHelper.VerifyElementPresent(courseDescriptionTitle);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyWhoCourseFor()
        {
            PageInteractionHelper.VerifyElementPresent(courseFor);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyEntryRequirements()
        {
            PageInteractionHelper.VerifyElementPresent(entryRequirements);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyWhatWillLearn()
        {
            PageInteractionHelper.VerifyElementPresent(whatWillLearn);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyHowWillLearn()
        {
            PageInteractionHelper.VerifyElementPresent(howWillLearn);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyEquipmentNeeded()
        {
            PageInteractionHelper.VerifyElementPresent(equipmentNeeded);
            return new ViewYourCoursesPage(webDriver);
        }

        public ViewYourCoursesPage VerifyHowAssessed()
        {
            PageInteractionHelper.VerifyElementPresent(howAssessed);
            return new ViewYourCoursesPage(webDriver);
        }


        internal void ClickCloseCourseDescriptionPopup()
        {
            PageInteractionHelper.VerifyElementPresent(closeViewCourseDescriptionPopup);
            //FormCompletionHelper.ClickElement(showCourseDescriptionPopupLink);

        }

    }
}
