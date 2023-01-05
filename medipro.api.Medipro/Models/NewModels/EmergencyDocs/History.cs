using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class HistoryInsert_dt
    {
        public int ipdno { get; set; }
        public int userid { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate{ get; set; }
        public int hospid { get; set; }
        public int refid { get; set; }
    }

    public class HistoryUpdate_dt
    {
        public int his_id { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int refid { get; set; }
    }

    public class HistoryGetdata_dt
    {
        public int his_id { get; set; }
        public int ipdno { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public string bed_no { get; set; }
        public int hospid { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public int refid { get; set; }
    }

    public class HistoryDelete_dt
    {
        public int his_id { get; set; }
    }
}