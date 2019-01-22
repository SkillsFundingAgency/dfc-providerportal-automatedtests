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
        //accordian function
        public By accordianMainOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[2]/div/h2[*]");               //* - array id
        private By accordianQualOpenIconXPath = By.XPath("//*[@id='main-content']/div/div/div[2]/div/div[*]/ul/li[1]/h3");  //* - array id
        
 
        static int runningTotalRuns;
        static int runningTotalByQual;


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
            // this is no longer useful
            String courseRunCount = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

        }

        public void AddCourseRunsCourseLevel()
        {

            // retrieve the number of course runs as displayed
            String courseRunCount = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            int runningTotalRuns = 0;
            int thisRunNumber = 0;
            int grandTotalRunsShown = 0;


            String firstPartOfField = "";

            //Get all the matching Run Numbers into ILists
            IList<IWebElement> subTotals = webDriver.FindElements(By.XPath("//*[@id='main-content']/div/div/div[2]/div/ul[*]/li[2]/span"));



            //Convert the substring Texts (x) to int x
            String sumTotalRunsShownString = subTotals[0].Text.Substring(1, 1);

            try
            {
                grandTotalRunsShown = Int32.Parse(sumTotalRunsShownString);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            //Add up Run sub-totals by course eg; HND in Maths, etc

            String runsForIndividualCourse;

            int i = 0;  //add-subTotals - ignore £ values
            foreach (IWebElement webElement in subTotals)
            {
                firstPartOfField = subTotals[i].Text.Substring(0, 1);

                if (firstPartOfField.Equals("("))   //assume totals are in brackets eg (3) 
                {
                    runsForIndividualCourse = subTotals[i].Text.Substring(1, 1);

                    try
                    {
                        thisRunNumber = Int32.Parse(runsForIndividualCourse);
                        //Console.WriteLine("This Course Total:" + thisRunNumber);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    runningTotalRuns = runningTotalRuns + thisRunNumber;
                }

                i++;
            }

            Console.WriteLine("Number of runs found by Course=" + runningTotalRuns);


        }





        public void AddCourseRunsQualLevel()
        {

            // retrieve the number of course runs as displayed
            String courseRunCount = (FormCompletionHelper.StoreObjectText(firstCourseRunsCount));

            int runningTotalByQual = 0;
            int thisRunNumber = 0;
            int grandTotalRunsShown = 0;

            String firstPartOfField = "";

            //Get all the matching Run Numbers into ILists
            IList<IWebElement> mainTotals = webDriver.FindElements(By.XPath("//*[@id='main-content']/div/div/div[2]/div/span"));



            //Convert the substring Texts (x) to int x
            String sumTotalRunsShownString = mainTotals[0].Text.Substring(1, 1);

            try
            {
                grandTotalRunsShown = Int32.Parse(sumTotalRunsShownString);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }


            //Add up main Run totals by Qualification Type eg; Degree, Diploma

            String runsByQualificationType;

            int j = 0;  //add-mainTotals - ignore £ values
            foreach (IWebElement webElement in mainTotals)
            {
                firstPartOfField = mainTotals[j].Text.Substring(0, 1);

                if (firstPartOfField.Equals("("))   //assume totals are in brackets eg (3) 
                {
                    runsByQualificationType = mainTotals[j].Text.Substring(1, 1);

                    try
                    {
                        thisRunNumber = Int32.Parse(runsByQualificationType);
                        //Console.WriteLine("This Qual Total:" + thisRunNumber);
                    }
                    catch (FormatException e)
                    {
                    Console.WriteLine(e.Message);
                    }

                runningTotalByQual = runningTotalByQual + thisRunNumber;

                }

            j++;

            }

            Console.WriteLine("Number of runs expected by Qual Type=" + runningTotalByQual);


        }

        public void CompareTotals()
        {
            //Compare the 2 run totals are the same
            Console.WriteLine(">>" + runningTotalByQual + " " + runningTotalRuns);
            if (!runningTotalRuns.Equals(runningTotalByQual))
            {
                Assert.Fail("Total runs by Qual Type doesn't match run number by course");
            }
            else if(runningTotalRuns.Equals(runningTotalByQual))
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
            //Thread.Sleep(20000);

        }

    }

}

