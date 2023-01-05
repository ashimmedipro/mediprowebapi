using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class TreatmentFormInsert_dt
    {
        public int userid { get; set; }
        public int ipdno { get; set; }
        public DateTime ddate { get; set; }
        public int refid { get; set; }
        public int hospid { get; set; }
        public string bedno { get; set; }
    }

    public class TreatmentFormUpdate_dt
    {
        public int order_id { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }

        public int wardno { get; set; }
        public string consultant_name { get; set; }
        public int hospid { get; set; }
        public string bedno { get; set; }

    }

    public class TreatmentFormGetdata_dt
    {
        public int order_id { get; set; }
        public int userid { get; set; }
        public int wardno { get; set; }
        public string consultant_name { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public string bed_no { get; set; }
        public int age { get; set; }
    }

    public class TreatmentFormDelete_dt
    {
        public int order_id { get; set; }
    }
}