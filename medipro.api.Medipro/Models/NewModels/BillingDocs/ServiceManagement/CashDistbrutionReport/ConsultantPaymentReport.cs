using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport
{
    public class ConsultantPaymentReportSelect_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string vr_no { get; set; }
        public string fy { get; set; }
        public int firm { get; set; }
        public string billtime { get; set; }
        public decimal paid_amount { get; set; }
        public int userid { get; set; }
        public int cons_code { get; set; }
        public int bank_code { get; set; }
        public int ac_code { get; set; }
        public decimal amount { get; set; }
        public string naration { get; set; }
        public int dp_id { get; set; }
        public decimal net { get; set; }
        public string particular { get; set; }
    }

    public class ConsultantPaymentReportTotal_dt
    {
        public decimal paid_amount { get; set; }
        public decimal adjust { get; set; }
        public decimal net { get; set; }
    }
}