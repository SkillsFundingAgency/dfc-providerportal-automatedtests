using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;


namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class AddProviderDetailsPage : BasePage
    {
        private static String PAGE_TITLE = "Edit your details";
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
            ((IJavaScriptExecutor)this.webDriver).ExecuteScript("tinyMCE.activeEditor.setContent('<h1>Native API text</h1> TinyMCE')");
            return new AddProviderDetailsPage(webDriver);
        }

        public ProviderDetailsPage ClickSave()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            PageInteractionHelper.WaitForPageToLoad();
            return new ProviderDetailsPage(webDriver);
        }

        public ProviderDetailsPage ClickSaveError()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            return new ProviderDetailsPage(webDriver);
        }

    }
}