using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Venue_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Qualification_Management;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;
using UITesting.ProviderPortal.Pages.Bulk_Upload;
using UITesting.ProviderPortal.Pages;
using UITesting.BrowserStack.TestSupport;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System.Linq;

namespace UITesting.BrowserStack.StepDefinitions
{
    //[Scope(Tag = "Venues")]
    [Binding]
    public class BrowserStackSteps
    {
        //private IWebDriver _driver;
        public static IWebDriver webDriver;
        readonly BrowserStackDriver _bsDriver;

        public BrowserStackSteps()
        {

            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Regression"))
            {
                _bsDriver = (BrowserStackDriver)ScenarioContext.Current["bsDriver"];
            }
            else
            {
                webDriver = (IWebDriver)ScenarioContext.Current["_driver"];
            }
        }


        [Given(@"I have navigated to the Home page using (.*) and (.*)")]
        public void GivenIAmOnTheLandingPage(string profile, string environment)
        {
            ScenarioContext.Current["Browser"] = environment;
            webDriver = _bsDriver.Init(profile, environment);
            webDriver.Navigate().GoToUrl(Configurator.GetConfiguratorInstance().GetBaseUrl());
            PageInteractionHelper.SetDriver(webDriver);
        }

        //local login
        [Given(@"I login via Local as admin with (.*) and (.*)")]
        public void GivenILoginWithUsernameAndPassword(string user, string pass)
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.EnterUsername(Configurator.GetConfiguratorInstance().GetadminUser());
            loginPage.EnterPassword(Configurator.GetConfiguratorInstance().GetadminPassword());
            loginPage.ClickLoginButton();
        }

        //dfe login
        [Given(@"I login as admin with (.*) and (.*)")]
        public void DfELoginWithUsernameAndPassword(string user, string pass)
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLoginDfE();

