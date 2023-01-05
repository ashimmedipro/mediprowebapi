using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class LamaFormInsert_dt
    {
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int bed_no { get; set; }
        public int refid { get; set; }
        public int userid { get; set; }
        public DateTime date { get; set; }
        public TimeSpan ttime { get; set; }
    }

    public class LamaFormUpdate_dt
    {
        public int lama_id { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int bed_no { get; set; }
        public int refid { get; set; }
        public int userid { get; set; }
        public DateTime date { get; set; }
        public TimeSpan ttime { get; set; }
    }

    public class LamaFormGetdata_dt
    {
        public int lama_id { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public string patient_name { get; set; }
        public string address { get; set; }
        public string bed_no { get; set; }
        public int refid { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
    }

    public class LamaFormDelete_dt
    {
        public int lama_id { get; set; }
    }
}