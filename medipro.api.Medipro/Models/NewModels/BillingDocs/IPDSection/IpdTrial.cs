using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class IpdTrial_dt
    {
        public DateTime init { get; set; }
        public int nfirm { get; set; }
        public bool savebill { get; set; }
        public int userid { get; set; }
    }

    public class IpdTrialSelect_dt
    {
        public int serial { get; set; }
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public string pname { get; set; }
        public int days { get; set; }
        public string telephone { get; set; }
        public string contactno { get; set; }
        public string wardno { get; set; }
        public string beno { get; set; }
        public double deposit { get; set; }
        public double amount { get; set; }
        public double due { get; set; }
        public int userid { get; set; }
    }

    public class IpdTrialTotal_dt
    {
        public double deposit { get; set; }
        public double amount { get; set; }
        public double due { get; set; }
    }
}