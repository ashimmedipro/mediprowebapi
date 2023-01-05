using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class AnaesthesiaRecordInsert_dt
    {
        public int ipdno { get; set; }
        public int refid { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string consultant_name { get; set; }
        public DateTime ddate { get; set; }
        public string bed_no { get; set; }
        public int ward { get; set; }
        public double weight { get; set; }
    }

    public class AnaesthesiaRecordUpdate_dt
    {
        public int record_id { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string consultant_name { get; set; }
        public DateTime ddate { get; set; }
        public string bed_no { get; set; }
    }

    public class AnaesthesiaRecordGetdata_dt
    {
        public int ipdno { get; set; }
        public int refid { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string consultant_name { get; set; }
        public string bed_no { get; set; }
        public int ward { get; set; }
        public double weight { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }

    public class AnaesthesiaRecordDelete_dt
    {
        public int record_id { get; set; }
    }
}