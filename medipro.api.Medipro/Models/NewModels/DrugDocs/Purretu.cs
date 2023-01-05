using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Purretu_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public int comp_code { get; set; }
        public string inv_no { get; set; }
        public int cc_inc { get; set; }
        public int vat_inc { get; set; }
        public string mrn { get; set; }
        public string bill_no { get; set; }
        public DateTime bill_date { get; set; }
        public int pt_code { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double freight { get; set; }
        public double excise { get; set; }
        public double cc_charge { get; set; }
        public double cc_free { get; set; }
        public double gross_amt { get; set; }
        public double less_amt { get; set; }
        public string less_for { get; set; }
        public string goods { get; set; }
        public string cu_name { get; set; }
        public string cu_value { get; set; }
        public string cu_regno { get; set; }
        public string cu_regdate { get; set; }
        public string cu_amount { get; set; }
        public string cu_vat { get; set; }
        public double adv_tax { get; set; }
        public string rec_no { get; set; }
        public double localtax { get; set; }
        public double misctax { get; set; }
        public double clearance { get; set; }
        public double transport { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string billtime { get; set; }
        public string remarks { get; set; }
        public bool posted { get; set; }
        public int compcode { get; set; }
        public bool bulk_issue { get; set; }
        public bool bulk_post { get; set; }
        public int bulk_code { get; set; }
        public string tag { get; set; }
        public int purchcomp { get; set; }
        public double adjust { get; set; }
        public double rd { get; set; }
        public double extra { get; set; }
        public double scheme { get; set; }
        public char salestype { get; set; }
        public double paid { get; set; }
        public int ac_code { get; set; }
        public string rebate_naration { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public string transporter { get; set; }
        public string cnno { get; set; }
        public int noofcase { get; set; }
        public DateTime cndate { get; set; }
        public string freight_cap { get; set; }
        public bool New { get; set; }
        public int div_id { get; set; }
        public char cash { get; set; }
        public double free_vat { get; set; }
        public double vatadjust { get; set; }
        public bool website_update { get; set; }
    }

    public class PurretuList_dt
    {
        public List<Purretu_dt> Purretu { get; set; }
    }
    public class PurretuDelete_dt
    {
        public string inv_no { get; set; }
    }
}