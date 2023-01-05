using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class CashDistributionReport_dt
    {
        
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
        public bool ipd { get; set; }
    }

    public class CashDistributionTotal_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }
}