using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class RefererVsCashDistribution_dt
    {
        public int refid { get; set; }
        public string referer { get; set; }
        public double tech_amt { get; set; }
        public double income { get; set; }
        public double billamt { get; set; }
    }
}