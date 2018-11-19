using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Models
{
    public class Courses
    {
        public string Course_Title = "Selenium Fundamentals";
        public string Course_Id = RandomDataGenerator.GenerateRandomNumber(5);
        public string Course_Summary = "Basic Selenium";
        //public string Course_URL = RandomDataGenerator.GenerateRandomWebsiteString();
        public string Course_URL = "www.gov.uk";
        public string Course_Entry = "A-Level";
        public int Course_LARS_No = 60094321;
    }
}
