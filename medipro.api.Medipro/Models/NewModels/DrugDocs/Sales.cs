using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Sales_dt
    {
        public int firm { get; set; }
        public string fy { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public int hospid { get; set; }
        public int pt_code { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double cash_disc { get; set; }
        public double free_disc { get; set; }
        public double freight { get; set; }
        public double less1 { get; set; }
        public double less2 { get; set; }
        public double vat { get; set; }
        public string billno { get; set; }
        public string transport { get; set; }
        public int Case { get; set; }
        public string note { get; set; }
        public int user { get; set; }
        public DateTime duedate { get; set; }
        public string freightcap { get; set; }
        public string vr_no { get; set; }
        public double spl_disc { get; set; }
        public double cc_charge { get; set; }
        public double cc_free { get; set; }
        public string ord_no { get; set; }
        public DateTime ord_date { get; set; }
        public string booked_by { get; set; }
        public string doc_thru { get; set; }
        public string ship_via { get; set; }
        public double excise { get; set; }
        public string cn_no { get; set; }
        public DateTime base_date { get; set; }
        public int case_no { get; set; }
        public int comp_code { get; set; }
        public int rep_code { get; set; }
        public DateTime cn_date { get; set; }
        public string fright_type { get; set; }
        public string salestype { get; set; }
        public string billtime { get; set; }
        public string doctor { get; set; }
        public double tender { get; set; }
        public double change { get; set; }
        public string series { get; set; }
        public bool member { get; set; }
        public int refid { get; set; }
        public bool posted { get; set; }
        public int hospid1 { get; set; }
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public bool department { get; set; }
        public double scheme { get; set; }
        public int sm_code { get; set; }
        public int vat_type { get; set; }
        public bool opd { get; set; }
        public string challan { get; set; }
        public bool bulk_post { get; set; }
        public bool bulk_issue { get; set; }
        public int bulk_code { get; set; }
        public DateTime tran_date { get; set; }
        public double claim { get; set; }
        public double rd { get; set; }
        public double extra { get; set; }
        public int dm_code { get; set; }
        public double paid { get; set; }
        public int dp_id { get; set; }
        public string paymode { get; set; }
        public string ref_code { get; set; }
        public string ref_no { get; set; }
        public double cash { get; set; }
        public double card { get; set; }
        public bool delivery { get; set; }
        public int billingon { get; set; }
        public string r_fy { get; set; }
        public string r_no { get; set; }
        public DateTime del_date { get; set; }
        public int del_userid { get; set; }
        public string del_time { get; set; }
        public double del_discount { get; set; }
        public double disc_pc { get; set; }
        public string reqby { get; set; }
        public string appby { get; set; }
        public string tel_no { get; set; }
        public double roundoff { get; set; }
        public string naration { get; set; }
        public char prescription_no { get; set; }
        public double taxable_amount { get; set; }
        public string bedno { get; set; }
        public int print_count { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public bool cancelled { get; set; }
        public bool discount_print { get; set; }
        public string challan_no { get; set; }
        public DateTime challan_date { get; set; }
        public bool insurance { get; set; }
        public bool safemohter { get; set; }
        public int div_id { get; set; }
        public string countername { get; set; }
        public bool sync_with_ird { get; set; }
        public bool is_realtime { get; set; }
        public DateTime ird_datetime { get; set; }
        public double vat_free { get; set; }
        public string tokenno { get; set; }
        public int tokennumber { get; set; }
        public int bank_code { get; set; }
        public int card_code { get; set; }
        public string claim_code { get; set; }
        public int discount_id { get; set; }
        public int freight_code { get; set; }
        public bool paid_checked { get; set; }
        public int paid_id { get; set; }
        public DateTime paid_date { get; set; }
        public int delivery_id { get; set; }
        public DateTime delivery_date { get; set; }
        public int reward_point { get; set; }
        public int prev_reward { get; set; }
        public int pay_reward { get; set; }
        public double reward_rate { get; set; }
        public double redeem_amount { get; set; }
        public string trace_id { get; set; }
    }

    public class SalesList_dt
    {
        public List<Sales_dt> Sales { get; set; }
    }

    public class SalesDelete_dt
    {
        public int inv_no { get; set; }
    }
}