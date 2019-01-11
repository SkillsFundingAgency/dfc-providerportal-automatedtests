using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.ProviderPortal.Pages.Course_Management
{

    public class ViewCourseRunsPage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Your courses";
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='0']");       //first one in list '0'
        private static By showFirstCourseDescriptionPopupLink = By.XPath("//*[@id='0']");
        private static By showSecondCourseDescriptionPopupLink = By.XPath("//*[@id='1']");
        //elt added - View Description..
        private By courseDescriptionTitle = By.ClassName("govuk-caption-l");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");
        private By courseDescriptionPopup = By.Id("popup-descript");
        private By firstCourseRunsCount = By.XPath("//*[@id='main-content']/div/div/div[2]/div/ul/li[2]/span");


        public ViewCourseRunsPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void StoreLiveCourseRunCount()
        {

            // retrieve the number of course runs as displayed
            String courseRunCount = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            Console.WriteLine("Course Runs for first course: " + courseRunCount);

        }

        internal void NumberOfDisplayedCourseRuns()
        {

            // retrieve the number of course runs as displayed
            String courseRunCount = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            Console.WriteLine("Course Runs for first course: " + courseRunCount);

        }
    }
}

