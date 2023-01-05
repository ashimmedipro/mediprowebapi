using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection
{
    public class PrescriptionGenerateList_dt
    {
      
            public int servid { get; set; }
            public string inv_no { get; set; }
            public int hospid { get; set; }
            public string pname { get; set; }
            public string sex { get; set; }
            public float ageday { get; set; }
            public int userid { get; set; }
            public DateTime ddate { get; set; }
            public string bs_date { get; set; }
            public int consid { get; set; }
            public string referer { get; set; }
            public string servname { get; set; }
            public DateTime dob { get; set; }
        
    }
}