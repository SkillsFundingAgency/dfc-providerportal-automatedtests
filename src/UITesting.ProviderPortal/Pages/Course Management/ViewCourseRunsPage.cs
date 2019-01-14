using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;
using System.Collections;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

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
        private By firstCourseRunsCount = By.XPath("//*[@id='main-content']/div/div/div[2]/div/span");


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


            int runningTotalRuns = 0;
            int thisRunNumber = 0;
            int grandTotalRunsShown = 0;
            String firstPartOfField = "";


            IList<IWebElement> all = webDriver.FindElements(By.ClassName("govuk-body"));

            String totalRunsShownString = all[0].Text.Substring(1,1);
            //Console.WriteLine("Total Runs:" + totalRunsShownString);

            try
            {
                grandTotalRunsShown = Int32.Parse(totalRunsShownString);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            String runsForIndividualCourse;

            int i = 0;  //start after total and ignore £ values
            foreach (IWebElement webElement in all)
            {
                firstPartOfField = all[i].Text.Substring(0, 1);
 

                if (firstPartOfField.Equals("(") && i>0)   //assume totals are in brackets eg (3) and ignore main total
                {
                    runsForIndividualCourse = all[i].Text.Substring(1, 1);
                    
                    try
                    {
                        thisRunNumber = Int32.Parse(runsForIndividualCourse);

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    runningTotalRuns = runningTotalRuns + thisRunNumber;
                }

                i++;
            }

            Console.WriteLine("Grand total added up=" + runningTotalRuns);

            if (!runningTotalRuns.Equals(grandTotalRunsShown))
                {
                Assert.Fail("Total runs at top of screen doesn't match sub totals");
                }

        }
    }
}

