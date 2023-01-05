using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DischargeInpatientSelect_dt
    {
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int fileno { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public bool posted { get; set; }
        public bool member { get; set; }
        public bool discharge { get; set; }
        public DateTime admit_date { get; set; }
        public DateTime discharge_date { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public string em_code { get; set; }
        public string bedno { get; set; }
        public string pname { get; set; }
        public string ref_code { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string telephone { get; set; }
        public string contact { get; set; }
        public int member_code { get; set; }
        public string payform { get; set; }
        public int ac_code { get; set; }
        public string maritialstatus { get; set; }
        public string occupation { get; set; }
        public DateTime dob { get; set; }
        public string p_type { get; set; }
        public int orgid { get; set; }
        public string m_type { get; set; }
        public string orgname { get; set; }
        public double pharma_disc1 { get; set; }
        public double pharma_disc2 { get; set; }
        public bool foreigner { get; set; }
        public int discount_id { get; set; }
        public string discount_name { get; set; }
        public bool notify { get; set; }
        public bool ipd_locked { get; set; }
        public double ipd_crlimit { get; set; }
        public int consid { get; set; }
        public string consultant { get; set; }
        public int dpid { get; set; }
        public string groupname { get; set; }
        public string ref_tel { get; set; }
        public string regno { get; set; }
        public bool insurance { get; set; }
        public string policyid { get; set; }
        public int claim_code { get; set; }
    }

    public class DischargeAmount_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string naration { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string billtime { get; set; }
    }

    public class DischargeTotal_dt
    {
        public double total { get; set; }
    }

    public class DischargeDiscount_dt
    {
        public double discount { get; set; }
    }

    public class DischargeRefund_dt
    {
        public float total { get; set; }
    }

    public class DischargeIcdCode_dt
    {
        public string icdcode { get; set; }
        public string dieases { get; set; }
        public string groupname { get; set; }
        public string sex { get; set; }
    }


    public class DischargeInsert_dt
    {
        public string fy { get; set; }
        public string inv_no { get; set; }
        public int ipdno { get; set; }
        public float amount { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public bool posted { get; set; }
        public int firm { get; set; }
        public DateTime ddate { get; set; }
        public string dischargeno { get; set; }
        public float deposit { get; set; }
        public float tender { get; set; }
        public bool member { get; set; }
        public string p_type { get; set; }
        public int ac_code { get; set; }
        public float paid { get; set; }
        public int refid { get; set; }
        public string discharge_type { get; set; }
        public double discount { get; set; }
        public double paid_amount { get; set; }
        public string r_no { get; set; }
        public string due { get; set; }
        public string remarks { get; set; }
        public int hospid { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public bool ipd { get; set; }
        public int serialno { get; set; }
        public bool refund { get; set; }
        public double rebate { get; set; }
        public DateTime discharge_date { get; set; }
        public string icdcode { get; set; }
    }

    public class AccodeGet_dt
    {
        public bool group_show { get; set; }
        public string sbname { get; set; }
        public bool details { get; set; }
        public double depriciation { get; set; }
        public int snsb { get; set; }
        public string sbname_nepali { get; set; }
        public string grname { get; set; }
        public string ac_type { get; set; }
        public int sngr { get; set; }
        public string grname_nepali { get; set; }
        public int snac { get; set; }
        public string billmode { get; set; }
        public string groupname { get; set; }
        public string groups { get; set; }
        public string groupdetail { get; set; }
        public string grdetail { get; set; }
        public bool sbdetail { get; set; }
        public string contra_ac_type { get; set; }
        public int contra_sb_code { get; set; }
        public bool contra_group_show { get; set; }
        public string contra_sbname { get; set; }
        public int contra_snsb { get; set; }
        public int contra_gr_code { get; set; }
        public string contra_groupname { get; set; }
        public string contra_grname { get; set; }
        public int contra_sngr { get; set; }
        public string activity_code { get; set; }
        public string sch { get; set; }
        public string fund { get; set; }
        public string contra_activity_code { get; set; }
        public string contra_sch { get; set; }
        public string contra_fund { get; set; }
        public bool personal_account { get; set; }
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
        public bool fixed1 { get; set; }
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
        public bool crcard { get; set; }
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
        public DateTime created_date { get; set; }
        public bool fixed2 {get; set; }
    public string nepali_particular { get; set; }
    public string sbdept { get; set; }
}

}