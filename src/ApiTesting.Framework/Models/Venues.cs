using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTesting.Framework.Models
{
    public class Venues
    {
        public string odatacontext { get; set; }
        public SearchNextpageparameters searchnextPageParameters { get; set; }
        public VenueValue[] value { get; set; }
        public string odatanextLink { get; set; }
    }

    //public class SearchNextpageparameters
    //{
    //    public string search { get; set; }
    //    public int skip { get; set; }
    //}

    public class VenueValue
    {   public string UKPRN { get; set; }
        //public float searchscore { get; set; }
        //public string LearnAimRef { get; set; }
        //public string LearnAimRefTitle { get; set; }
        //public string NotionalNVQLevelv2 { get; set; }
        //public string AwardOrgCode { get; set; }
        //public string LearnDirectClassSystemCode1 { get; set; }
        //public string LearnDirectClassSystemCode2 { get; set; }
        //public string SectorSubjectAreaTier1 { get; set; }
        //public string SectorSubjectAreaTier2 { get; set; }
        //public string GuidedLearningHours { get; set; }
        //public string TotalQualificationTime { get; set; }
        //public string UnitType { get; set; }
        //public string AwardOrgName { get; set; }
    }

}



