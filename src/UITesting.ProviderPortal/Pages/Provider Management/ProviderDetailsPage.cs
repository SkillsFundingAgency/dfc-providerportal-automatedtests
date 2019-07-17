using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;


namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class ProviderDetailsPage : BasePage
    {
        private static String PAGE_TITLE = "Search Provider";
        private By SearchField = By.Id("SearchTerm");
        private By contactDetails = By.XPath("/html/body/div[4]/main/div/div[2]");
        private By addAlias = By.XPath(".//*[@id='main-content']/div/div[1]/table/tbody/tr[4]/td[2]/a");
        private By addOverview = By.XPath(".//*[@id='main-content']/div/div[1]/table/tbody/tr[6]/td[2]/a");
        private By editAlias = By.XPath(".//*[@id='main-content']/div/div[1]/table/tbody/tr[4]/td[2]/a");
        private By editOverview = By.XPath(".//*[@id='main-content']/div/div[1]/table/tbody/tr[6]/td[2]/a");

        public ProviderDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            PageInteractionHelper.WaitForPageToLoad();
            //SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public ProviderDetailsPage EnterUKPRN(String UKPRN)
        {
            FormCompletionHelper.EnterText(SearchField, UKPRN);
            return new ProviderDetailsPage(webDriver);
        }

        public AddProviderDetailsPage ClickAddAlias()
        {
            FormCompletionHelper.ClickElement(addAlias);
            return new AddProviderDetailsPage(webDriver);
        }

        public AddProviderDetailsPage ClickAddOverview()
        {
            FormCompletionHelper.ClickElement(addOverview);
            return new AddProviderDetailsPage(webDriver);
        }

        public EditProviderDetailsPage ClickEditAlias()
        {
            FormCompletionHelper.ClickElement(editAlias);
            return new EditProviderDetailsPage(webDriver);
        }

        public EditProviderDetailsPage ClickEditOverview()
        {
            FormCompletionHelper.ClickElement(editOverview);
            return new EditProviderDetailsPage(webDriver);
        }

    }
}