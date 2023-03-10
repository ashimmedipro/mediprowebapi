using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class CreditNoteEntry_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public string cr_no { get; set; }
        public int hospid { get; set; }
        public int pt_code { get; set; }
        public double amount { get; set; }
        public double vat { get; set; }
        public double discount { get; set; }
        public double cc_charge { get; set; }
        public double cc_free { get; set; }
        public int ac_code { get; set; }
        public string naration { get; set; }
        public int rep_code { get; set; }
        public int user { get; set; }
        public string note { get; set; }
        public int firm { get; set; }
        public string billtime { get; set; }
        public string salestype { get; set; }
        public int comp_code { get; set; }
        public string series { get; set; }
        public bool member { get; set; }
        public bool posted { get; set; }
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public double scheme { get; set; }
        public int vat_type { get; set; }
        public int sm_code { get; set; }
        public bool opd { get; set; }
        public double paid { get; set; }
        public double rd { get; set; }
        public double claim { get; set; }
        public double extra { get; set; }
        public int dp_id { get; set; }
        public int dm_code { get; set; }
        public bool department { get; set; }
        public double taxable_amount { get; set; }
        public double roundoff { get; set; }
        public string bedno { get; set; }
        public string prev_no { get; set; }
        public bool New { get; set; }
        public int div_id { get; set; }
        public double prev_amount { get; set; }

    }
}