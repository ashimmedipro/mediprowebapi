using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class RevertDischargePost_dt
    {
        public int firm { get; set; }
        public DateTime ddate { get; set; }
        public string vr_type { get; set; }
    }
}