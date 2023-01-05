using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.DueSection
{
    public class OpdBillReport_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string inv_no { get; set; }
        public double paid { get; set; }
        public double amt { get; set; }
        public double net { get; set; }
        public double invamt { get; set; }
        public double due { get; set; }
        public string username { get; set; }

    }

    public class OpdBillReportSum_dt
    {
        public double amt { get; set; }
        public double net { get; set; }
        public double due { get; set; }
        public double paid { get; set; }
    }
}