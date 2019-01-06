using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCoursePage2 : BasePage
    {
        private static String PAGE_TITLE = "Add course details";
        private By qualification = By.Id("qual--");
        private By courseName = By.Id("CourseName");
        private By courseNameError = By.Id("CourseName-error");
        private By courseId = By.Id("CourseProviderReference");
        private By courseIdError = By.Id("CourseProviderReference-error");
        private By courseURL = By.Id("Url");
        private By courseURLError = By.Id("Url-error");
        private By courseCost = By.Id("Cost");
        private By courseCostError = By.Id("Cost-error");
        private By courseCostInvalidLength = By.Id("invalidCostLengthMessage");
        private By courseCostInvalid = By.Id("invalidCostMessage");
        private By costDescription = By.Id("CostDescription");
        private By costDescriptionError = By.Id("CostDescription-error");
        private By costDescriptionInfo = By.Id("CostDescription-info");
        private By attendanceMode = By.Id("AttendanceMode");
        private By studyMode = By.Id("StudyMode");
        private By advancedLearnerLoan = By.Id("AdvancedLearnerLoan");
        private By publishBtn = By.Id("publish");
        private By StartDateRadio = By.Id("SpecifiedStartDate");
        private By StartDateType = By.Name("StartDateType");
        private By DateDD = By.Id("Day");
        private By DayError = By.Id("invalidDayMessage");
        private By DateMM = By.Id("Month");
        private By MonthError = By.Id("invalidMonthMessage");
        private By DateCCYY = By.Id("Year");
        private By YearError = By.Id("invalidYearMessage");
        private By StartDateRequiredError = By.Id("requiredMessage");
        private By PasttDateError = By.Id("pastMessage");
        private By FutureDateError = By.Id("futureMessage");
        private By InvalidDateError = By.Id("invalidMessage");
        private By FlexDateRadio = By.Id("FlexibleStartDate");
        private By DurationLength = By.Id("DurationLength");
        private By DurationUnit = By.Id("Id");
        private By DurationError = By.Id("DurationLength-error");

        private string errortxt;

        public AddCoursePage2(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public AddCoursePage2 GetQualifiactionDetails()
        {
            string[] qualificationDetails = webDriver.FindElement(qualification).GetAttribute("textContent").Split(':');
            Console.WriteLine("qualification added: " + qualificationDetails[1].Split(' ')[1]);
            Console.WriteLine("level: " + qualificationDetails[2].Split(' ')[1]);
            Console.WriteLine("awarding organisation: " + qualificationDetails[3].Split(' ')[1]);
            Console.WriteLine("LARS/QAN: " + qualificationDetails[4]);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 EnterCourseName(String name)
        {
            FormCompletionHelper.EnterText(courseName, name);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 CourseNameErrorNotDisplayed()
        {
            PageInteractionHelper.IsElementDisplayed(courseNameError);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 CourseNameErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseNameError);
            PageInteractionHelper.IsElementDisplayed(courseNameError);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 EnterCourseId(String courseid)
        {
            FormCompletionHelper.EnterText(courseId, courseid);
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 CourseIDErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseIdError);
            PageInteractionHelper.IsElementDisplayed(courseIdError);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 EnterCourseURL(String url)
        {
            FormCompletionHelper.EnterText(courseURL, url);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 CourseURLErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseURLError);
            PageInteractionHelper.IsElementDisplayed(courseURLError);
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 ConfirmErrorMessage(string field, string errorMsg)
        {
            switch (field)
            {
                case "URL":
                    PageInteractionHelper.WaitForElementToBePresent(courseURLError);
                    PageInteractionHelper.IsElementDisplayed(courseURLError);
                    errortxt = webDriver.FindElement(courseURLError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Course Name":
                    PageInteractionHelper.WaitForElementToBePresent(courseNameError);
                    PageInteractionHelper.IsElementDisplayed(courseNameError);
                    errortxt = webDriver.FindElement(courseNameError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostError);
                    PageInteractionHelper.IsElementDisplayed(courseCostError);
                    errortxt = webDriver.FindElement(courseCostError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Cost Length":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalidLength);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalidLength);
                    errortxt = webDriver.FindElement(courseCostInvalidLength).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalid);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalid);
                    errortxt = webDriver.FindElement(courseCostInvalid).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Course ID":
                    PageInteractionHelper.WaitForElementToBePresent(courseIdError);
                    PageInteractionHelper.IsElementDisplayed(courseIdError);
                    errortxt = webDriver.FindElement(courseIdError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Cost Description":
                    PageInteractionHelper.WaitForElementToBePresent(costDescriptionError);
                    PageInteractionHelper.IsElementDisplayed(costDescriptionError);
                    errortxt = webDriver.FindElement(costDescriptionError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Day":
                    PageInteractionHelper.WaitForElementToBePresent(DayError);
                    PageInteractionHelper.IsElementDisplayed(DayError);
                    errortxt = webDriver.FindElement(DayError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Month":
                    PageInteractionHelper.WaitForElementToBePresent(MonthError);
                    PageInteractionHelper.IsElementDisplayed(MonthError);
                    errortxt = webDriver.FindElement(MonthError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Year":
                    PageInteractionHelper.WaitForElementToBePresent(YearError);
                    PageInteractionHelper.IsElementDisplayed(YearError);
                    errortxt = webDriver.FindElement(YearError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Start Date":
                    PageInteractionHelper.WaitForElementToBePresent(StartDateRequiredError);
                    PageInteractionHelper.IsElementDisplayed(StartDateRequiredError);
                    errortxt = webDriver.FindElement(StartDateRequiredError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Past Date":
                    PageInteractionHelper.WaitForElementToBePresent(PasttDateError);
                    PageInteractionHelper.IsElementDisplayed(PasttDateError);
                    errortxt = webDriver.FindElement(PasttDateError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Future Date":
                    PageInteractionHelper.WaitForElementToBePresent(FutureDateError);
                    PageInteractionHelper.IsElementDisplayed(FutureDateError);
                    errortxt = webDriver.FindElement(FutureDateError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Date":
                    PageInteractionHelper.WaitForElementToBePresent(InvalidDateError);
                    PageInteractionHelper.IsElementDisplayed(InvalidDateError);
                    errortxt = webDriver.FindElement(InvalidDateError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Duration":
                    PageInteractionHelper.WaitForElementToBePresent(DurationError);
                    PageInteractionHelper.IsElementDisplayed(DurationError);
                    errortxt = webDriver.FindElement(DurationError).GetAttribute("innerText");
                    if (errorMsg != errortxt)
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");
            }
        }

        public AddCoursePage2 EnterCourseCost(string cost)
        {
            FormCompletionHelper.EnterText(courseCost, cost);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 CourseCostErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseCostError);
            PageInteractionHelper.IsElementDisplayed(courseCostError);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 EnterCostDescription(String costdescription)
        {
            FormCompletionHelper.EnterText(costDescription, costdescription);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 CostDescriptionErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(costDescriptionError);
            PageInteractionHelper.IsElementDisplayed(costDescriptionError);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 ConfirmInfoMessage(string field, string infoMsg)
        {
            switch (field)
            {
                case "Cost Description":
                    PageInteractionHelper.WaitForElementToBePresent(costDescriptionInfo);
                    PageInteractionHelper.IsElementDisplayed(costDescriptionInfo);
                    errortxt = webDriver.FindElement(costDescriptionInfo).GetAttribute("innerText");
                    if (infoMsg != errortxt)
                    {
                        throw new Exception("Incorrect Info message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");

            }
        }

        public AddCoursePage2 SelectAttendance(string attendance)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(FlexDateRadio, attendance);
            return new AddCoursePage2(webDriver);
        }
        
        public AddCoursePage2 SelectStudyMode(string studymode)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(studyMode, studymode);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 SelectAdvancedLearnerLoan()
        {
            FormCompletionHelper.SelectCheckBox2(advancedLearnerLoan);
            return new AddCoursePage2(webDriver);
        }
        
        public AddCoursePage2 SelectStartDateType(string StartDate)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(StartDateType, StartDate);
            return new AddCoursePage2(webDriver);
        }
        
        public AddCoursePage2 EnterStartDate(string value, string field)
        {
            switch (field)
            {
                case "Day":
                    FormCompletionHelper.EnterText(DateDD, value);
                    return new AddCoursePage2(webDriver);

                case "Month":
                    FormCompletionHelper.EnterText(DateMM, value);
                    return new AddCoursePage2(webDriver);

                case "Year":
                    FormCompletionHelper.EnterText(DateCCYY, value);
                    return new AddCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");

            }
        }

        public AddCoursePage2 EnterDuration (String length)
        {
            FormCompletionHelper.EnterText(DurationLength, length);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 SelectDurationUnit (String unit)
        {
            FormCompletionHelper.SelectFromDropDownByText((webDriver.FindElement(DurationUnit)), unit);
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 PublishCourse()
        {
            FormCompletionHelper.ClickElement(publishBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage2(webDriver);
        }


    }
}