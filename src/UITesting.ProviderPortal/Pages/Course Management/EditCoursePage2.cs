using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using System.Diagnostics;
using UITesting.ProviderPortal.Pages.Bulk_Upload;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class EditCoursePage2 : BasePage
    {
        //page objects
        private static String PAGE_TITLE = "Edit course details";
        private By qualification = By.Id("qual--");
        private By courseName = By.Id("CourseName");
        private By courseNameError = By.XPath(".//*[@id='courseNameContainer']/span[1]");           
        private By courseId = By.Id("CourseProviderReference");
        private By courseIdError = By.XPath(".//*[@id='sectionCourseProviderReference']/div/span[1]");     
        private By courseURL = By.Id("Url");
        private By courseURLError = By.XPath(".//*[@id='sectionUrl']/div/span[1]");                         
        private By courseCost = By.Id("Cost");
        private By courseCostError = By.XPath(".//*[@id='costContainer']/span[1]");                         
        private By courseCostInvalidLength = By.XPath(".//*[@id='costContainer']/span[3]");
        private By courseCostInvalid = By.XPath(".//*[@id='costContainer']/span[1]");
        private By costDescription = By.Id("CostDescription");
        private By costDescriptionError = By.XPath(".//*[@id='sectionCost']/div[2]/div/span[2]");            
        private By costDescriptionInfo = By.Id("CostDescription-info");
        private By attendanceMode = By.Id("AttendanceMode");
        private By studyMode = By.Id("StudyMode");
        private By advancedLearnerLoan = By.Id("AdvancedLearnerLoan");
        private By saveBtn = By.Id("save");
        private By StartDateRadio = By.Id("SpecifiedStartDate");
        private By StartDateType = By.Name("StartDateType");
        private By DateDD = By.Id("Day");
        private By DayError = By.Id("invalidDayMessage");
        private By DateMM = By.Id("Month");
        private By MonthError = By.Id("invalidMonthMessage");
        private By DateCCYY = By.Id("Year");
        private By YearError = By.Id("invalidYearMessage");
        private By StartDateRequiredError = By.XPath(".//*[@id='startDateFormGroup']/span");        
        private By PasttDateError = By.XPath(".//*[@id='startDateFormGroup']/span");                
        private By FutureDateError = By.XPath(".//*[@id='startDateFormGroup']/span");               
        private By InvalidDateError = By.XPath(".//*[@id='startDateFormGroup']/span");              
        private By FlexDateRadio = By.Id("FlexibleStartDate");
        private By DurationLength = By.Id("DurationLength");
        private By DurationUnit = By.Id("durationDropDown");
        private By DurationError = By.XPath(".//*[@id='sectionDuration']/div/span[2]");              
        private By FirstVenue = By.Id("VenueName-1");
        private By SecondVenue = By.Id("VenueName-2");
        private By VenueDropdown = By.Id("VenueId");
        private By CancelLink = By.XPath(".//*[@id='editCourseRun']/ul/li[2]/a");       
        private By SaveBtn = By.Id("save");
        private By selectOnline = By.Id("Online");
        private By selectVenueOption = By.Id("VenueItemsCheckboxList");
        private By selectTimeOption = By.Id("time");
        private By selectModeOption = By.Id("mode");
        private By flexibleStartDateOption = By.Id("FlexibleStartDate");
        private By venueSelector = By.Id("VenueItemsCheckboxList");
        private By fullPartTimeButtons = By.Id("FullPartTimeRadioButtons");
        private By attendancePatternButtons = By.Id("AttendancePatternRadioButtons");
        private By workBasedOptionButton = By.Id("WorkBased");
        private By courseRegionSelector = By.Id("RegionItemsCheckboxList");
        private By courseRegionSelectorFirstField = By.Id("RegionName-1");
        private By firstRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[1]/summary");
        private By nationalTrue = By.Id("nationalTrue");
        private By nationalFalse = By.Id("nationalFalse");
        private By nationalError = By.XPath(".//*[@id='sectionRegions']/div/div/div[1]/fieldset/span");


        //variables
        private string errortxt;

        public EditCoursePage2(IWebDriver webDriver) : base(webDriver)
        {

            SelfVerify();
        }

        public EditCoursePage2 clickOnline()
        {
            FormCompletionHelper.ClickElement(selectOnline);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 selectVenueIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectVenueOption);
            PageInteractionHelper.IsElementDisplayed(selectVenueOption);
            Debug.WriteLine("I can see Select Venue Field before clicking Online option");
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 timeIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectTimeOption);
            PageInteractionHelper.IsElementDisplayed(selectTimeOption);
            Debug.WriteLine("I can see Full Time Part Time field before clicking Online option");
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 modeIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectModeOption);
            PageInteractionHelper.IsElementDisplayed(selectModeOption);
            Debug.WriteLine("I can Attendance field before clicking Online option");
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 selectVenueIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectVenueOption);
            Debug.WriteLine("I cannot see Select Venue field after clicking Online option");
            return new EditCoursePage2(webDriver);
        }
        public EditCoursePage2 timeIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectTimeOption);
            Debug.WriteLine("I cannot see Full Time Part Time field after clicking Online option");
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 modeIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectModeOption);
            Debug.WriteLine("I cannot see Mode field after clicking Online option");
            return new EditCoursePage2(webDriver);
        }



        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            webDriver.FindElementWait(courseName, 60);
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }


        public EditCoursePage2 GetQualifiactionDetails()
        {
            string[] qualificationDetails = webDriver.FindElement(qualification).GetAttribute("textContent").Split(':');
            Console.WriteLine("qualification added: " + qualificationDetails[1].Split(' ')[1]);
            Console.WriteLine("level: " + qualificationDetails[2].Split(' ')[1]);
            Console.WriteLine("awarding organisation: " + qualificationDetails[3].Split(' ')[1]);
            Console.WriteLine("LARS/QAN: " + qualificationDetails[4]);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 EnterCourseName(String name)
        {
            FormCompletionHelper.EnterText(courseName, name);
            return new EditCoursePage2(webDriver);
        }


        public EditCoursePage2 CourseNameErrorNotDisplayed()
        {
            PageInteractionHelper.IsElementDisplayed(courseNameError);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 CourseNameErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseNameError);
            PageInteractionHelper.IsElementDisplayed(courseNameError);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 EnterCourseId(String courseid)
        {
            FormCompletionHelper.EnterText(courseId, courseid);
            return new EditCoursePage2(webDriver);
        }


        public EditCoursePage2 CourseIDErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseIdError);
            PageInteractionHelper.IsElementDisplayed(courseIdError);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 EnterCourseURL(String url)
        {
            FormCompletionHelper.EnterText(courseURL, url);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 CourseURLErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseURLError);
            PageInteractionHelper.IsElementDisplayed(courseURLError);
            return new EditCoursePage2(webDriver);
        }


        public BulkUploadFixPublishPage ClickCancelBU()
        {
            FormCompletionHelper.ClickElement(CancelLink);
            return new BulkUploadFixPublishPage(webDriver);
        }

        public DQIFixPublishPage ClickCancelDQI()
        {
            FormCompletionHelper.ClickElement(CancelLink);
            return new DQIFixPublishPage(webDriver);
        }


        public BulkUploadPublishPage ClickSaveBURun()
        {
            FormCompletionHelper.ClickElement(SaveBtn);
            PageInteractionHelper.WaitForPageToLoad(20);
            return new BulkUploadPublishPage(webDriver);
        }


        public EditCoursePage2 ConfirmErrorMessage(string field, string errorMsg)
        {
            switch (field)
            {
                case "URL":
                    PageInteractionHelper.WaitForElementToBePresent(courseURLError);
                    PageInteractionHelper.IsElementDisplayed(courseURLError);
                    errortxt = webDriver.FindElement(courseURLError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Course Name":
                    PageInteractionHelper.WaitForElementToBePresent(courseNameError);
                    PageInteractionHelper.IsElementDisplayed(courseNameError);
                    errortxt = webDriver.FindElement(courseNameError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostError);
                    PageInteractionHelper.IsElementDisplayed(courseCostError);
                    errortxt = webDriver.FindElement(courseCostError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Invalid Cost Length":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalidLength);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalidLength);
                    errortxt = webDriver.FindElement(courseCostInvalidLength).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Invalid Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalid);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalid);
                    errortxt = webDriver.FindElement(courseCostInvalid).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Course ID":
                    PageInteractionHelper.WaitForElementToBePresent(courseIdError);
                    PageInteractionHelper.IsElementDisplayed(courseIdError);
                    errortxt = webDriver.FindElement(courseIdError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Cost Description":
                    PageInteractionHelper.WaitForElementToBePresent(costDescriptionError);
                    PageInteractionHelper.IsElementDisplayed(costDescriptionError);
                    errortxt = webDriver.FindElement(costDescriptionError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Day":
                    PageInteractionHelper.WaitForElementToBePresent(DayError);
                    PageInteractionHelper.IsElementDisplayed(DayError);
                    errortxt = webDriver.FindElement(DayError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Month":
                    PageInteractionHelper.WaitForElementToBePresent(MonthError);
                    PageInteractionHelper.IsElementDisplayed(MonthError);
                    errortxt = webDriver.FindElement(MonthError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Year":
                    PageInteractionHelper.WaitForElementToBePresent(YearError);
                    PageInteractionHelper.IsElementDisplayed(YearError);
                    errortxt = webDriver.FindElement(YearError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Start Date":
                    PageInteractionHelper.WaitForElementToBePresent(StartDateRequiredError);
                    PageInteractionHelper.IsElementDisplayed(StartDateRequiredError);
                    errortxt = webDriver.FindElement(StartDateRequiredError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Past Date":
                    PageInteractionHelper.WaitForElementToBePresent(PasttDateError);
                    PageInteractionHelper.IsElementDisplayed(PasttDateError);
                    errortxt = webDriver.FindElement(PasttDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Future Date":
                    PageInteractionHelper.WaitForElementToBePresent(FutureDateError);
                    PageInteractionHelper.IsElementDisplayed(FutureDateError);
                    errortxt = webDriver.FindElement(FutureDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Invalid Date":
                    PageInteractionHelper.WaitForElementToBePresent(InvalidDateError);
                    PageInteractionHelper.IsElementDisplayed(InvalidDateError);
                    errortxt = webDriver.FindElement(InvalidDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                case "Duration":
                    PageInteractionHelper.WaitForElementToBePresent(DurationError);
                    PageInteractionHelper.IsElementDisplayed(DurationError);
                    errortxt = webDriver.FindElement(DurationError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new EditCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");
            }
        }

        public EditCoursePage2 EnterCourseCost(string cost)
        {
            //FormCompletionHelper.ClearContents(courseCost);
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.EnterText(courseCost, cost);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 CourseCostErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseCostError);
            PageInteractionHelper.IsElementDisplayed(courseCostError);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 EnterCostDescription(String costdescription)
        {
            FormCompletionHelper.EnterText(costDescription, costdescription);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 CostDescriptionErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(costDescriptionError);
            PageInteractionHelper.IsElementDisplayed(costDescriptionError);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 ConfirmInfoMessage(string field, string infoMsg)
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
                    return new EditCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");

            }
        }

        public EditCoursePage2 SelectAttendance(string attendance)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(FlexDateRadio, attendance);
            return new EditCoursePage2(webDriver);
        }
        
        public EditCoursePage2 SelectStudyMode(string studymode)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(studyMode, studymode);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 SelectAdvancedLearnerLoan()
        {
            FormCompletionHelper.SelectCheckBox2(advancedLearnerLoan);
            return new EditCoursePage2(webDriver);
        }
        
        public EditCoursePage2 SelectStartDateType(string StartDate)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(StartDateType, StartDate);
            return new EditCoursePage2(webDriver);
        }
        
        public EditCoursePage2 EnterStartDate(string value, string field)
        {
            switch (field)
            {
                case "Day":
                    FormCompletionHelper.EnterText(DateDD, value);
                    return new EditCoursePage2(webDriver);

                case "Month":
                    FormCompletionHelper.EnterText(DateMM, value);
                    return new EditCoursePage2(webDriver);

                case "Year":
                    FormCompletionHelper.EnterText(DateCCYY, value);
                    return new EditCoursePage2(webDriver);

                default:
                    throw new Exception("Field does not exist");

            }
        }

        public EditCoursePage2 EnterDuration (String length)
        {
            FormCompletionHelper.EnterText(DurationLength, length);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 SelectDurationUnit (String unit)
        {
            FormCompletionHelper.SelectFromDropDownByText((webDriver.FindElement(DurationUnit)), unit);
            return new EditCoursePage2(webDriver);
        }

        public EditYourCoursePage SaveCourse()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new EditYourCoursePage(webDriver);
        }

        public EditCoursePage2 SaveCourseError()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 SelectFirstVenue()
        {
            if (webDriver.GetType().Name.ToString().Contains("RemoteWebDriver"))
            {
                //System.Threading.Thread.Sleep(1000);
                PageInteractionHelper.WaitForPageToLoad();
                webDriver.FindElementWait(FirstVenue, 60);
                var element = this.webDriver.FindElement(FirstVenue);
                ((IJavaScriptExecutor)this.webDriver).ExecuteScript("arguments[0].click();", element);
            }
            else
            {
                PageInteractionHelper.WaitForPageToLoad();
                FormCompletionHelper.SelectCheckBox2(FirstVenue);
            }

            PageInteractionHelper.WaitForPageToLoad();
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 SelectSecondVenue()
        {
            FormCompletionHelper.SelectCheckBox2(SecondVenue);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 SelectVenue(string venue)
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.SelectFromDropDownByText(webDriver.FindElement(VenueDropdown), venue);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 clickWorkBasedRadioButton()
        {
            FormCompletionHelper.ClickElement(workBasedOptionButton);
            Debug.WriteLine("Selected Work Based Option");
            return new EditCoursePage2(webDriver);
        }


        public EditCoursePage2 verifyFlexibleStartDateSelected()
        {
            FormCompletionHelper.IsObjectSelected(flexibleStartDateOption);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 verifyVenueSelectionNotShown()
        {
            FormCompletionHelper.VerifyElementNotPresent(selectVenueOption);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 verifyAttendancePatternButtonsnotShown()
        {
            FormCompletionHelper.VerifyElementNotPresent(attendancePatternButtons);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 verifyFullPartTimeButtonsNotShown() //mode: fulltime or part time
        {
            FormCompletionHelper.VerifyElementNotPresent(fullPartTimeButtons);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 verifyCourseRegionIsShown()
        {
            FormCompletionHelper.IsElementPresent(courseRegionSelector);
            return new EditCoursePage2(webDriver);
        }

        public EditCoursePage2 verifySaveButton()
        {
            FormCompletionHelper.IsElementPresent(SaveBtn);
            return new EditCoursePage2(webDriver);
        }


        public EditCoursePage2 clickNationalTrue()
        {
            if (webDriver.FindElement(nationalTrue).GetAttribute("checked") != "false")
            {
                FormCompletionHelper.ClickElement(nationalTrue);
                return new EditCoursePage2(webDriver);
            }
            else
            {
                throw new Exception("National flag already set to True");
            }
        }


        public EditCoursePage2 clickNationalFalse()
        {
            if (webDriver.FindElement(nationalFalse).GetAttribute("checked") != "false")
            {
                FormCompletionHelper.ClickElement(nationalFalse);
                return new EditCoursePage2(webDriver);
            }
            else
            {
                throw new Exception("National flag already set to false");
            }
        }

        public EditCoursePage2 selectFirstOptionOnRegionSelector()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(firstRegion);
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(courseRegionSelectorFirstField);
            return new EditCoursePage2(webDriver);
        }

    }
}