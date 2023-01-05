using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class templedger1_dt
    {
        public double serial { get; set; }
        public float ac_code { get; set; }
        public float sn { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string nv { get; set; }
        public string inv_no { get; set; }
        public string vr_no { get; set; }
        public string naration { get; set; }
        public float debit { get; set; }
        public float credit { get; set; }
        public string balance { get; set; }
        public string mark { get; set; }
        public string compname { get; set; }
        public DateTime inv_date { get; set; }
    }

    public class templedger1_Delete_dt
    {
        public double serial { get; set; }
    }
}