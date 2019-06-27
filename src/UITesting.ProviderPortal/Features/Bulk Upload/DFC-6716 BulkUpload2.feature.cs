﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace UITesting.ProviderPortal.Features.BulkUpload
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DFC-6716 Bulk Upload 2")]
    public partial class DFC_6716BulkUpload2Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DFC-6716 BulkUpload2.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DFC-6716 Bulk Upload 2", "\tIn order to update my Courses\r\n\tAs a provider\r\n\tI want to be able to be able to " +
                    "use the Bulk Upload functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-7224 Bulk Upload Cancel Course Edit")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_7224BulkUploadCancelCourseEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-7224 Bulk Upload Cancel Course Edit", null, new string[] {
                        "CI"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Given("I have accessed the Bulk Upload fixes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
 testRunner.When("I click fix against the first Course i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("I click on Cancel to cancel edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 17
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-7224 Bulk Upload Cancel Course Run Edit")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_7224BulkUploadCancelCourseRunEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-7224 Bulk Upload Cancel Course Run Edit", null, new string[] {
                        "CI"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 24
 testRunner.Given("I have accessed the Bulk Upload fixes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.When("I click fix against the first Course Run i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.Then("I click on Cancel to cancel edit course run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 28
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-6719 Bulk Upload Edit uploaded Course")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_6719BulkUploadEditUploadedCourse()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-6719 Bulk Upload Edit uploaded Course", null, new string[] {
                        "CI"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
 testRunner.Given("I have accessed the Bulk Upload fixes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.When("I click fix against the first Course i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I edit bulk upload course description Semi-qualified (people)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("I click on Cancel to cancel edit", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-6736 Bulk Upload Edit uploaded Course Run")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_6736BulkUploadEditUploadedCourseRun()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-6736 Bulk Upload Edit uploaded Course Run", null, new string[] {
                        "CI"});
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 44
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper1@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.Given("I have accessed the Bulk Upload fixes page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.When("I click fix against the first Course Run i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.When("I edit bulk upload course cost 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
 testRunner.Then("I click on Cancel to cancel edit course run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.Then("I am on the Fix and publish bulk upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-7224 Bulk Upload Save Course Edit")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_7224BulkUploadSaveCourseEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-7224 Bulk Upload Save Course Edit", null, new string[] {
                        "CI"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 56
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper5@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 59
 testRunner.Given("I have accessed the Bulk Upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.When("I click Choose a File BulkUpload_SaveTest.csv to upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.And("I click Upload File leading to course errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.Then("I am on the Fix and publish bulk upload page for a new file upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 63
 testRunner.When("I click fix against the first Course i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.And("I edit bulk upload course description Semi-qualified (people)", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I click to Save the Course details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.Then("I am on the Publish your courses page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.When("I click publish to publish upload courses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
 testRunner.Then("I am on the courses published page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("DFC-7225 Bulk Upload Save Course Run Edit")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void DFC_7225BulkUploadSaveCourseRunEdit()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("DFC-7225 Bulk Upload Save Course Run Edit", null, new string[] {
                        "CI"});
#line 71
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 72
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 73
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper5@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 75
 testRunner.Given("I have accessed the Bulk Upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.When("I click Choose a File BulkUpload_SaveTest2.csv to upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 77
 testRunner.And("I click Upload File leading to course errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.Then("I am on the Fix and publish bulk upload page for a new file upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.When("I click fix against the first Course i want edit and save", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.When("I edit bulk upload course cost 9", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.And("I click to Save the Course Run details", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.Then("I am on the Publish your courses page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 83
 testRunner.When("I click publish to publish upload courses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 84
 testRunner.Then("I am on the courses published page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-765 Field Validations")]
        [NUnit.Framework.CategoryAttribute("CI")]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_AttendancePatternNone.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_CostformatInvalid.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_CostorCostDescNone.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_DurationInvalid.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_URLInvalid.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_StartDateDDInvalid.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_StartDatePast.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_StartDateFuture.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_NoStudyMode.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_attendancemissing.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_DateNone.csv", null)]
        [NUnit.Framework.TestCaseAttribute("BulkUpload_DeliveryModeNone.csv", null)]
        public virtual void COUR_765FieldValidations(string file, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "CI"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-765 Field Validations", null, @__tags);
#line 87
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 88
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 89
 testRunner.And("I login as provider admin with ncscoursedirectoryprovsuper3@guerrillamail.com  an" +
                    "d Password1!!!", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.Then("I am logged in as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.Given("I have accessed the Bulk Upload page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
 testRunner.When(string.Format("I click Choose a File {0} to upload", file), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 93
 testRunner.And("I click Upload File leading to course errors", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.Then("I am on the Fix and publish bulk upload page for a new file upload", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

