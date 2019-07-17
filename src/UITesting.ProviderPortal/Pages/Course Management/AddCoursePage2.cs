using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Collections.Generic;

namespace UITesting.ProviderPortal.Pages.Course_Management
{
    public class AddCoursePage2 : BasePage
    {
        //page objects
        private static String PAGE_TITLE = "Add course details";
        private By qualification = By.Id("qual--");
        private By courseName = By.Id("CourseName");
        private By courseNameError = By.XPath(".//*[@id='courseNameContainer']/span[1]");                 
        private By courseId = By.Id("CourseProviderReference");
        private By courseIdError = By.XPath(".//*[@id='sectionCourseProviderReference']/div/span[1]");    
        private By courseURL = By.Id("Url");
        private By courseURLError = By.XPath(".//*[@id='sectionUrl']/div/span[1]");                       //*[@id="sectionUrl"]/div/span[1] 
        private By courseCost = By.Id("Cost");
        private By courseCostError = By.XPath(".//*[@id='costContainer']/span[1]");                       
        private By courseCostInvalidLength = By.XPath(".//*[@id='costContainer']/span[1]");
        private By courseCostInvalid = By.XPath(".//*[@id='costContainer']/span[1]");
        private By costDescription = By.Id("CostDescription");
        private By costDescriptionError = By.XPath(".//*[@id='sectionCost']/div[2]/div/span[2]");          
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
        private By StartDateRequiredError = By.XPath(".//*[@id='startDateFormGroup']/span");        
        private By PasttDateError = By.XPath(".//*[@id='startDateFormGroup']/span");                
        private By FutureDateError = By.XPath(".//*[@id='startDateFormGroup']/span");               
        private By InvalidDateError = By.XPath(".//*[@id='startDateFormGroup']/span");              
        private By FlexDateRadio = By.Id("FlexibleStartDate");
        private By DurationLength = By.Id("DurationLength");
        private By DurationUnit = By.Id("durationDropDown");
        private By DurationError = By.XPath(".//*[@id='sectionDuration']/div/span[2]");
        private By Page1Link = By.Id("goToSection1Link");
        

        private By FirstVenue = By.Id("VenueName-1");
        private By SecondVenue = By.Id("VenueName-2");
        private By DeliveryMode = By.Name("DeliveryMode");
        private By HeaderErrMessage = By.XPath("//*[@id='error-summary-title']");
        private By HeaderErrSummMessage = By.XPath("//*[@id='error-hash-link-Url-0']");
        private By selectOnline = By.Id("Online");
        private By selectVenueOption = By.Id("VenueItemsCheckboxList");
        private By selectTimeOption = By.Id("time");
        private By selectModeOption = By.Id("mode");
        private By flexibleStartDateOption = By.Id("FlexibleStartDate");
        private By venueSelector = By.Id("VenueItemsCheckboxList");
        private By fullPartTimeButtons = By.Id("FullPartTimeRadioButtons");
        private By attendancePatternButtons = By.Id("AttendancePatternRadioButtons");
        private By workBasedOptionButton = By.Id("WorkBased");
        private By regionError = By.XPath(".//*[@id='regions-section']/span[2]");
        private By firstRegion = By.XPath(".//*[@id='SelectRegionCheckBoxes']/details[1]/summary");
        private By courseRegionSelector = By.Id("RegionItemsCheckboxList");
        private By courseRegionSelectorFirstField = By.Id("RegionName-1");
        private By nationalTrue = By.XPath(".//*[@id='nationalRadioButtons']/div[1]/label");       //By.Id("National_true");
        private By nationalFalse = By.XPath(".//*[@id='nationalRadioButtons']/div[2]/label");      //By.Id("National_false"); 
        private By nationalError = By.XPath(".//*[@id='sectionRegions']/div/div/div[1]/fieldset/span");
        private By AddNewVenueLink = By.Id("addNewVenue");
        //variable
        private string errortxt;