            DfESignInPage dfESignInPage = new DfESignInPage(webDriver);
            dfESignInPage.EnterUsername(Configurator.GetConfiguratorInstance().GetdFEUser());
            dfESignInPage.EnterPassword(Configurator.GetConfiguratorInstance().GetdFEPassword());
            dfESignInPage.ClickSignInButton();
        }

        //local login
        [Given(@"I login via Local as provider admin with (.*) and (.*)")]
        public void GivenILoginWithProviderUsernameAndPassword(string user, string pass)
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginPage loginPage = new LoginPage(webDriver);
            loginPage.EnterUsername(user);
            loginPage.EnterPassword(pass);
            loginPage.ClickLoginButtonProvider();
        }

        //dfe login
        [Given(@"I login as provider admin with (.*) and (.*)")]
        public void DfELoginWithProviderUsernameAndPassword(string user, string pass)
        {

            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLoginDfE();

            DfESignInPage dfESignInPage = new DfESignInPage(webDriver);
            dfESignInPage.EnterUsername(user);
            dfESignInPage.EnterPassword(pass);
            dfESignInPage.ClickSignInButtonProvider();
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
        }

        [Then(@"I am logged in as a provider")]
        public void ThenIAmLoggedInProvider()
        {
            DQIDashbordPage dQIDashbordPage = new DQIDashbordPage(webDriver);
        }

        //[Given(@"I login as admin with (.*) and (.*)")]
        //public void GivenILoginWithUsernameAndPassword(string user, string pass)
        //{
        //    HomePage homePage = new HomePage(webDriver);
        //    homePage.ClickLogin();

        //    LoginPage loginPage = new LoginPage(webDriver);
        //    loginPage.EnterUsername(Configurator.GetConfiguratorInstance().GetadminUser());
        //    loginPage.EnterPassword(Configurator.GetConfiguratorInstance().GetadminPassword());
        //    loginPage.ClickLoginButton();
        //}

        //[Then(@"I am logged in")]
        //public void ThenIAmLoggedIn()
        //{
        //    SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
        //}

        [Given(@"I have logged into course directory as a provider")]
        public void LoginToCourseDirectory()
        {
            // webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
        }

        [Given(@"I have searched for UKPRN ""(.*)"" and clicked search")]
        public void GivenIHaveSearchedForUKPRNAndClickedSearch(string ukPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(ukPRN);
            searchProviderPage.ClickSearchButton();
        }

        [Given(@"I have clicked View Courses button to see a list of courses")]
        public void GivenIHaveClickedViewCoursesButtonToSeeAListOfCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }

        #region Venues
        [Given(@"I have navigated to the Your Venues Pages")]
        public void NavigateToYourVenuesPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrlVenues();
        }

        [When(@"I click Add Venue")]
        public void GoToAddVenuePage()
        {
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.ClickAddVenueButton();
        }


        [Then(@"I am on the Add Venue page")]
        public void ThenIAmOnTheAddVenuePage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }


        [Then(@"the Add Venue page displays the expected content")]
        public void AddVenuePageContent()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
        }


        [When(@"I click Find Address")]
        public void WhenIClickFindAddress()
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.ClickFindAddress();
        }

        [Then(@"Address validation message is displayed (.*)")]
        public void MessageIsDisplayedPostcodeMustBeEntered(string validationMsg)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.AddressValidationMessage(validationMsg);
        }

        [When(@"I enter the following postcode (.*)")]
        public void WhenIEnterTheFollowingPostcode(string postcode)
        {
            AddVenuePage addVenuePage = new AddVenuePage(webDriver);
            addVenuePage.EnterPostCode(postcode);
        }


        [Then(@"I am on the Select Address page")]
        public void ThenIAmOnTheSlectAddressPage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
        }


        [When(@"I click continue")]
        public void WhenIClickContinue()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickContinue();
        }


        [When(@"I click continue to confirm page")]
        public void WhenIClickContinueIClickContinueToConfirmPage()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickContinueConfirm();
        }


        [Then(@"Select Address validation message is displayed (.*)")]
        public void SelectAddressValidationMessageIsDisplayed(string selectValidationMsg)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.SelectAddressValidationMessage(selectValidationMsg);
        }


        [When(@"I select the address (.*)")]
        public void WhenISelectTheFirstAddressReturned(string address)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.selectAddress(address);

        }

        [Then(@"Venue Name validation message is displayed (.*)")]
        public void VenueNameValidationMessageIsDisplayed(string venueValidationMsg)
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.SelectAddressVenueValidationMessage(venueValidationMsg);
        }

        [When(@"I enter venue name (.*)")]
        public void WhenIEnterVenueName(string venueName)
        {
            if (venueName == "space")
            {
                venueName = " ";
            }
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.EnterVenueName(venueName);
        }

        [Then(@"I am on the Add Venue Confirm details page")]
        public void ThenIAmOnTheAddVenueConfirmDetailsPage()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [When(@"I Click Change")]
        public void WhenIClickChange()
        {
            AddVenueSelectAddressPage addVenueSelectAddressPage = new AddVenueSelectAddressPage(webDriver);
            addVenueSelectAddressPage.ClickChange();
        }


        [When(@"I am on the Add Venue Confirm details page")]
        public void WhenIAmOnTheAddVenueConfirmDetailsPage()
        {
            PageInteractionHelper.WaitForPageToLoad();
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [Then(@"the Add venue confirm details page displays the expected content")]
        public void AddVenueConfirmPageContent()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
        }


        [When(@"On the Confirmation Page I click continue")]
        public void WhenOnTheConfirmationPageIClickContinue()
        {
            AddVenueConfirmAddressPage addVenueConfirmAddressPage = new AddVenueConfirmAddressPage(webDriver);
            addVenueConfirmAddressPage.ClickContinue();
        }


        [When(@"I enter (.*) and click search")]
        public void WhenIEnterAndClickSearch(string ukprn)
        {
            ViewAllLiveVenuesPage viewAllLiveVenuesPage = new ViewAllLiveVenuesPage(webDriver);
            viewAllLiveVenuesPage.SearchProvider(ukprn);
        }
        #endregion Venues

        #region Provider
        [Given(@"I have navigated to the Search Provider Page")]
        public void GivenIAmOnSearchAProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl();
        }


        [When(@"I enter (.*) and click search provider")]
        public void WhenIEnterAndClickSearchProvider(string UKPRN)
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.EnterUKPRN(UKPRN);
            searchProviderPage.ClickSearchButton();
        }

        [When(@"I click to view my courses")]
        public void WhenIClickToViewMyCourses()
        {
            SearchProviderPage searchProviderPage = new SearchProviderPage(webDriver);
            searchProviderPage.ClickViewCoursesButton();
        }
        #endregion Provider

        #region Qualification

        [Given(@"I have accessed the Qualifications page")]
        public void GivenIHaveAccessedTheQualificationsPage()
        {
            if (webDriver.Url.Contains("/Qualifications"))
            {
                SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            }
            else
            {
                webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetQualUrl();
                SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            }
        }

        [Given(@"there is a field to enter the LARS/QAN number\.")]
        public void GivenThereIsAFieldToEnterTheLARSQANNumber_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckSearchTermField();
        }

        [Given(@"I have entered LARS/QAN Number ""(.*)""")]
        public void GivenIHaveEnteredLARSQANNumber(string LARS_QAN_No)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(LARS_QAN_No);
        }

        [Given(@"that I have entered an invalid search term ""(.*)""")]
        public void GivenThatIHaveEnteredAnInvalidSearchTerm(string Inv_Search_Term)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(Inv_Search_Term);
        }

        [Given(@"I have entered a Qualification Name ""(.*)""")]
        public void GivenIHaveEnteredAQualificationName(string QualName)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.EnterLARS_QANNumber(QualName);
        }

        [Given(@"I have retrieved results for a search term")]
        public void GivenIHaveRetrievedResultsForASearchTerm()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I select one level for qualification level")]
        public void GivenISelectOneLevelForQualificationLevel()
        {
            // ScenarioContext.Current.Pending();
        }

        [Given(@"I have selected one awarding body")]
        public void GivenIHaveSelectedOneAwardingBody()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have selected filters in Qualification Level and/or Awarding body")]
        public void GivenIHaveSelectedFiltersInQualificationLevelAndOrAwardingBody()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ClickFirstFilter();
        }

        [Then(@"I click reset")]
        [When(@"I click reset")]
        public void WhenIClickReset()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ClearAllFilters();
        }

        [Then(@"I want to see the Qualifications listed for that LARS/QAN Number")]
        public void ThenIWantToSeeTheQualificationsListedForThatLARSQANNumber()
        {
            //ScenarioContext.Current.Pending();
        }

        [Then(@"I want to see LARS/QAN number ""(.*)"", Level ""(.*)"" and awarding body ""(.*)"" for each qualification")]
        public void ThenIWantToSeeLARSQANNumberLevelAndAwardingBodyForEachQualification(string LARSQAN_Lbl, string LevelLbl, string AwardBodyLbl)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.ValidateLabels(LARSQAN_Lbl, LevelLbl, AwardBodyLbl);

        }

        [Then(@"I want to see a Link to add this qualification\.")]
        public void ThenIWantToSeeALinkToAddThisQualification_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckAddQualificationLink();
        }

        [Given(@"I click the link to Add Qualification")]
        public void GivenIClickTheLinkToAddQualification()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.AddQualificationLink();
        }


        [Then(@"I want to see Qualification Level Filter ""(.*)""")]
        public void ThenIWantToSeeQualificationLevelFilter(string QualLevelFilter)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.LookForQualificationLevelFilter(QualLevelFilter);
        }

        [Then(@"I want to see Awarding Organisation Filter on the screen ""(.*)""")]
        public void ThenIWantToSeeAwardingOrganisationFilterOnTheScreen(string AwardBodyFilter)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.LookForAwardingBodyFilter(AwardBodyFilter);
        }

        [Then(@"I want to see a validation message ""(.*)""")]
        public void ThenIWantToSeeAValidationMessage(string validation_msg)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckValidationMessage(validation_msg);
        }

        [Then(@"I want to see the number of results returned for the name ""(.*)""")]
        public void ThenIWantToSeeTheNumberOfResultsReturnedForTheName(string resultsMsg)
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.CheckResultsMessage(resultsMsg);
        }

        [Then(@"I want to see Level and Awarding body on the screen\.")]
        public void ThenIWantToSeeLevelAndAwardingBodyOnTheScreen_()
        {
            // ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to select another level for qualification level")]
        public void ThenIShouldBeAbleToSelectAnotherLevelForQualificationLevel()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should be able to select another awarding body")]
        public void ThenIShouldBeAbleToSelectAnotherAwardingBody()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"all filters should be cleared\.")]
        public void ThenAllFiltersShouldBeCleared_()
        {
            SearchforQualificationPage SearchforQualificationPage = new SearchforQualificationPage(webDriver);
            SearchforQualificationPage.FiltersCleared();
        }

        #endregion Qualification

        # region Courses

        [Given(@"I have specified who the course is for (.*)")]
        public void GivenIHaveSpecifiedWhoTheCourseIsFor(string p0)
        {
            if (p0 == "blank")
            {
                p0 = "";
            }
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhoCourseFor(p0);
        }

        [Given(@"I have entered the entry requirements (.*)")]
        public void GivenIHaveEnteredTheEntryRequirements(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterEntryRequirements(p0);

        }

        [Given(@"I have entered what the student will learn (.*)")]
        public void GivenIHaveEnteredWhatTheStudentWillLearn(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterWhatWillLearn(p0);
        }

        [Given(@"I have entered how the student will learn (.*)")]
        public void GivenIHaveEnteredHowTheStudentWillLearn(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterHowYoullLearn(p0);
        }

        [Given(@"I have entered what equipment will be needed (.*)")]
        public void GivenIHaveEnteredWhatEquipmentWillBeNeeded(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.EnterEquipmentNeeded(p0);
        }

        [Given(@"I have entered how the student will be assessed (.*)")]
        public void GivenIHaveEnteredHowTheStudentWillBeAssessed(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.HowAssessed(p0);
        }


        [Given(@"I have enter the next steps following completion of the course (.*)")]
        public void NextStepsFollowingCompletionOfTheCourseLevelOfThisCourse(string p0)
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.NextSteps(p0);
        }


        [When(@"I click Next Button")]
        public void WhenIClickNextButton()
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.ClickNext();
        }

        [When(@"I click Next Button Failure")]
        public void WhenIClickNextButtonFail()
        {
            AddCoursePage AddCoursePage = new AddCoursePage(webDriver);
            AddCoursePage.ClickNextFail();
        }

        [Then(@"Page 1 error message for field (.*) states (.*)")]
        public void ConfirmErrorMessage(string field, string errorMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ConfirmErrorMessage(field, errorMsg);
        }


        [Then(@"Page 1 info message for field (.*) states (.*)")]
        public void ConfirmInfoMessage(string field, string errorMsg)
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
            addCoursePage.ConfirmInfoMessage(field, errorMsg);
        }

        [Given(@"I have navigated to the Add Course Section 2 page")]
        public void NavigateToAddCoursePage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "//Courses//AddCourseSection2";
        }

        [When(@"I enter the following in the course name field Course (.*)")]
        public void EntereCourseNameField(string coursename)
        {
            if (coursename == "blank")
            {
                coursename = "";
            }
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseName(coursename);
        }


        [Then(@"course name error validation is not displayed")]
        public void ThenCourseNameIsNotDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseNameErrorNotDisplayed();
        }

        [Then(@"course name error validation is displayed")]
        public void ThenCourseNameErrorDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseNameErrorDisplayed();
        }

        [When(@"I enter the following in the URL field (.*)")]
        public void WhenIEnterTheURL(string url)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseURL(url);
        }

        [Then(@"course URL error validation is displayed")]
        public void ThenCourseURLErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseURLErrorDisplayed();
        }


        [Then(@"error message for field (.*) states (.*)")]
        public void ConfirmErrorMessagePage2(string field, string errorMsg)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ConfirmErrorMessage(field, errorMsg);
        }


        [When(@"I enter the following in the cost field (.*)")]
        public void EnterTheFollowingInTheCostField(string cost)
        {
            if (cost == "blank")
            {
                cost = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseCost(cost);
        }

        [Then(@"course Cost error validation is displayed")]
        public void CourseCostErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseCostErrorDisplayed();
        }


        [When(@"I enter the following in the course id field (.*)")]
        public void EnterCourseID(string courseId)
        {
            if (courseId == "blank")
            {
                courseId = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCourseId(courseId);
        }


        [Then(@"course id error validation is displayed")]
        public void ThenCourseIDErrorDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CourseIDErrorDisplayed();
        }

        [When(@"I enter the following in the cost description field (.*)")]
        public void EnterCostDescription(string costdescription)
        {
            if (costdescription == "blank")
            {
                costdescription = "";
            }

            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterCostDescription(costdescription);
        }

        [Then(@"cost description error validation is displayed")]
        public void CostDescriptionErrorValidationIsDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.CostDescriptionErrorDisplayed();
        }

        [Then(@"info message for field (.*) states (.*)")]
        public void InfoMessageForFieldCostDescription(string field, string infoMsg)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.ConfirmInfoMessage(field, infoMsg);
        }

        [When(@"I Select attendance mode (.*)")]
        public void WhenISelectAttendanceMode(string attendance)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectAttendance(attendance);
        }

        [When(@"I Select study mode (.*)")]
        public void WhenISelectStudyMode(string studymode)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectStudyMode(studymode);
        }

        [When(@"I print Qualification details")]
        public void WhenIPrintQualificationDetails()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.GetQualifiactionDetails();
        }

        [When(@"I tick the Advanced Learner Loans option")]
        public void TickTheAdvancedLearnerLoansOption()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectAdvancedLearnerLoan();
        }

        [When(@"I select start date (.*)")]
        public void WhenISelectStartDate(string StartDate)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectStartDateType(StartDate);
        }

        [When(@"I enter (.*) in the (.*) field")]
        public void WhenIEnterDay(string value, string field)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterStartDate(value, field);
        }

        [When(@"I select duration length (.*)")]
        public void WhenISelectDurationLength(string length)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.EnterDuration(length);
        }

        [When(@"I select duration unit (.*)")]
        public void WhenISelectDurationUnit(string unit)
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectDurationUnit(unit);
        }

        [When(@"I click Publish")]
        public void WhenIClickPublish()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.PublishCourse();
        }

        [When(@"I click Publish leading to error")]
        public void WhenIClickPublishLeadingToError()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.PublishCourseError();
        }


        [When(@"I select the first venue in the venues list")]
        public void SelectTheFirstVenueInTheVenuesList()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectFirstVenue();
        }

        [When(@"I select the second venue in the venues list")]
        public void SelectTheSecondVenueInTheVenuesList()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
            addCoursePage2.SelectSecondVenue();
        }

        [Given(@"I have clicked the Main Qualification")]
        public void GivenIHaveClickedTheMainQualification()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickQual();
        }

        [Given(@"I have clicked one of the courses available")]
        public void GivenIHaveClickedOneOfTheCoursesAvailable()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ClickCourseName();
        }

        [Given(@"I have selected a course run to update")]
        public void GivenIHaveSelectedACourseRunToUpdate()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourse();

            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickEditCourseRun();
        }

        [Then(@"I should be able to view the course runs\.")]
        public void ThenIShouldBeAbleToViewTheCourseRuns_()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I have changed the course name to ""(.*)""")]
        public void GivenIHaveChangedTheCourseNameTo(string newCourseName)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseName(newCourseName);
        }

        [When(@"I Click Save")]
        public void WhenIClickSave()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.SaveCourse();
        }

        [When(@"I select Edit Course Description")]
        public void WhenISelectEditCourseDescription()
        {
            //  ViewYourCoursesPage ViewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //  ViewYourCoursesPage.ClickEditCourseDescriptionLink();
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourse();

            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickEditCourse();
        }

        [Then(@"Edit Course screen should be displayed")]
        public void ThenEditCourseScreenShouldBeDisplayed()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
        }

        [Given(@"I have edited course description with valid values ""(.*)""")]
        public void GivenIHaveEditedCourseDescriptionWithValidValues(string strData)
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.EnterCourseDescription(strData);
        }

        [When(@"I Click the Save button")]
        public void WhenIClickTheSaveButton()
        {
            EditCourseDescription_YC3Page editCourseDescription_YC3Page = new EditCourseDescription_YC3Page(webDriver);
            editCourseDescription_YC3Page.ClickSave();
        }

        #endregion Courses

        #region Your Courses

        [Then(@"I should be able to view a Search box to enter my search criteria")]
        public void ThenIShouldBeAbleToViewASearchBoxToEnterMySearchCriteria()
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.ValidateSearchText();
        }

        [Given(@"I have entered a full search term as ""(.*)""")]
        public void GivenIHaveEnteredAFullSearchTermAs(string strSearch)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            viewYourCoursesPage.EnterSearchTerm(strSearch);
        }

        [Then(@"the results with biology should be returned")]
        public void ThenTheResultsWithBiologyShouldBeReturned()
        {
            //ScenarioContext.Current.Pending();
        }

        #endregion Your Courses


        #region Non Regulated Qualifications

        [When(@"I Navigate to Regulated Qualifications page")]
        public void WhenINavigateToRegulatedQualificationsPage()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl() + "/RegulatedQualification";
        }

        [When(@"I have selected Non Regulated Option and Clicked Next")]
        public void WhenIHaveSelectedNonRegulatedOptionAndClickedNext()
        {
            RegulatedQualificationPage regulatedQualificationPage = new RegulatedQualificationPage(webDriver);
            regulatedQualificationPage.SelectNonRegulatedOption();
            regulatedQualificationPage.ClickNext();
        }

        [Then(@"the Unregulated courses page should be displayed")]
        public void ThenTheUnregulatedCoursesPageShouldBeDisplayed()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
        }

        [Given(@"I have clicked  I dont know z code link")]
        public void GivenIHaveClickedIDontKnowZCodeLink()
        {
            UnRegulatedCoursesPage unRegulatedCoursesPage = new UnRegulatedCoursesPage(webDriver);
            unRegulatedCoursesPage.clickDontKnowZCode();
        }

        [Then(@"Unknown Z code page should be displayed")]
        public void ThenUnknownZCodePageShouldBeDisplayed()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
        }

        [When(@"I Select First Level and Second Level")]
        public void WhenISelectFirstLevelAndSecondLevel()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickFirstLevel();
            unKnownZCodePage.ClickSecondLevel();

        }

        [When(@"I click the Add this Provision link")]
        public void WhenIClickTheAddThisProvisionLink()
        {
            UnKnownZCodePage unKnownZCodePage = new UnKnownZCodePage(webDriver);
            unKnownZCodePage.ClickAddThisProvision();
        }

        [Then(@"add course page should be displayed")]
        public void ThenAddCoursePageShouldBeDisplayed()
        {
            AddCoursePage addCoursePage = new AddCoursePage(webDriver);
        }

        [Then(@"add course run should be displayed")]
        public void ThenAddCourseRunShouldBeDisplayed()
        {
            AddCoursePage2 addCoursePage2 = new AddCoursePage2(webDriver);
        }

        [Then(@"the course should be listed in the Your courses page")]
        public void ThenTheCourseShouldBeListedInTheYourCoursesPage()
        {
            AddCourseSummaryPage addCourseSummaryPage = new AddCourseSummaryPage(webDriver);
            addCourseSummaryPage.ClickNext();
        }

        #endregion Non Regulated Qualifications

        #region Bulk Upload

        [Given(@"I have accessed the Bulk Upload page")]
        public void GivenIAmOnBulkUploadPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/BulkUpload";
        }


        [When(@"I click Choose a File (.*) to upload")]
        public void WhenIChooseFile(string fileName)
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.ChooseFile(fileName);
        }

        [When(@"I click Upload File leading to course errors")]
        public void WhenIClickUploadFile()
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.UploadFile();
        }

        [When(@"I click Upload File leading to stage1 errors")]
        public void UploadFileError()
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.UploadFileError();
        }

        [When(@"I click Upload File leading to no course errors")]
        public void ClickUploadFileNoError()
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.UploadFileNoErrors();
        }

        [Then(@"I am on the Fix and publish bulk upload page")]
        public void OnFixAndPublishPage()
        {
            BulkUploadFixPublishPage bulkUploadFixPublishPage = new BulkUploadFixPublishPage(webDriver);
        }

        [Then(@"I am on the Publish your courses page")]
        public void OnPublishPage()
        {
            BulkUploadPublishPage bulkUploadPublishPage = new BulkUploadPublishPage(webDriver);
        }

        #endregion Bulk Upload

        #region DQI

        [Given(@"I click on the courses need their start date updated link")]
        public void GivenIAmOnDashboardPage()
        {
            DQIDashbordPage dQIDashbordPage = new DQIDashbordPage(webDriver);
            dQIDashbordPage.NavigateToDQI();
        }


        [Then(@"I am taken to the DQI page")]
        public void DQIFixAndPublishPage()
        {
            DQIFixPublishPage dQIFixAndPublish = new DQIFixPublishPage(webDriver);
        }


        [When(@"I click on the first course run requiring start date update")]
        public void FixCourseRunStartDate()
        {
            DQIFixPublishPage dQIFixPublishPage = new DQIFixPublishPage(webDriver);
            dQIFixPublishPage.FixCourseRun();
        }


        [Then(@"I am take to Edit Course page")]
        public void DQIEdit()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
        }

        [When(@"I update the start date")]
        [Then(@"I update the start date")]
        public void DQIUpdateStartDate()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterStartDate("01", "Day");
            editCoursePage2.EnterStartDate("01", "Month");
            editCoursePage2.EnterStartDate("2021", "Year");
        }


        [Then(@"the Save button is displayed")]
        public void DQISave()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.verifySaveButton();
        }

        [When(@"I click cancel DQI Edit")]
        public void CancleDQIEdit()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.ClickCancelDQI();
        }

        [When(@"I click on the Provider name in the header")]
        public void WhenIClickOnTheProviderNameInTheHeader()
        {
            DQIDashbordPage dQIDashbordPage = new DQIDashbordPage(webDriver);
            dQIDashbordPage.NavigateToProviderDetails();
        }

        #endregion DQI
    }
}