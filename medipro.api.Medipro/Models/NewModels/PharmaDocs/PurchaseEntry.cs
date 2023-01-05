using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class PurchaseEntryMaster_dt
    {
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string mrn { get; set; }
        public string bill_no { get; set; }
        public DateTime bill_date { get; set; }
        public int pt_code { get; set; }
        public int compcode { get; set; }
     //   public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double excise { get; set; }
        public double freight { get; set; }
        public double cc_charge { get; set; }
        public double cc_free { get; set; }
        public int cc_inc { get; set; }
        public int vat_inc { get; set; }
        public string cu_name { get; set; }
        public double cu_value { get; set; }
        public string cu_regno { get; set; }
        public string cu_regdate { get; set; }
        public double cu_amount { get; set; }
        public double cu_vat { get; set; }
        public double adv_tax { get; set; }
        public string rec_no { get; set; }
        public double localtax { get; set; }
        public double misctax { get; set; }
        public double clearance { get; set; }
        public double transport { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public string remarks { get; set; }
        public string billtime { get; set; }
        public bool posted { get; set; }
        public double xchange { get; set; }
        public string tag { get; set; }
        public int ncbill { get; set; }
        public int nctrade { get; set; }
        public int purchcomp { get; set; }
        public double adjust { get; set; }
        public int discccon { get; set; }
        public int discon { get; set; }
        public string cash { get; set; }
        public string tran_type { get; set; }
        public double rd { get; set; }
        public double freight_amt { get; set; }
        public double scheme { get; set; }
        public double extra { get; set; }
        public string salestype { get; set; }
        public int account_code { get; set; }
        public double VatAdjust { get; set; }
        public int div_id { get; set; }
        public bool ccFreeExclude { get; set; }
        public bool vat_on_free { get; set; }
        public double free_vat { get; set; }
        public double tds { get; set; }
        public double tds_vat { get; set; }
        public bool bulk_issue { get; set; }
        public bool purch_import { get; set; }
        public double vatable_amt { get; set; }
        public double nonvatable_amt { get; set; }
        public int userid { get; set; }
        public int sn { get; set; }
        public double rate { get; set; }
        public double free_amout { get; set; }
        public double percentage { get; set; }
        public float invoice_price { get; set; }
        public float new_cc { get; set; }
        public double discpercentage { get; set; }
        public double cost_price { get; set; }
        public float pc { get; set; }
        public float net { get; set; }
        public float c_price1 { get; set; }
        public int barqty { get; set; }
        public bool bulk { get; set; }
        public double e_price { get; set; }
        public bool website_update { get; set; }
        public double vat_ { get; set; }
        public double cc_free_ { get; set; }
        public double cc_charge_ { get; set; }
        public bool vat_free { get; set; }
        //public DateTime purcdate { get; set; }
        public int ncommitted { get; set; }
        public bool locked { get; set; }
        public bool reserved { get; set; }
        public int salrec_sn { get; set; }
        public string vr_type { get; set; }
        public string naration { get; set; }
        public string vr_no { get; set; }
        public int plid { get; set; }
        public int dp_id { get; set; }
        public int div_code { get; set; }
        public string New { get; set; }
        public int sbled_code { get; set; }
       
    }
}