        public AddCoursePage2(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        internal void SelectCheckBoxByValue(string strVenueName)
        {
            IList<IWebElement> CheckBoxList = webDriver.FindElements((By.ClassName("govuk-checkboxes__item"))); 
            
            int count = CheckBoxList.Count;
            for(int i=0;i<=count; i++)
            {
                if (CheckBoxList[i].Text ==strVenueName)
                {
                    int VenueId = i + 1;
                    string VenueName = "VenueName-" + VenueId;
                    webDriver.FindElement(By.Id(VenueName)).Click();
                    break;
                }
            }
        }

        internal void ClickAddNewVenueLink()
        {
            FormCompletionHelper.ClickElement(AddNewVenueLink);
            PageInteractionHelper.WaitForPageToLoad();
        }

        public AddCoursePage2 clickOnline()
        {
            FormCompletionHelper.ClickElement(selectOnline);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 selectVenueIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectVenueOption);
            PageInteractionHelper.IsElementDisplayed(selectVenueOption);
            Debug.WriteLine("I can see Select Venue Field before clicking Online option");
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 timeIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectTimeOption);
            PageInteractionHelper.IsElementDisplayed(selectTimeOption);
            Debug.WriteLine("I can see Full Time Part Time field before clicking Online option");
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 modeIsDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(selectModeOption);
            PageInteractionHelper.IsElementDisplayed(selectModeOption);
            Debug.WriteLine("I can Attendance field before clicking Online option");
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 selectVenueIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectVenueOption);
            Debug.WriteLine("I cannot see Select Venue field after clicking Online option");
            return new AddCoursePage2(webDriver);
        }
        public AddCoursePage2 timeIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectTimeOption);
            Debug.WriteLine("I cannot see Full Time Part Time field after clicking Online option");
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 modeIsNotDisplayed()
        {
            PageInteractionHelper.VerifyElementNotPresent(selectModeOption);
            Debug.WriteLine("I cannot see Mode field after clicking Online option");
            return new AddCoursePage2(webDriver);
        }



        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
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

        internal void ValidateHeaderMessage(string strHeaderMessage)
        {
            FormCompletionHelper.VerifyText(HeaderErrMessage, strHeaderMessage);
        }

        public AddCoursePage2 CourseURLErrorDisplayed()
        {
            PageInteractionHelper.WaitForElementToBePresent(courseURLError);
            PageInteractionHelper.IsElementDisplayed(courseURLError);
            return new AddCoursePage2(webDriver);
        }

        internal void ValidateHeaderErrorSummary(string strHeaderErrorSumm)
        {
            FormCompletionHelper.VerifyText(HeaderErrSummMessage, strHeaderErrorSumm);
        }

        public AddCoursePage2 ConfirmErrorMessage(string field, string errorMsg)
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
                    return new AddCoursePage2(webDriver);

                case "Course Name":
                    PageInteractionHelper.WaitForElementToBePresent(courseNameError);
                    PageInteractionHelper.IsElementDisplayed(courseNameError);
                    errortxt = webDriver.FindElement(courseNameError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "National Check":
                    PageInteractionHelper.WaitForElementToBePresent(nationalError);
                    PageInteractionHelper.IsElementDisplayed(nationalError);
                    errortxt = webDriver.FindElement(nationalError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Sub Region":
                    PageInteractionHelper.WaitForElementToBePresent(regionError);
                    PageInteractionHelper.IsElementDisplayed(regionError);
                    errortxt = webDriver.FindElement(regionError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostError);
                    PageInteractionHelper.IsElementDisplayed(courseCostError);
                    errortxt = webDriver.FindElement(courseCostError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Cost Length":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalidLength);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalidLength);
                    errortxt = webDriver.FindElement(courseCostInvalidLength).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Cost":
                    PageInteractionHelper.WaitForElementToBePresent(courseCostInvalid);
                    PageInteractionHelper.IsElementDisplayed(courseCostInvalid);
                    errortxt = webDriver.FindElement(courseCostInvalid).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Course ID":
                    PageInteractionHelper.WaitForElementToBePresent(courseIdError);
                    PageInteractionHelper.IsElementDisplayed(courseIdError);
                    errortxt = webDriver.FindElement(courseIdError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Cost Description":
                    PageInteractionHelper.WaitForElementToBePresent(costDescriptionError);
                    PageInteractionHelper.IsElementDisplayed(costDescriptionError);
                    errortxt = webDriver.FindElement(costDescriptionError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Day":
                    PageInteractionHelper.WaitForElementToBePresent(DayError);
                    PageInteractionHelper.IsElementDisplayed(DayError);
                    errortxt = webDriver.FindElement(DayError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Month":
                    PageInteractionHelper.WaitForElementToBePresent(MonthError);
                    PageInteractionHelper.IsElementDisplayed(MonthError);
                    errortxt = webDriver.FindElement(MonthError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Year":
                    PageInteractionHelper.WaitForElementToBePresent(YearError);
                    PageInteractionHelper.IsElementDisplayed(YearError);
                    errortxt = webDriver.FindElement(YearError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Start Date":
                    PageInteractionHelper.WaitForElementToBePresent(StartDateRequiredError);
                    PageInteractionHelper.IsElementDisplayed(StartDateRequiredError);
                    errortxt = webDriver.FindElement(StartDateRequiredError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Past Date":
                    PageInteractionHelper.WaitForElementToBePresent(PasttDateError);
                    PageInteractionHelper.IsElementDisplayed(PasttDateError);
                    errortxt = webDriver.FindElement(PasttDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Future Date":
                    PageInteractionHelper.WaitForElementToBePresent(FutureDateError);
                    PageInteractionHelper.IsElementDisplayed(FutureDateError);
                    errortxt = webDriver.FindElement(FutureDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Invalid Date":
                    PageInteractionHelper.WaitForElementToBePresent(InvalidDateError);
                    PageInteractionHelper.IsElementDisplayed(InvalidDateError);
                    errortxt = webDriver.FindElement(InvalidDateError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
                    {
                        throw new Exception("Incorrect Error message displayed");
                    }
                    return new AddCoursePage2(webDriver);

                case "Duration":
                    PageInteractionHelper.WaitForElementToBePresent(DurationError);
                    PageInteractionHelper.IsElementDisplayed(DurationError);
                    errortxt = webDriver.FindElement(DurationError).GetAttribute("innerText");
                    if (!errortxt.Contains(errorMsg))
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

        public AddCoursePage2 SelectDeliveryMode(string deliveryMode)
        {
            FormCompletionHelper.SelectRadioOptionByForValue(DeliveryMode, deliveryMode);
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

        public AddCourseSummaryPage PublishCourse()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(publishBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCourseSummaryPage(webDriver);
        }

        public AddCoursePage2 PublishCourseError()
        {
            FormCompletionHelper.ClickElement(publishBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage ClickPage1()
        {
            FormCompletionHelper.ClickElement(Page1Link);
            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage(webDriver);
        }

        public AddCoursePage2 SelectFirstVenue()
        {
            if (webDriver.GetType().Name.ToString().Contains("RemoteWebDriver"))
            {
                //System.Threading.Thread.Sleep(1000);
                PageInteractionHelper.WaitForPageToLoad();
                webDriver.FindElementWait(FirstVenue, 60);
                var element = this.webDriver.FindElement(FirstVenue);
                ((IJavaScriptExecutor)this.webDriver).ExecuteScript("arguments[0].click();", element);
                PageInteractionHelper.WaitForPageToLoad();
            }
            else
            {
                PageInteractionHelper.WaitForPageToLoad();
                FormCompletionHelper.SelectCheckBox2(FirstVenue);
            }

            PageInteractionHelper.WaitForPageToLoad();
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 SelectSecondVenue()
        {
            FormCompletionHelper.SelectCheckBox2(SecondVenue);
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 clickWorkBasedRadioButton()
        {
            FormCompletionHelper.ClickElement(workBasedOptionButton);
            Debug.WriteLine("Selected Work Based Option");
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 clickNationalTrue()
        {
            FormCompletionHelper.ClickElement(nationalTrue);
            return new AddCoursePage2(webDriver);
        }


        public AddCoursePage2 clickNationalFalse()
        {
            FormCompletionHelper.ClickElement(nationalFalse);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 verifyFlexibleStartDateSelected()
        {
            FormCompletionHelper.IsObjectSelected(flexibleStartDateOption);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 verifyVenueSelectionNotShown()
        {
            FormCompletionHelper.VerifyElementNotPresent(selectVenueOption);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 verifyAttendancePatternButtonsnotShown()
        {
            FormCompletionHelper.VerifyElementNotPresent(attendancePatternButtons);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 verifyFullPartTimeButtonsNotShown() 
        {
            FormCompletionHelper.VerifyElementNotPresent(fullPartTimeButtons);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 verifyCourseRegionIsShown()
        {
            FormCompletionHelper.IsElementPresent(courseRegionSelector);
            return new AddCoursePage2(webDriver);
        }

        public AddCoursePage2 selectFirstOptionOnRegionSelector()
        {
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(firstRegion);
            PageInteractionHelper.WaitForPageToLoad();
            FormCompletionHelper.ClickElement(courseRegionSelectorFirstField);
            return new AddCoursePage2(webDriver);
        }

    }
}