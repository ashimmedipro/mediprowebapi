using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class CashReceiptEntry_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public string r_no { get; set; }
        public int pt_code { get; set; }
        public float amount { get; set; }
        public string vr_no { get; set; }
        public string naration { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string vr_type { get; set; }
        public string billtime { get; set; }
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public bool opd { get; set; }
        public string r_type { get; set; }
        public double discount { get; set; }
        public string disc_naration { get; set; }
        public int ac_code { get; set; }
        public double paid { get; set; }
        public int comp_code { get; set; }
        public int sm_code { get; set; }
        public int rep_code { get; set; }
        public DateTime bank_date { get; set; }
        public string p_type { get; set; }
        public int card_code { get; set; }
        public bool ledger_posting { get; set; }
        public double tds { get; set; }
        public bool insurance { get; set; }
        public string bank_name { get; set; }
        public string cheque_no { get; set; }
        public int paytype { get; set; }
        // public int plid { get; set; }
        // public int plid { get; set; }
        //  public int dp_id { get; set; }
        // public int div_code { get; set; }
        // public bool New {get; set;}
        //  public int sbled_code { get; set; }
    }

    public class SelectLedgerBalancebyAccode_dt
    {
        public double balance { get; set; }
    }

    public class SelectPartybyAccode_dt
    {
        public string reg_no { get; set; }
        public string sbname { get; set; }
        public bool details { get; set; }
        public double depriciation { get; set; }
        public int snsb { get; set; }
        public string grname { get; set; }
        public string ac_type { get; set; }
        public int sngr { get; set; }
        public int snac { get; set; }
        public string billmode { get; set; }
        public string groupname { get; set; }
        public string groups { get; set; }
        public string groupdetail { get; set; }
        public string grdetail { get; set; }
        public bool sbdetail { get; set; }
        public int ac_code { get; set; }
        public string Ref_code { get; set; }
        public int gr_code { get; set; }
        public int sb_code { get; set; }
        public int firm { get; set; }
        public string particular { get; set; }
        public string c_person { get; set; }
        public string Reg_no { get; set; }//
        public string address { get; set; }
        public string telephone { get; set; }
        public double cr_limit { get; set; }
        public int sect_code { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public bool Fixed { get; set; }
        public bool boss { get; set; }
        public int cr_days { get; set; }
        public int tds_code { get; set; }
        public int dep_code { get; set; }
        public int main_code { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public int dp_id { get; set; }
        public double tds { get; set; }
        public double disc { get; set; }
        public int bank_code { get; set; }
        public string bankno { get; set; }
        public string paymode { get; set; }
        public string u_category { get; set; }
        public int category { get; set; }
        public bool debtor { get; set; }
        public bool supplier { get; set; }
        public string shortname { get; set; }
        public bool bank { get; set; }
        public bool CrCard { get; set; }
        public DateTime print_date { get; set; }
        public int term { get; set; }
        public string mobileno { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        public bool subledger { get; set; }
        public string email { get; set; }
        public string email1 { get; set; }
        public string mobile1 { get; set; }
        public int sect_code1 { get; set; }
    }

    public class SelectbankbyAccode_dt
    {
        public string ac_code { get; set; }
        public string ref_code { get; set; }
        public int gr_code { get; set; }
        public int sb_code { get; set; }
        public int firm { get; set; }
        public string particular { get; set; }
        public string c_person { get; set; }
        public string reg_no { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public double cr_limit { get; set; }
        public int sect_code { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public bool Fixed { get; set; }
        public bool boss { get; set; }
        public int cr_days { get; set; }
        public int tds_code { get; set; }
        public int dep_code { get; set; }
        public int main_code { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public int dp_id { get; set; }
        public double tds { get; set; }
        public double disc { get; set; }
        public int bank_code { get; set; }
        public string bankno { get; set; }
        public string paymode { get; set; }
        public string u_category { get; set; }
        public int category { get; set; }
        public bool debtor { get; set; }
        public bool supplier { get; set; }
        public string shortname { get; set; }
        public bool BANK { get; set; }
        public bool CrCard { get; set; }
        public DateTime print_date { get; set; }
        public int term { get; set; }
        public string mobileno { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        public bool subledger { get; set; }
        public string email { get; set; }
        public string email1 { get; set; }
        public string mobile1 { get; set; }
        public int sect_code1 { get; set; }
    }

    public class SelectOpbalBalancebyAccode_dt
    {
        public double tbalance { get; set; }
    }
}