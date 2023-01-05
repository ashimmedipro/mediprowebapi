using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class IpdRegistrationRegisterSelectByDateRange_dt
    {
        public string ward { get; set; }
        public string bedno { get; set; }
        public DateTime ddate { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int fileno { get; set; }
        public string pname { get; set; }
        public string telephone { get; set; }
        public int refid { get; set; }
        public bool member { get; set; }
        public bool discharge { get; set; }
        public string referer { get; set; }
        public string bs_date { get; set; }
        public double deposit { get; set; }
    }

    public class IpdRegistrationRegisterCountSelectByDateRange_dt
    {
        public int cnt { get; set; }

    }
}