using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport
{
    public class ServiceGroupwiseReport_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int qty { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double techamt { get; set; }
        public float expenses { get; set; }
        public double hospital { get; set; }
    }
}