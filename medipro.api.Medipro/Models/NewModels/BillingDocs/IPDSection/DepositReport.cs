using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DepositReportSelect_dt
    {
        public string fy { get; set; }
        public string inv_no { get; set; }
        public int ipdno { get; set; }
        public double amount { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public bool posted { get; set; }
        public int firm { get; set; }
        public DateTime ddate { get; set; }
        public string p_type { get; set; }
        public int cardid { get; set; }
        public int ac_code { get; set; }
        public string pname { get; set; }
        public string bs_date { get; set; }
        public string username { get; set; }
    }

    public class DepositReportGetTotal_dt
    {
        public double total { get; set; }
    }
}