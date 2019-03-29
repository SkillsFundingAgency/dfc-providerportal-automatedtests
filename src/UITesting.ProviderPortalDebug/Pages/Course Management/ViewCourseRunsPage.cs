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

    public class ViewYourCoursesPage : TestSupport.BasePage
    {
        private static String PAGE_TITLE = "Your courses";
        private static By ViewCourseDescriptionLink = By.XPath("//*[@id='0']");       //first one in list '0'
        private static By showFirstCourseDescriptionPopupLink = By.XPath("//*[@id='0']");
        private static By showSecondCourseDescriptionPopupLink = By.XPath("//*[@id='1']");

        private By courseDescriptionTitle = By.ClassName("govuk-caption-l");
        private By showCourseDescriptionPopupLink = By.LinkText("View course description");
        private By courseDescriptionPopup = By.Id("popup-descript");
        private By firstCourseRunsCount = By.XPath("//*[@id='main-content']/div/div/div[1]/div/div/form/span");
        //accordian function
        public  By accordianMainOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[*]/div/div/h2");              
        private By accordianQualOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[*]/div[1]/div/div/h3");

        private By courseRunRowXPath = By.XPath("//*[contains(@class,'govuk-grid-row course-run-container')]"); 
        static int countOfRunsShown;

        static int mainCourseRunCount;



        public ViewYourCoursesPage(IWebDriver webDriver) : base(webDriver)
        {
            SelfVerify();
        }

        protected override bool SelfVerify()
        {
            PageInteractionHelper.WaitForPageToLoad();
            return PageInteractionHelper.VerifyPageHeading(this.GetPageHeading(), PAGE_TITLE);
        }

        internal void StoreLiveCourseRunCount()
        {

            String mainTotal = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            String mainTotalString = mainTotal.Replace(")", "").Replace("(","").Replace(" ","");

            try
            {
            mainCourseRunCount = Int32.Parse(mainTotalString);
            }
            catch (FormatException e)
            {
            Console.WriteLine(e.Message);
            }

        Console.WriteLine("Main run count: " + mainCourseRunCount);
        }




        public void CompareTotals()
        {
            //Compare the 2 run totals are the same
            //Console.WriteLine(">>" + mainCourseRunCount + " " + countOfRunsShown);
            if (!mainCourseRunCount.Equals(countOfRunsShown))
            {
                Assert.Fail("Total runs shown doesn't match total at top of page");
            }
            else if(mainCourseRunCount.Equals(countOfRunsShown))
            {
                Console.WriteLine("Totals Match OK");
            }
            
        }


        public void OpenMainAccordians()
        {

            PageInteractionHelper.OpenAccordians(accordianMainOpenIconXPath);

        }

        public void OpenQualificationAccordians()
        {

            PageInteractionHelper.OpenAccordians(accordianQualOpenIconXPath);

        }

        public void CountUpAllCourseRunsShown()
        {
            //add up number of course run rows displayed
            IList<IWebElement> courseRunRows = webDriver.FindElements(courseRunRowXPath);
            countOfRunsShown = courseRunRows.Count();

            Console.WriteLine("Counted Runs: " + countOfRunsShown);


        }
        



    }

}

