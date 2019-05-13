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
namespace UITesting.ProviderPortal.Features.Apprenticeships
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("COUR-350 SearchApprenticeship")]
    public partial class COUR_350SearchApprenticeshipFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "COUR-350 SearchApprenticeship.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "COUR-350 SearchApprenticeship", "\tAs a User\r\n\tI want the functionality to search for a apprenticeship training \r\n\t" +
                    "so that I can select the appropriate apprenticeship", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 6
#line 7
 testRunner.Given("I have accessed course directory as a provider", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And("I login as admin with user and password", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.Then("I am logged in", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search term")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search term", null, new string[] {
                        "CI"});
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 14
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
 testRunner.When("I use apprenticeship search to search for Plumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search term using apostrophe")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTermUsingApostrophe()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search term using apostrophe", null, new string[] {
                        "CI"});
#line 19
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 20
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
 testRunner.When("I use apprenticeship search to search for Plumber\'s", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search term using space")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTermUsingSpace()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search term using space", null, new string[] {
                        "CI"});
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 26
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.When("I use apprenticeship search to search for information technology", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search term using all Caps")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTermUsingAllCaps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search term using all Caps", null, new string[] {
                        "CI"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 32
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.When("I use apprenticeship search to search for INFORMATION", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 34
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search term using numbers")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTermUsingNumbers()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search term using numbers", null, new string[] {
                        "CI"});
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 38
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 39
 testRunner.When("I use apprenticeship search to search for ICT 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Valid Search terms 3 chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_ValidSearchTerms3Chars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Valid Search terms 3 chars", null, new string[] {
                        "CI"});
#line 43
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 44
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 45
 testRunner.When("I use apprenticeship search to search for plu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Invalid Valid Search term")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_InvalidValidSearchTerm()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Invalid Valid Search term", null, new string[] {
                        "CI"});
#line 49
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 50
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
 testRunner.When("I use apprenticeship search to search for plumber/plumbing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-351 Search for an apprenticeship - Less than 3 chars")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_351SearchForAnApprenticeship_LessThan3Chars()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-351 Search for an apprenticeship - Less than 3 chars", null, new string[] {
                        "CI"});
#line 55
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 56
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 57
 testRunner.When("I use apprenticeship search to search for pl", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-432 Search for an apprenticeship - Search Results")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_432SearchForAnApprenticeship_SearchResults()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-432 Search for an apprenticeship - Search Results", null, new string[] {
                        "CI"});
#line 61
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 62
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 63
 testRunner.When("I use apprenticeship search to search for Plumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 64
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-432 Search for an apprenticeship - Framework Label")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_432SearchForAnApprenticeship_FrameworkLabel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-432 Search for an apprenticeship - Framework Label", null, new string[] {
                        "CI"});
#line 68
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 69
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 70
 testRunner.When("I use apprenticeship search to search for Plumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
 testRunner.And("the Framework label is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("COUR-475 Select an apprenticeship")]
        [NUnit.Framework.CategoryAttribute("CI")]
        public virtual void COUR_475SelectAnApprenticeship()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("COUR-475 Select an apprenticeship", null, new string[] {
                        "CI"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
this.FeatureBackground();
#line 76
 testRunner.Given("I have accessed the Apprenticeship Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 77
 testRunner.When("I use apprenticeship search to search for Plumber", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("the Results are displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.And("the user select the apprenticeship", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

