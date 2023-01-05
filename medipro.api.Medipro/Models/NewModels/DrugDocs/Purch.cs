using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Purch_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
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
        public bool posted { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string billtime { get; set; }
        public string remarks { get; set; }
        public int compcode { get; set; }
        public double xchange { get; set; }
        public string taged { get; set; }
        public string tag { get; set; }
        public int nctrade { get; set; }
        public int ncbill { get; set; }
        public int purchcomp { get; set; }
        public double adjust { get; set; }
        public int discccon { get; set; }
        public int discon { get; set; }
        public string cash { get; set; }
        public string tran_type { get; set; }
        public double extra_discount { get; set; }
        public double rd { get; set; }
        public double freight_amt { get; set; }
        public double scheme { get; set; }
        public double extra { get; set; }
        public char salestype { get; set; }
        public double paid { get; set; }
        public int account_code { get; set; }
        public double vatadjust { get; set; }
        public int div_id { get; set; }
        public bool ccfreeexclude { get; set; }
        public bool vat_on_free { get; set; }
        public double free_vat { get; set; }
        public double tds { get; set; }
        public double tds_vat { get; set; }
        public bool bulk_issue { get; set; }
        public bool purch_import { get; set; }
        public bool website_update { get; set; }
    }

    public class PurchList_dt
    {
        public List<Purch_dt> Purch { get; set; }
    }

    public class PurchDelete_dt
    {
        public int inv_no { get; set; }
    }
}