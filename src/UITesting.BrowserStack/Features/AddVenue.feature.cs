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
namespace UITesting.BrowserStack.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Add Venue")]
    public partial class AddVenueFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AddVenue.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Add Venue", "As a user\r\nI need to commit the add venue record\r\nso that the new venue record is" +
                    " committed to the CD database", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Add Venue Details")]
        [NUnit.Framework.CategoryAttribute("BrowserStack")]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome69win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome62win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome63win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome69win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win8", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome69win8", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome70macos", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "chrome69macos", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox63win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox62win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox63win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox62win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox63win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox62win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox63osx", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "firefox62osx", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win81", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "ie11win7", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "edge17win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "edge16win10", null)]
        [NUnit.Framework.TestCaseAttribute("parallel", "safari12macos", null)]
        public virtual void AddVenueDetails(string profile, string environment, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BrowserStack"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Venue Details", null, @__tags);
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given(string.Format("I have navigated to the Home page using {0} and {1}", profile, environment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I login as admin with user and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.Then("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.Given("I have searched for UKPRN \"10002815\" and clicked search", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
 testRunner.When("I click to view my courses", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Given("I have navigated to the Your Venues Pages", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 17
 testRunner.When("I click Add Venue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("I am on the Add Venue page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("the Add Venue page displays the expected content", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I enter the following postcode b13 9da", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.And("I click Find Address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.Then("I am on the Select Address page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
 testRunner.When("I select the address 120 Sandford Road Birmingham, B13 9DA", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.And("I enter venue name Test Venue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I click continue to confirm page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.When("I am on the Add Venue Confirm details page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 27
 testRunner.And("On the Confirmation Page I click continue", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
