using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec
{
    public class AdvanceReceiptPrint_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public float amount { get; set; }
        public string pname { get; set; }
        public string remarks { get; set; }
        public string bs_date { get; set; }
        public string username { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string contact { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }

    }
}