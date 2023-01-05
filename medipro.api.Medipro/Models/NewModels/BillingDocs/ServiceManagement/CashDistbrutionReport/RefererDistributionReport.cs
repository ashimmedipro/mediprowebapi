using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport
{
    public class RefererDistributionReportSelect_dt
    {
        public int ac_code { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public int qty { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double refamt { get; set; }
        public double tds { get; set; }
        public double refnet { get; set; }
    }

    public class RefererDistributionReportTotal_dt
    {
        public double refamt { get; set; }
        public double tds { get; set; }
        public double refnet { get; set; }
    }
}