using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace UITesting.BrowserStack.TestSupport
{
    public abstract class BasePage
    {
        protected IWebDriver webDriver;
	    private readonly By pageHeading = By.CssSelector("h1");

		public BasePage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
            SeleniumExtras.PageObjects.PageFactory.InitElements(webDriver, this);
        }

        protected abstract Boolean SelfVerify();

        protected String GetPageHeading()
        {
			return webDriver.FindElement(pageHeading).GetAttribute("innerText");
		}
	}
}