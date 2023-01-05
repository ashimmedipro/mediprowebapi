using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class BedTransferReport_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public int ipdno { get; set; }
        public string pname { get; set; }
        public string bedno { get; set; }
        public string old_bed { get; set; }
    }
}