using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.ProviderPortal.Pages.Course_Management;
using UITesting.ProviderPortal.Pages.Provider_Management;
using UITesting.ProviderPortal.Pages.Data_Quality_Indicators;
using UITesting.ProviderPortal.Pages;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class EditCourseNameSteps :BaseTest
    {
        [Given(@"I have accessed course directory as a provider")]
        [Given(@"I have logged to course directory as a provider")]
        public void GivenIHaveLoggedToCourseDirectoryAsAProvider()
        {
            webDriver.Url = Configurator.GetConfiguratorInstance().GetBaseUrl();
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
            dfESignInPage.EnterUsername (Configurator.GetConfiguratorInstance().GetdFEUser());
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



        [Given(@"I have selected a course run to copy")]
        public void GivenIHaveSelectedACourseRunToCopy()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourse();

            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickCopyCourse();
        }


        [Given(@"I have selected a course run to delete")]
        public void GivenIHaveSelectedACourseRunToDelete()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.SelectCourse();

            CourseSummaryPage courseSummaryPage = new CourseSummaryPage(webDriver);
            courseSummaryPage.ClickDeleteCourse();
        }


        [Given(@"I have clicked edit for a course run")]
        public void CourseRunToUpdate()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            //editYourCoursePage.SelectCourseRunName();
            editYourCoursePage.EditCourseRun();
        }

        [Given(@"I have changed the course name to ""(.*)""")]
        public void GivenIHaveChangedTheCourseNameTo(string newCourseName)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseName(newCourseName);
        }

        [Given(@"I have changed the URL to (.*)")]
        public void GivenIHaveChangedTheURLTo(string newURL)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseURL(newURL);
        }

        [Given(@"I have changed the cost to (.*)")]
        public void GivenIHaveChangedTheCost(string newCost)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseCost(newCost);
        }

        [When(@"I Click Save")]
        public void WhenIClickSave()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.SaveCourse();
        }


        [When(@"I Click Save leading to Error")]
        public void WhenIClickSaveError()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.SaveCourseError();
        }

        [Then(@"I should be able to view the course runs\.")]
        public void ThenIShouldBeAbleToViewTheCourseRuns_()
        {
            //ScenarioContext.Current.Pending();
        }
        
        [Then(@"Save , Discard and preview buttons should be visible")]
        public void ThenSaveDiscardAndPreviewButtonsShouldBeVisible()
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateButtons();
        }
        
        [Then(@"the new (.*) should be saved as (.*)")]
        public void ThenTheNewCourseNameShouldBeSavedAs(string updatedField, string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.VerifyUpdate(updatedField, newCourseName);
        }
        
        [Then(@"the Error message for (.*) should be displayed (.*)")]
        public void ThenTheErrorMessageShouldBeDisplayed(string field, string errMessage)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.ConfirmErrorMessage(field, errMessage);
        }
        
        [Then(@"the course name should be saved without leading or trailing spaces as ""(.*)""")]
        public void ThenTheCourseNameShouldBeSavedWithoutLeadingOrTrailingSpacesAs(string newCourseName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSpacesData(newCourseName);
        }

        [Given(@"I have changed the course venue to (.*)")]
        public void EditVenueName(string venueName)
        {
            EditCoursePage2 editCoursePage2= new EditCoursePage2(webDriver);
            editCoursePage2.SelectVenue(venueName);
        }

        [Then(@"the new course venue should be saved as (.*)")]
        public void NewCourseVenueShouldBeSaved(string venueName)
        {
            EditYourCoursePage editYourCoursePage = new EditYourCoursePage(webDriver);
            editYourCoursePage.ValidateSavedVenue(venueName);
        }

        [When(@"I edit National coverage to No")]
        public void NationalCoverageFalse()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.clickNationalFalse();
        }


        [When(@"I edit National coverage to Yes")]
        public void NationalCoverageTrue()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.clickNationalTrue();
        }


        [When(@"I edit the first course region option on selector")]
        public void WhenISelectTheFirstCourseRegionOptionOnSelector()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.selectFirstOptionOnRegionSelector();
        }

        [Then(@"Copy Course page should be displayed")]
        public void ThenCopyCoursePageShouldBeDisplayed()
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
        }


        [When(@"I clik save to copy the course")]
        public void WhenIClikSaveToCopyTheCourse()
        {
            CopyCoursePage copyCoursePage = new CopyCoursePage(webDriver);
            copyCoursePage.ClickSave();
        }


    }
}
