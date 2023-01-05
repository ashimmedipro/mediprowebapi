using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Crnote_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public string cr_no { get; set; }
        public int hospid { get; set; }
        public int pt_code { get; set; }
        public string name { get; set; }
        public string reg_no { get; set; }
        public float amount { get; set; }
        public float vat { get; set; }
        public float discount { get; set; }
        public float cc_charge { get; set; }
        public float cc_free { get; set; }
        public string vr_no { get; set; }
        public int ac_code { get; set; }
        public string naration { get; set; }
        public int rep_code { get; set; }
        public int user { get; set; }
        public string note { get; set; }
        public int firm { get; set; }
        public string vr_type { get; set; }
        public string billtime { get; set; }
        public string salestype { get; set; }
        public int comp_code { get; set; }
        public string series { get; set; }
        public string remarks { get; set; }
        public bool member { get; set; }
        public bool posted { get; set; }
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public float scheme { get; set; }
        public int vat_type { get; set; }
        public int sm_code { get; set; }
        public bool opd { get; set; }
        public double paid { get; set; }
        public double rd { get; set; }
        public double claim { get; set; }
        public double extra { get; set; }
        public int dp_id { get; set; }
        public bool department { get; set; }
        public int dm_code { get; set; }
        public double roundoff { get; set; }
        public double taxable_amount { get; set; }
        public bool settle { get; set; }
        public double settle_amount { get; set; }
        public string bedno { get; set; }
        public string prev_no { get; set; }
        public string settle_no { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public bool New { get; set; }
        public int div_id { get; set; }
        public double frieght { get; set; }
        public bool sync_with_ird { get; set; }
        public bool is_realtime { get; set; }
        public DateTime ird_datetime { get; set; }
        public double prev_amount { get; set; }
        public int refid { get; set; }
        public bool insurance { get; set; }
        public double freight { get; set; }
        public double vat_free { get; set; }
        public bool invoice_reverse { get; set; }
        public int paid_id { get; set; }
        public DateTime paid_date { get; set; }
        public int delivery_id { get; set; }
        public DateTime delivery_date { get; set; }
        public bool paid_checked { get; set; }
        public string claim_code { get; set; }
        public bool website_update { get; set; }
    }

    public class CrnoteDelete_dt
    {
        public int cr_no { get; set; }
    }

    public class CrnoteList_dt
    {
        public List<Crnote_dt> Crnote { get; set; }
    }
}