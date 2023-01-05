using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class BillingSheetInsert_dt
    {
        public int userid { get; set; }
        public int ipdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string bedno { get; set; }
        public int refid { get; set; }
    }

    public class BillingSheetUpdate_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string bedno { get; set; }
        public int refid { get; set; }
    }

    public class BillingSheetGetdata_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
        public string bed_no { get; set; }
        public int ward { get; set; }
        public DateTime ddate { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
    }

    public class BillingSheetDelete_dt
    {
        public int sn { get; set; }
    }
}