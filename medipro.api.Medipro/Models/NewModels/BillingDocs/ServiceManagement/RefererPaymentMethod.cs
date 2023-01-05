using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class RefererPaymentMethod_dt
    {
        public string paid_vr_no { get; set; }
        public DateTime paid_date { get; set; }
        public string bs_date { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public double paid { get; set; }
    }


}