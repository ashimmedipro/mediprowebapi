using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.ServiceMasterSetup
{
    public class DiscountNameSelect_dt
    {
        public int discount_id { get; set; }
        public string discount_name { get; set; }
        public string status { get; set; }
        public bool notify { get; set; }
        public string type { get; set; }
        public double pharmacy_disc { get; set; }
        public double minimum_amount { get; set; }
        public double pharmacy_amount { get; set; }
        public int sn { get; set; }
    }

    public class DiscountName_dt
    {
        public int discount_id { get; set; }
        public string discount_name { get; set; }
        public string status { get; set; }
        public bool notify { get; set; }
        public string type { get; set; }
        public double pharmacy_disc { get; set; }
        public double min_amt { get; set; }
        public double pharmacy_amt { get; set; }
    }



}