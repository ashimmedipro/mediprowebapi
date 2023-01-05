using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec
{
    public class CardlistSelect_dt
    {
        public int sn { get; set; }
        public string cardname { get; set; }
        public int ac_code { get; set; }
        public string particular { get; set; }
        public string shortname { get; set; }
    }
    
    public class AccodeCardSelect1_dt
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
        public bool fixxed {get; set; }
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
}
    
    public class AdvanceNewMemberInsert_dt
    {
        public int orgid { get; set; }
        public int dptid { get; set; }
        public int firm { get; set; }
        public int pid { get; set; }
        public DateTime dob { get; set; }
        public DateTime ddate { get; set; }
        public DateTime exp_date { get; set; }
        public string pname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string relation { get; set; }
        public string telephone { get; set; }
        public string p_type { get; set; }
        public string m_type { get; set; }
        public string member_remarks { get; set; }
        public bool credit { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public bool member { get; set; }
        public double crlimit { get; set; }
        public int ac_code { get; set; }
        public string payfrom { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public string email { get; set; }
        public int dis_id { get; set; }
        public string regno { get; set; }
        public int discount_id { get; set; }
        public int nagar_vdc_id { get; set; }
        public int ethinic_code { get; set; }
        public string wardno { get; set; }
        public int member_name_id { get; set; }
        public int army_type_id { get; set; }
        public string soilder { get; set; }
        public int rank_id { get; set; }
        public int pension_id { get; set; }
        public int units_id { get; set; }
        public int relation_id { get; set; }
        public string policyid { get; set; }
        public string patient_type { get; set; }
        public string ref_code { get; set; }
        public int claim_code { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public bool ssf { get; set; }
        public string adv_remarks { get; set; }
        public string adv_contact { get; set; }
        public float amount { get; set; }
        public float paid { get; set; }
        public int user { get; set; }
        public string billtime { get; set; }
        public bool posted { get; set; }
        public bool clear_posted { get; set; }
        public int adv_ac_code { get; set; }
        public string adv_p_type { get; set; }
    }

    public class AdvanceOldMemberInsert_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string remarks { get; set; }
        public string contact { get; set; }
        public float amount { get; set; }
        public float paid { get; set; }
        public int user { get; set; }
        public string billtime { get; set; }
        public bool posted { get; set; }
        public bool clear_posted { get; set; }
        public int ac_code { get; set; }
        public string p_type { get; set; }
    }

    public class MemberSelect_dt
    {
        public int ac_code1 { get; set; }
        public string disctrict { get; set; }
        public string nagar_vdc { get; set; }
        public int member_code { get; set; }
        public int fileno { get; set; }
        public DateTime ddate { get; set; }
        public int orgid { get; set; }
        public int hospid { get; set; }
        public int dptid { get; set; }
        public string pname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string relation { get; set; }
        public string telephone { get; set; }
        public DateTime exp_date { get; set; }
        public bool credit { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public double crlimit { get; set; }
        public string p_type { get; set; }
        public string m_type { get; set; }
        public int pid { get; set; }
        public DateTime dob { get; set; }
        public string remarks { get; set; }
        public bool member { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public int ac_code { get; set; }
        public string payfrom { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public string email { get; set; }
        public int dis_id { get; set; }
        public string regno { get; set; }
        public int discount_id { get; set; }
        public int nagar_vdc_id { get; set; }
        public int ethinic_code { get; set; }
        public string wardno { get; set; }
        public int member_name_id { get; set; }
        public int army_type_id { get; set; }
        public int rank_id { get; set; }
        public int pension_id { get; set; }
        public int units_id { get; set; }
        public int relation_id { get; set; }
        public string soldier { get; set; }
        public DateTime date_discharge { get; set; }
        public DateTime enlisted_date { get; set; }
        public string policyid { get; set; }
        public string patient_type { get; set; }
        public string ref_code { get; set; }
        public int claim_code { get; set; }
        public bool print_card { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public bool ssf { get; set; }
        public string pcode { get; set; }
        public int age { get; set; }
        public string orgname { get; set; }
        public string account_name { get; set; }
        public string account_name1 { get; set; }
        public string discount_name { get; set; }
        public string discount_type { get; set; }
    }
}