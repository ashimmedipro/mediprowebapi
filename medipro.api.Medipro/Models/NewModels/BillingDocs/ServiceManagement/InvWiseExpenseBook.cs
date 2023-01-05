using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class InvWiseExpenseBook_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string vr_no { get; set; }
        public string inv_no { get; set; }
        public float amount { get; set; }
        public string paymentfrom { get; set; }
        public string pname { get; set; }
    }
}