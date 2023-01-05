using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class ConsentFormInsert_dt
    {
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public string bed_no { get; set; }
        public int refid { get; set; }
    }

    public class ConsentFormUpdate_dt
    {
        public string consent_id { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public string bed_no { get; set; }
        public int refid { get; set; }
    }

    public class ConsentFormGetdata_dt
    {
        public string consent_id { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string bed_no { get; set; }
        public string full_name { get; set; }
        public string address { get; set; }
    }

    public class ConsentFormDelete_dt
    {
        public string consent_id { get; set; }
    }
}