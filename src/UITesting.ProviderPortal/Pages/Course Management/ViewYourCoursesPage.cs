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
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='0']");       //first one in list '0'
        private static By showFirstCourseDescriptionPopupLink = By.XPath("//*[@id='0']");
        private static By showSecondCourseDescriptionPopupLink = By.XPath("//*[@id='1']");
        //elt added - View Description..
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
        private By closeViewCourseDescriptionPopup = By.Id("popup-descript-close");   //XPath("//*[@id=\"close-preview\"]"); 


        private By ClickViewURLLink = By.Id("URLLink");
        private By ViewCourseURLText = By.Id("courseRun_CourseURL");
        private By ClickURLClose = By.LinkText("Close");
        private By ClickCostDescriptionLink = By.Id("CostDetailLink");
        private By ViewCostDescriptionText = By.Id("courseRun_CostDescription");
        private By ClickCostDescriptionClose = By.LinkText("Close");


        //private By courseFor = By.Id("CourseFor");
        //private By entryRequirements = By.Id("EntryRequirements");



        //private By whatWillLearn = By.Id("WhatWillLearn");
        //private By howWillLearn = By.Id("HowYouWillLearn");
        //private By equipmentNeeded = By.Id("WhatYouNeed");
        //private By howAssessed = By.Id("HowAssessed");
        //private By nextSteps = By.Id("WhereNext");
        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


        //Shivani added - Line2
        private By clickHomeButton = By.CssSelector("ul.govuk-header__navigation li:nth-of-type(1)");
        private By enterUKPRN = By.Id("SearchTerm");
        private By clickSearch = By.Id("searchProvider");
        private By coursesButton = By.CssSelector("ul.govuk-header__navigation li:nth-of-type(5)");
        private By verifyCourseTitle = By.Id("courseRun_CourseName");
        private By verifyIDTitle = By.Id("courseRun_ProviderCourseID");
        private By verifyDeliveryTitle = By.Id("deliveryMode");
        private By verifyVenueTitle = By.Id("VenueId");
        private By verifyURLTitle = By.Id("URLLink");
        private By verifyCostTitle = By.Id("cost");
        private By verifyCostDescriptionTitle = By.Id("CostDetailLink");
        private By verifyDurationTitle = By.Id("courseRun_DurationValue");
        private By verifyDurationUnitTitle = By.Id("durationUnit");
        private By verifyAttendanceTitle = By.Id("attendance");
        private By verifyModeTitle = By.Id("mode");
         


        //public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)

        //private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


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


        //Shivani Line2

      

        internal void courseNameLabelText(string courseLabel)
        {
            if (courseLabel == "Course name")
            {
                PageInteractionHelper.VerifyText(verifyCourseTitle, courseLabel);
               }

            if (courseLabel == "ID")
            {
                PageInteractionHelper.VerifyText(verifyIDTitle, courseLabel);
                
            }

            if (courseLabel == "Delivery")
            {
                PageInteractionHelper.VerifyText(verifyDeliveryTitle, courseLabel);

            }
            
            if (courseLabel == "Venue")
            {
                PageInteractionHelper.VerifyText(verifyVenueTitle, courseLabel);
            }

            if (courseLabel == "URL")
            {
                PageInteractionHelper.IsElementPresent(verifyURLTitle);
            }

            if (courseLabel == "Cost Description")
            {
                PageInteractionHelper.IsElementPresent(verifyCostDescriptionTitle);
            }

            if (courseLabel == "Cost")
            {
                PageInteractionHelper.VerifyText(verifyCostTitle, courseLabel);
                
            }

            if (courseLabel == "Duration")
            {
                PageInteractionHelper.VerifyText(verifyDurationTitle, courseLabel);
                
            }

            if (courseLabel == "Duration Unit")
            {
                PageInteractionHelper.VerifyText(verifyDurationUnitTitle, courseLabel);

            }
            if (courseLabel == "Attendance")
            {
                PageInteractionHelper.VerifyText(verifyAttendanceTitle, courseLabel);
            }

            if (courseLabel == "Mode")
            {
                PageInteractionHelper.VerifyText(verifyModeTitle, courseLabel);
            }


        }

       /* internal void checkDropDownBoxes(string dropDown)
        {
            if (dropDown == "Delivery")
            {
                FormCompletionHelper.ClickElement(deliveryTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Venue")
            {
                FormCompletionHelper.ClickElement(venueTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Duration Unit")
            {
                FormCompletionHelper.ClickElement(durationUnitTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Attendance")
            {
                FormCompletionHelper.ClickElement(attendanceTitleDropDown);
                Thread.Sleep(2000);

            }
            if (dropDown == "Mode")
            {
                FormCompletionHelper.ClickElement(modeTitleDropDown);
                Thread.Sleep(2000);

                FormCompletionHelper.ClickElement(modeTitleDropDown);
                Thread.Sleep(2000);

            }

        }*/

       
        

    }
}

