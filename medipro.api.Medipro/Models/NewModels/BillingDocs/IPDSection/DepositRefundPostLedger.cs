using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DepositRefundPostLedger_dt
    {
        public DateTime ad_date { get; set; }
        public string bs_date { get; set; }
        public Boolean posted { get; set; }
    }
}