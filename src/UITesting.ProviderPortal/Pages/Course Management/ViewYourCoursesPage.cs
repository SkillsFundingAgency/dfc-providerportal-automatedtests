using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using NUnit.Framework;

namespace UITesting.ProviderPortal.Pages.Course_Management
{

    public class ViewYourCoursesPage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Your courses";
        private By successMsg = By.XPath(".//*[@id='main-content']/div/div/div[1]/h1");
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='0']");     
        private static By showFirstCourseDescriptionPopupLink = By.XPath("//*[@id='0']");
        private static By showSecondCourseDescriptionPopupLink = By.XPath("//*[@id='1']");
        // Elt - YC3 specific.. //

        private static By selectedLevelTitle = By.ClassName("cd__your-courses__filters-list__link cd__your-courses__filters-list__link--selected");
        private static By qualificationTitles = By.ClassName("govuk-details__summary-text");
        private static By courseRunTitles = By.ClassName("govuk-accordion__section-button");

        // end YC3 //

        //elt added - View Description..
        private By courseDescriptionTitle = By.ClassName("govuk-caption-l");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");
        private By courseDescriptionPopup = By.Id("popup-descript");

        private By courseFor = By.Id("popup-descript-0");
        private By entryRequirements = By.Id("popup-entry-reqs-0");
        private By whatWillLearn = By.Id("popup-what-learn-0");
        private By howWillLearn = By.Id("popup-how-learn-0");
        private By equipmentNeeded = By.Id("popup-what-bring-0");
        private By howAssessed = By.Id("popup-how-assessed-0");
        private By nextSteps = By.Id("popup-next-0");
        private By diplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");

        private By MainDiplomaDetailLink = By.XPath("//*[@id='main-content']/div/div/div[2]/div/h2[1]");
        private By CourseDetailLink = By.XPath("  //*[@id='main-content']/div/div/div[2]/div/div[1]/ul[1]/li[1]/h3");

        private By closeViewCourseDescriptionPopup = By.Id("popup-descript-close");   


        private By ClickViewURLLink = By.Id("URLLink");
        private By ViewCourseURLText = By.Id("courseRun_CourseURL");
        private By ClickURLClose = By.LinkText("Close");
        private By ClickCostDescriptionLink = By.Id("CostDetailLink");
        private By ViewCostDescriptionText = By.Id("courseRun_CostDescription");
        private By ClickCostDescriptionClose = By.LinkText("Close");
        public By accordianMainOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[*]/div/div/h2");
        private By accordianQualOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[*]/div[1]/div/div/h3");

        private By firstCourseRunsCount = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/form/span");
        private By courseRunRowXPath = By.XPath("//*[contains(@class,'govuk-grid-row course-run-container')]");
        static int countOfRunsShown;
        static int mainCourseRunCount;

        private By DiplomaAccordianLink = By.XPath("//*[@id='adminContent']/div[1]/div[1]/i");


        //Shivani added - Line2

        private By openInnerchevron = By.CssSelector("h3.accordion.govuk-heading-l:nth-of-type(1).active");
        private By openchevron = By.CssSelector("h2.accordion.govuk-heading-l:nth-of-type(1).active");

        //private By verifyCourseTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[1]/label");
        private By verifyCourseTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[1]/label");

        //private By CourseTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.large:nth-of-type(1) input");

        //private By verifyIDTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[2]/label");
        private By verifyIDTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[2]/label");
        // private By IDTitleInputBox = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(2) input");

        //private By verifyDeliveryTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[3]/label");
        private By verifyDeliveryTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[3]/label");
        //private By deliveryTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(3) select#deliveryMode");

        //private By verifyStartDateTitle = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(4) label.govuk-label");
        //private By startDateTitleInputBox = By.XPath("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[4]/div");

        //private By verifyVenueTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[5]/label");
        private By verifyVenueTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[5]/label");
        //private By venueTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium:nth-of-type(5) select#VenueId");

        //private By verifyURLTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[6]/label");
        private By verifyURLTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[6]/label");
        //private By urlTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#URLLink");

        //private By verifyCostTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[7]/div/label");
        private By verifyCostTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[7]/div/label");
        //private By costTitleInputBox = By.CssSelector("//*[@id='course - run - 38c66b31 - 812e-4fa0 - bd18 - 13b916ba0fba']/div[7]/input");

        //private By verifyCostDescriptionTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[8]/label");
        private By verifyCostDescriptionTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[8]/label");
        //private By costDescriptionTitleHyperLink = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.popUpContainer a#CostDetailLink");

        //private By verifyDurationTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[9]/label");
        private By verifyDurationTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[9]/label");
        // private By durationTitleInputBox = By.CssSelector("//*[@id='courseRun_DurationValue']");

        //private By verifyDurationUnitTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[10]/label");
        private By verifyDurationUnitTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[10]/label");
        //private By durationUnitTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#durationUnit");

        //private By verifyAttendanceTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[11]/label");
        private By verifyAttendanceTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[11]/label");
        //private By attendanceTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#attendance");

        //private By verifyModeTitle = By.XPath("//*[@id='course-run-3be8ddb1-2ea8-48f8-978d-719e6c673e24']/div/div[12]/label");
        private By verifyModeTitle = By.XPath("//*[starts-with(@id, 'course-run')]/div/div[12]/label");
        //private By modeTitleDropDown = By.CssSelector("li#course-run-38c66b31-812e-4fa0-bd18-13b916ba0fba div.medium select#mode");


        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            if (!PageInteractionHelper.IsElementPresent(successMsg))
            {
                SelfVerify();
            }           
        }

        internal void ClickCloseCostDescription()
        {
            FormCompletionHelper.ClickElement(ClickCostDescriptionClose);
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
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

        internal void ClickMainDiplomaDetail()
        {
            PageInteractionHelper.OpenAccordians(accordianMainOpenIconXPath);
        }
        internal void ClickCourseDetailLink()
        {
            PageInteractionHelper.OpenAccordians(accordianQualOpenIconXPath);
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


        internal void clickChevron()
        {
            FormCompletionHelper.ClickElement(openchevron);
            Thread.Sleep(2000);

        }

        internal void clickInnerChevron()
        {
            FormCompletionHelper.ClickElement(openInnerchevron);
            Thread.Sleep(2000);
        }


        internal void courseNameLabelText(string courseLabel)
        {
            if (courseLabel == "Course name")
            {
                PageInteractionHelper.VerifyText(verifyCourseTitle, "Course name");
                //PageInteractionHelper.IsElementPresent(CourseTitleInputBox);

            }
            if (courseLabel == "ID")
            {
                PageInteractionHelper.VerifyText(verifyIDTitle, "ID");
                //PageInteractionHelper.IsElementPresent(IDTitleInputBox);
            }
            if (courseLabel == "Delivery")
            {
                PageInteractionHelper.VerifyText(verifyDeliveryTitle, courseLabel);

            }

            /*if (courseLabel == "Start Date")
            {
                PageInteractionHelper.VerifyText(verifyStartDateTitle, courseLabel);
                PageInteractionHelper.IsElementPresent(startDateTitleInputBox);
            }*/

            if (courseLabel == "Venue")
            {
                PageInteractionHelper.VerifyText(verifyVenueTitle, courseLabel);
            }
            if (courseLabel == "Cost")
            {
                PageInteractionHelper.VerifyText(verifyCostTitle, courseLabel);
                //PageInteractionHelper.IsElementPresent(costTitleInputBox);
            }
            if (courseLabel == "Duration")
            {
                PageInteractionHelper.VerifyText(verifyDurationTitle, courseLabel);
                //PageInteractionHelper.IsElementPresent(durationTitleInputBox);
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



        internal void StoreLiveCourseRunCount()
        {

            String mainTotal = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            String mainTotalString = mainTotal.Replace(")", "").Replace("(", "").Replace(" ", "");

            try
            {
                mainCourseRunCount = Int32.Parse(mainTotalString);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Main run count: " + mainCourseRunCount);
        }




        public void CompareTotals()
        {
            //Compare the 2 run totals are the same
            if (!mainCourseRunCount.Equals(countOfRunsShown))
            {
                Assert.Fail("Total runs shown doesn't match total at top of page");
            }
            else if (mainCourseRunCount.Equals(countOfRunsShown))
            {
                Console.WriteLine("Totals Match OK");
            }

        }


        public void OpenMainAccordians()
        {

            PageInteractionHelper.OpenAccordians(accordianMainOpenIconXPath);

        }

        public void OpenQualificationAccordians()
        {

            PageInteractionHelper.OpenAccordians(accordianQualOpenIconXPath);

        }

        public void CountUpAllCourseRunsShown()
        {
            //add up number of course run rows displayed
            IList<IWebElement> courseRunRows = webDriver.FindElements(courseRunRowXPath);
            countOfRunsShown = courseRunRows.Count();

            Console.WriteLine("Counted Runs: " + countOfRunsShown);


        }



        //  YC3  //
    

        public void OpenAllQualificationsYC3()
        {
        
            PageInteractionHelper.OpenAccordians(qualificationTitles);
            Console.WriteLine("Open qualifications");

        }


        public void OpenAllCourseRunsYC3()
        {

            PageInteractionHelper.OpenAccordians(courseRunTitles);
            Console.WriteLine("Open course runs");

        }


        // end YC3 //



        /*internal void checkDropDownBoxes(string dropDown)
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
        }*/

    }
}

