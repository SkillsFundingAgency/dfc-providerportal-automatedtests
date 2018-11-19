using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UITesting.Framework.Helpers;

namespace UITesting.CourseDirectory.Models
{
    public class Venue
    {
        public string ProviderId=RandomDataGenerator.GenerateRandomAlphanumericString(4);
        public string VenueName = "New Venue";
        public string PostCode = "cv12wt";
         
    }
}
