using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EMRDocs
{
    public class AdmissionFormDetailSelect_dt
    {
        public int sn { get; set; }
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string patient_name { get; set; }
        public string marital_status { get; set; }
        public string occupation { get; set; }
        public string full_address { get; set; }
    }
}