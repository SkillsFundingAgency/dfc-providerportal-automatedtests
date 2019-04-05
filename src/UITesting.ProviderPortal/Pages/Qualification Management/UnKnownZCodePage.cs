using OpenQA.Selenium;
using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using System.Web;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;

namespace UITesting.ProviderPortal.Pages.Qualification_Management
{
    public class UnKnownZCodePage : BasePage 
    {
        private static String PAGE_TITLE = "Choose a non-regulated provision";
        public UnKnownZCodePage(IWebDriver webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
    }
}
