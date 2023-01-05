using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvanceClear
{
    public class AdvanceClearSelect_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public float amount { get; set; }
        public float paid { get; set; }
        public string remarks { get; set; }
        public string billtime { get; set; }
        public int user { get; set; }
        public int user1 { get; set; }
        public string contact { get; set; }
        public int hospid1 { get; set; }
        public string inv_no { get; set; }
        public DateTime clear_date { get; set; }
        public bool posted { get; set; }
        public bool clear_posted { get; set; }
        public int ac_code { get; set; }
        public string p_type { get; set; }
        public string pname { get; set; }
    }

    public class AdvanceClearUpdate_dt
    {
        public int sn { get; set; }
        public float amount { get; set; }
        public int user1 { get; set; }
        public DateTime clear_date { get; set; }
    }
}