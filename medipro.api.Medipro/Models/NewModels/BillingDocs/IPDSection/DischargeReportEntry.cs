using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DischargeReportEntry_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public DateTime ad_admit_date { get; set; }
        public string bs_admit_date { get; set; }
        public DateTime discharge_date { get; set; }
        public string bs_discharge_date { get; set; }
        public int ipdno { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string sex { get; set; }
        public string bedno { get; set; }
        public int age { get; set; }
    }
}