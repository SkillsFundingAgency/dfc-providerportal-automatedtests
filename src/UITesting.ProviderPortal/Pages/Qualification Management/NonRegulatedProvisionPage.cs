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

namespace UITesting.ProviderPortal.Pages.Qualification_Management
{
    public class NonRegulatedProvisionPage : TestSupport.BasePage
    {

        private static String PAGE_TITLE = "Search for a course provision";
        public NonRegulatedProvisionPage(IWebDriver  webDriver): base(webDriver)
        {
            SelfVerify();
        }
        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }
    }
}
