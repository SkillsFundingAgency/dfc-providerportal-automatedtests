using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Bulk_Upload;


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

        [When(@"I click publish to publish upload courses")]
        public void PublishUploadedCourses()
        {
            BulkUploadPublishPage bulkUploadPublishPage = new BulkUploadPublishPage(webDriver);
            bulkUploadPublishPage.Publish();
        }
    }
}
