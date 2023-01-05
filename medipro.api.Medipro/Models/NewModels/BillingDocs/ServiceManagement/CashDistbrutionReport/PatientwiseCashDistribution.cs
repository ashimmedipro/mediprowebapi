using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport
{
    public class PatientwiseCashDistribution_dt
    {
        public int hospid { get; set; }
        public string pname { get; set; }
        public double tech_amt { get; set; }
        public double tds_amt { get; set; }
        public double cons_amt { get; set; }
    }
}