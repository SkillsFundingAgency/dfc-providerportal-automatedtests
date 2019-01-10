using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.CourseDirectory.Models
{
    public class Apprenticeships
    {
        /*Web Element Variables*/
        public string APPRENTICESHIPS_MENU = "/html/body/div[2]/div[2]/div[3]/div/ul/li[3]/a";
        public string APPRENTICESHIPS_LOCATIONS = "//a[@href='/Location/List']";
        public string ALL_APPRENTICESHIPS_TITLE_TEXT = "/html/body/div[3]/div[1]/div[1]/h2";
        public string CREATE_APPRENTICESHIPS_LOCATION= "//a[@href='/Location/Create']";

        public void Apprenticeships_Table()
        {
            
            
        }
    }
}
