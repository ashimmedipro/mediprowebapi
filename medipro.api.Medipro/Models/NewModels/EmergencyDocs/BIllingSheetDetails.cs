using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class BillingSheetDetailsInsert_dt
    {
        public int sn { get; set; }
        public string title { get; set; }
        public long result { get; set; }
    }


    public class BillingSheetDetailsUpdate_dt
    {
        public int sn { get; set; }
        public string title { get; set; }
        public string result { get; set; }
    }

    public class BillingSheetDetailsGetdata_dt
    {
        public int ssn { get; set; }
        public int sn { get; set; }
        public string title { get; set; }
        public string result { get; set; }
    }
    public class BillingSheetDetailsDelete_dt
    {
        public int sn { get; set; }

    }
}