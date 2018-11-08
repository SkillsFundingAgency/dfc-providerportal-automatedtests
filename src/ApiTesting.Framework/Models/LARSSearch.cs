using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.Framework.Models
{
    public class LARSSearch
    {
        public string search { get; set; }
        public string[] facets { get; set; }
        public bool count { get; set; }
        public string filter { get; set; }
    }

}


