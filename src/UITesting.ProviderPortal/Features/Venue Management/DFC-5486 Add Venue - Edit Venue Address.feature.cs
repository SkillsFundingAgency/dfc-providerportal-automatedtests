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
namespace UITesting.ProviderPortal.Features.VenueManagement
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("DFC-5486 Add Venue - Edit Venue Address")]
    public partial class DFC_5486AddVenue_EditVenueAddressFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DFC-5486 Add Venue - Edit Venue Address.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DFC-5486 Add Venue - Edit Venue Address", "\tIn order to alter a provisionally entered address \r\n\tAs a provider user when Add" +
                    "ing a Venue\r\n\tI want to be able to edit Venue Address", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Change address manually during Add Venue")]
        [NUnit.Framework.CategoryAttribute("add_venue")]
        public virtual void ChangeAddressManuallyDuringAddVenue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change address manually during Add Venue", null, new string[] {
                        "add_venue"});
#line 9
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 10
 testRunner.Given("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 11
 testRunner.And("I am on the address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.When("I press edit address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 13
 testRunner.Then("I am taken to the change address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And("I can change the address manually", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 15
 testRunner.And("my new address is shown on address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Change address using postcode during Add Venue")]
        [NUnit.Framework.CategoryAttribute("add_venue")]
        public virtual void ChangeAddressUsingPostcodeDuringAddVenue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Change address using postcode during Add Venue", null, new string[] {
                        "add_venue"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 21
 testRunner.Given("I have entered an address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("I am on the address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.When("I press edit address", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
 testRunner.Then("I am taken to the change address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("my new address is shown on address screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion