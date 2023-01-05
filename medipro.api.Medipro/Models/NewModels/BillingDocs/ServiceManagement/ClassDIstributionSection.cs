using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class ServiceWiseCashDist_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public bool postledger { get; set; }
        public bool posted { get; set; }
    }

    public class ServiceNameGet_dt
    {
        public int sn { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double disc { get; set; }
        public double net { get; set; }
        public string ty { get; set; }
        public int sn1 { get; set; }
    }

    public class ParticularGetbyId_dt
    {
        public int sn { get; set; }
        public int cons_code { get; set; }
        public string particular { get; set; }
        public double pc { get; set; }
        public double tech_amt { get; set; }
        public double tds_amt { get; set; }
        public double cons_amt { get; set; }
    }

}