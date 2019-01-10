using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITesting.CourseDirectory
{
    public class ProviderClass
    {
        private static ProviderClass ProviderInstance = null;
        private readonly String email;
        private readonly string website;
        private ProviderClass()
        {
            email = "Email";
            website = "Website";
        }

        public string GetEmail()
        {
            return email; ;
        }
        public string GetWebsite()
        {
            return website; 
        }
        public static ProviderClass GetProviderInstance()
        {
            if (ProviderInstance == null)
            {
                ProviderInstance = new ProviderClass();
            }
            return ProviderInstance;
        }
        public string EmailValue { get; set; }
        public string WebsiteValue { get; set; }

    }
}
