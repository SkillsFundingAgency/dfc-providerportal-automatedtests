using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Bulk_Upload;
using UITesting.ProviderPortal.Pages.Course_Management;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class BulkUploadSteps : TestSupport.BaseTest
    {
        [Given(@"I have accessed the Bulk Upload page")]
        public void GivenIAmOnBulkUploadPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/BulkUpload";
        }

        [Given(@"I have accessed the Bulk Upload fixes page")]
        public void GivenIAmOnBulkUploadFixPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/PublishCourses?publishMode=BulkUpload";
        }

        [Given(@"I have accessed the Bulk Upload delete file page")]
        public void GivenIAmOnBulkUploadDeletePage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/BulkUpload/DeleteFile";
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

        [Then(@"I am on the Fix and publish bulk upload page for a new file upload")]
        public void OnFixAndPublishPage()
        {
            BulkUploadFixPublishPage bulkUploadFixPublishPage = new BulkUploadFixPublishPage(webDriver);
            bulkUploadFixPublishPage.ClickFix();
            bulkUploadFixPublishPage.ClickContinue();
        }

        [Then(@"I am on the Fix and publish bulk upload page")]
        public void OnFixAndPublishPage2()
        {
            BulkUploadFixPublishPage bulkUploadFixPublishPage = new BulkUploadFixPublishPage(webDriver);
        }

        [Then(@"I am on the Publish your courses page")]
        public void OnPublishPage()
        {
            BulkUploadPublishPage bulkUploadPublishPage = new BulkUploadPublishPage(webDriver);
        }

        [Then(@"the error (.*) is displayed")]
        public void Stage1ErrorMsg(string errorMsg)
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.ConfirmErrorMsg(errorMsg);
        }

        [Then(@"the error (.*) is displayed in error summary")]
        public void ErrorSummaryErrorMsg(string errorMsg)
        {
            UploadAFilePage uploadAFilePage = new UploadAFilePage(webDriver);
            uploadAFilePage.ConfirmErrorSummaryMsg(errorMsg);
        }


        [Then(@"I am on the courses published page")]
        public void SuccessfulPublish()
        {
            BulkUploadFilePublishedPage bulkUploadFilePublishedPage = new BulkUploadFilePublishedPage(webDriver);
        }
        
        [When(@"I click delete bulk upload file")]
        public void WhenIClickDeleteDeleteBulkUploadFile()
        {
            BulkUploadDeletePage bulkUploadDeletePage = new BulkUploadDeletePage(webDriver);
            bulkUploadDeletePage.Delete();
        }
        
        [Then(@"I am on Bulk Upload file deleted page")]
        public void ThenIAmBulkUploadFileDeleted()
        {
            BulkUploadFileDeletedPage bulkUploadFileDeletedPage = new BulkUploadFileDeletedPage(webDriver);
        }


        [Then(@"I click on Cancel to cancel edit")]
        public void CancleBUEdit()
        {
            EditCoursePage editCoursePage = new EditCoursePage(webDriver);
            editCoursePage.ClickCancelBU();
        }

        [Then(@"I click on Cancel to cancel edit course run")]
        public void CancleBUEdit2()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.ClickCancelBU();
        }

        [When(@"I click to Save the Course details")]
        public void SaveBUEdit()
        {
            EditCoursePage editCoursePage = new EditCoursePage(webDriver);
            editCoursePage.ClickSaveBU();
        }

        [When(@"I click to Save the Course Run details")]
        public void SaveBURunEdit()
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.ClickSaveBURun();
        }

        [When(@"I click publish to publish upload courses")]
        public void PublishUploadedCourses()
        {
            BulkUploadPublishPage bulkUploadPublishPage = new BulkUploadPublishPage(webDriver);
            bulkUploadPublishPage.Publish();
        }

        [When(@"I click fix against the first Course")]
        public void FixUploadedCourses()
        {
            BulkUploadFixPublishPage bulkUploadFixPublishPage = new BulkUploadFixPublishPage(webDriver);
            bulkUploadFixPublishPage.FixCourse();
        }

        [When(@"I click fix against the first Course Run")]
        public void FixUploadedCourseRun()
        {
            BulkUploadFixPublishPage bulkUploadFixPublishPage = new BulkUploadFixPublishPage(webDriver);
            bulkUploadFixPublishPage.FixCourseRun();
        }


        [When(@"I edit bulk upload course description (.*)")]
        public void EditUploadedCourse(string description)
        {
            EditCoursePage editCoursePage = new EditCoursePage(webDriver);
            editCoursePage.EnterWhoCourseFor(description);
        }

        [When(@"I edit bulk upload course entry requirements (.*)")]
        public void EditUploadedCourseReqs(string entryReqs)
        {
            EditCoursePage editCoursePage = new EditCoursePage(webDriver);
            editCoursePage.EnterEntryRequirements(entryReqs);
        }

        [When(@"I edit bulk upload course cost (.*)")]
        public void EditUploadedCourseRun(string cost)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseCost(cost);
        }

        [When(@"I edit bulk upload course name (.*)")]
        public void EditUploadedCourseRunName(string name)
        {
            EditCoursePage2 editCoursePage2 = new EditCoursePage2(webDriver);
            editCoursePage2.EnterCourseName(name);
        }


        [When(@"I click fix against the first Course i want edit and save")]
        public void FixUploadedCoursesSave()
        {
            IList<IWebElement> links = webDriver.FindElements(By.LinkText("Fix"));
            IList<IWebElement> listOflinks = new List<IWebElement>();

            for (int i = 0; i < links.Count; i++)
            {
                links = webDriver.FindElements(By.LinkText("Fix"));
                if (i == 0)
                    links[i].Click();
            }
        }

        [When(@"I click fix against the first Course Run i want edit and save")]
        public void FixUploadedCourseRunSave()
        {
            IList<IWebElement> links = webDriver.FindElements(By.LinkText("Fix"));
            IList<IWebElement> listOflinks = new List<IWebElement>();

            for (int i = 0; i < links.Count; i++)
            {
                links = webDriver.FindElements(By.LinkText("Fix"));
                if (i == 1)
                    links[i].Click();
            }
        }

    }
}
