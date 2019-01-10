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

        private By courseFor = By.Id("CourseFor");
        private By entryRequirements = By.Id("EntryRequirements");
        private By whatWillLearn = By.Id("WhatWillLearn");
        private By howWillLearn = By.Id("HowYouWillLearn");
        private By equipmentNeeded = By.Id("WhatYouNeed");
        private By howAssessed = By.Id("HowAssessed");
        private By nextSteps = By.Id("WhereNext");
        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


        //Shivani added - Line2
        private By verifyCourseTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.large:nth-of-type(1) label.govuk-label");
        private By CourseTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.large:nth-of-type(1) input");

        private By verifyIDTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(2) label.govuk-label");
        private By IDTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(2) input");

        private By verifyDeliveryTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(3) label.govuk-label");
        private By deliveryTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(3) select#deliveryMode");

        private By verifyStartDateTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(4) label.govuk-label");
        private By startDateTitleInputBox = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[4]/div");

        private By verifyVenueTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(5) label.govuk-label");
        private By venueTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(5) select#VenueId");

        private By verifyURLTitle = By.XPath("//*[@id='course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba']/div[6]/label");
        private By urlTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#URLLink");

        private By verifyCostTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[7]/label");
        private By costTitleInputBox = By.CssSelector("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[7]/input");

        private By verifyCostDescriptionTitle = By.XPath("//*[@id='course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba']/div[8]/label");
        private By costDescriptionTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#CostDetailLink");

        private By verifyDurationTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[9]/label");
        private By durationTitleInputBox = By.CssSelector("//*[@id='courseRun_DurationValue']");

        private By verifyDurationUnitTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[10]/label");
        private By durationUnitTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#durationUnit");

        private By verifyAttendanceTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[11]/label");
        private By attendanceTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#attendance");

        private By verifyModeTitle = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[12]/label");
        private By modeTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#mode");



        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)



        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
        internal void CheckViewCourseDescription()
        {
            PageInteractionHelper.IsElementPresent(ViewCourseDescriptionLink);
        }

        //Elt view Description->
        internal void ClickViewCourseDescription()
        {
            FormCompletionHelper.ClickElement(ViewCourseDescriptionLink);
            Thread.Sleep(5000);
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

        //Shivani Line2
        internal void courseNameLabelText(string courseLabel)
        {
            if (courseLabel == "Course name")
            {
                PageInteractionHelper.VerifyText(verifyCourseTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(CourseTitleInputBox);

            }
            if (courseLabel == "ID")
            {
                PageInteractionHelper.VerifyText(verifyIDTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(IDTitleInputBox);
            }
            if (courseLabel == "Delivery")
            {
                PageInteractionHelper.VerifyText(verifyDeliveryTitle, courseLabel);
               
            }
            if (courseLabel == "Start Date")
            {
                PageInteractionHelper.VerifyText(verifyStartDateTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(startDateTitleInputBox);
            }
            if (courseLabel == "Venue")
            {
                PageInteractionHelper.VerifyText(verifyVenueTitle, courseLabel);
            }
            if (courseLabel == "Cost")
            {
                PageInteractionHelper.VerifyText(verifyCostTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(costTitleInputBox);
            }
            if (courseLabel == "Duration")
            {
                PageInteractionHelper.VerifyText(verifyDurationTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(durationTitleInputBox);
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

        internal void checkDropDownBoxes(string dropDown)
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

        }

        internal void checkhyperLinkTitle(string hyperlink)
        {
            if (hyperlink == "URL")
            {
                PageInteractionHelper.VerifyText(verifyURLTitle, hyperlink);
            }

            if (hyperlink == "Cost Description")
            {
                PageInteractionHelper.VerifyText(verifyCostDescriptionTitle, hyperlink);
            }
        }

    }
}
