using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.Pages.Provider_Management;


namespace UITesting.ProviderPortal.StepDefinitions
{
    [Binding]
    public class ProviderSteps : TestSupport.BaseTest
    {
        [Given(@"I have navigated to the Provider Details Page")]
        public void GivenIAmOnSearchAProviderPage()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetBaseUrl() + "/Provider/Details";
        }

        
        [Then(@"I am taken to the provider details page")]
        public void ThenIAmTakenToTheProviderDetailsPage()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
        }


        [When(@"i click add alias")]
        public void WhenIClickAddAlias()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
            providerDetailsPage.ClickAddAlias();
        }

        [When(@"i click add overview")]
        public void WhenIClickAddOverview()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
            providerDetailsPage.ClickAddOverview();
        }

        [Then(@"I enter alias (.*)")]
        public void ThenIEnterAlias(string alias)
        {
            AddProviderDetailsPage addProviderDetailsPage = new AddProviderDetailsPage(webDriver);
            addProviderDetailsPage.EnterAlias(alias);
        }

        [Then(@"I enter overview (.*)")]
        public void ThenIEnterOverview(string overview)
        {
            AddProviderDetailsPage addProviderDetailsPage = new AddProviderDetailsPage(webDriver);
            addProviderDetailsPage.EnterOverview(overview);
        }

        [Then(@"I click Save on Add provider details page")]
        public void ThenIClickSave()
        {
            AddProviderDetailsPage addProviderDetailsPage = new AddProviderDetailsPage(webDriver);
            addProviderDetailsPage.ClickSave();
        }

        [Then(@"I click Save on Add provider details page leading to error")]
        public void ThenIClickSaveOnAddProviderDetailsPageLeadingToError()
        {
            AddProviderDetailsPage addProviderDetailsPage = new AddProviderDetailsPage(webDriver);
            addProviderDetailsPage.ClickSaveError();
        }


        [When(@"i click edit alias")]
        public void WhenIClickEditAlias()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
            providerDetailsPage.ClickEditAlias();
        }

        [When(@"i click edit overview")]
        public void WhenIClickEditOverview()
        {
            ProviderDetailsPage providerDetailsPage = new ProviderDetailsPage(webDriver);
            providerDetailsPage.ClickEditOverview();
        }

        [Then(@"I edit alias (.*)")]
        public void ThenIEditAlias(string alias)
        {
            EditProviderDetailsPage editProviderDetailsPage = new EditProviderDetailsPage(webDriver);
            editProviderDetailsPage.EnterAlias(alias);
        }

        [Then(@"I edit overview (.*)")]
        public void ThenIEditOverview(string overview)
        {
            EditProviderDetailsPage editProviderDetailsPage = new EditProviderDetailsPage(webDriver);
            editProviderDetailsPage.EnterOverview(overview);
        }

        [Then(@"I click Save on Edit provider details page")]
        public void ThenIClickSaveEdit()
        {
            EditProviderDetailsPage editProviderDetailsPage = new EditProviderDetailsPage(webDriver);
            editProviderDetailsPage.ClickSave();
        }

    }
}
