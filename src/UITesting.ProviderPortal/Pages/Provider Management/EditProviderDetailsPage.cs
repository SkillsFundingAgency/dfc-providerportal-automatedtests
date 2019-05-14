using System;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.TestSupport;
using OpenQA.Selenium;


namespace UITesting.ProviderPortal.Pages.Provider_Management
{
    public class EditProviderDetailsPage : BasePage
    {
        private static String PAGE_TITLE = "Edit your details";
        private By aliasName = By.Id("AliasName");
        private By overview = By.Id("BriefOverview");
        private By saveBtn = By.Id("save");
        private By cancelLnk = By.LinkText("Cancel");

        public EditProviderDetailsPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

		public EditProviderDetailsPage EnterAlias(String Alias)
        {
            FormCompletionHelper.EnterText(aliasName, Alias);
            return new EditProviderDetailsPage(webDriver);
        }

        public EditProviderDetailsPage EnterOverview(String Overview)
        {
            FormCompletionHelper.EnterText(overview, Overview);
            return new EditProviderDetailsPage(webDriver);
        }

        public ProviderDetailsPage ClickSave()
        {
            FormCompletionHelper.ClickElement(saveBtn);
            return new ProviderDetailsPage(webDriver);
        }

    }
}