using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;


namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class AddProviderDetailsPage : BasePage
    {
        private static String PAGE_TITLE = "Add your details";
        private By aliasName = By.Id("AliasName");
        private By overview = By.Id("BriefOverview");
        private By saveBtn = By.Id("save");
        private By cancelLnk = By.LinkText("Cancel");

        public AddProviderDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public AddProviderDetailsPage EnterAlias(String Alias)
        {
            FormCompletionHelper.EnterText(aliasName, Alias);
            return new AddProviderDetailsPage(webDriver);
        }

        public AddProviderDetailsPage EnterOverview(String Overview)
        {
            FormCompletionHelper.EnterText(overview, Overview);
            return new AddProviderDetailsPage(webDriver);
        }

        public ProviderDetailsPage ClickSave()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            return new ProviderDetailsPage(webDriver);
        }

        public AddProviderDetailsPage ClickSaveError()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            return new AddProviderDetailsPage(webDriver);
        }

    }
}