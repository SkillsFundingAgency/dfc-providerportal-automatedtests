using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UITesting.CourseDirectory.Pages
{
    public class WelcomePage : BasePage
    {
        public WelcomePage(IWebDriver webDriver):base(webDriver)
        {
           // SelfVerify();
        }
       /* protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }*/
    }
}
