using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DischargeReport_dt
    {
        public string dischargeno { get; set; }
        public DateTime ddate { get; set; }
        public int ipdno { get; set; }
        public int ac_code { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public double paid { get; set; }
        public double deposit { get; set; }
        public double tender { get; set; }
        public bool member { get; set; }
        public string p_type { get; set; }
        public string billtime { get; set; }
        public int refid { get; set; }
        public string fy { get; set; }
        public bool posted { get; set; }
        public bool canceled { get; set; }
        public string remarks { get; set; }
        public string refund_no { get; set; }
        public string discharge_type { get; set; }
        public double discount { get; set; }
        public double paid_amount { get; set; }
        public double ledgerpc { get; set; }
        public double insurance_amount { get; set; }
        public double insurance_due_amount { get; set; }
        public bool insurance { get; set; }
        public bool ssf { get; set; }
        public int cardid { get; set; }
        public string bs_date { get; set; }
        public string pname { get; set; }
        public double net { get; set; }
        public double due { get; set; }
        public DateTime admit_date { get; set; }
        public string bs_admit_date { get; set; }
        public int days { get; set; }
        public string icdcode { get; set; }
    }

    public class DischargeReportCount_dt
    {
        public int cnt { get; set; }
        public double totamount { get; set; }
        public double totdeposit { get; set; }
        public double totpaid { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double due { get; set; }
    }
}