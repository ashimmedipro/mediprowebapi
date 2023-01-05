using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection
{
    public class DeathCertificateReport_dt
    {
        public string fy { get; set; }
        public string billtime { get; set; }
        public string inv_no { get; set; }
        public string expire_time { get; set; }
        public DateTime ddate { get; set; }
        public DateTime expire_date { get; set; }
        public int ipdno { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public string remarks { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string salute { get; set; }
        public string nominee { get; set; }
        public int refid { get; set; }
        public string note1 { get; set; }
        public string bs_date { get; set; }
        public string pname { get; set; }
        public string bs_expire_date { get; set; }
    }
}