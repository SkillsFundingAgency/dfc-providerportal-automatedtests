using System;
using TechTalk.SpecFlow;
using UITesting.ProviderPortal.TestSupport;
using UITesting.Framework.Helpers;
using UITesting.ProviderPortal.Pages.Course_Management;

namespace UITesting.ProviderPortal.StepDefinitions.Course_Management
{
    [Binding]
    public class DFC_6188ViewCourseRunDetailsLine2Steps :BaseTest
    {
        [Given(@"I am on Your Course Screen Line Two")]
        public void GivenIAmOnYourCourseScreenLineTwo()
        {
            webDriver.Url = TestSupport.Configurator.GetConfiguratorInstance().GetYourCoursesUrl();
        }

        [Then(@"I would see a text input box with title ""(.*)""")]
        public void ThenIWouldSeeATextInputBoxWithTitle(string courseLabel)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
           // viewYourCoursesPage.courseNameLabelText(courseLabel);
        }
        
        [Then(@"The ""(.*)"" text input box should have a dropdown")]
        public void ThenTheTextInputBoxShouldHaveADropdown(string dropDown)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
            //viewYourCoursesPage.checkDropDownBoxes(dropDown);
        }
        
        [Then(@"I would see a title ""(.*)""")]
        public void ThenIWouldSeeATitle(string hyperlink)
        {
            ViewYourCoursesPage viewYourCoursesPage = new ViewYourCoursesPage(webDriver);
          //  viewYourCoursesPage.checkhyperLinkTitle(hyperlink);
        }
        
        [Then(@"The ""(.*)"" should have a hyperlink ""(.*)""")]
        public void ThenTheShouldHaveAHyperlink(string p0, string p1)
        {
            //automated in another story
        }
        
       
    }
}
