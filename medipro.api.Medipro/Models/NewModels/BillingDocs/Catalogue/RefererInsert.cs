using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue
{
    public class RefererInsert_dt
    {
        public int refid { get; set; }
        public int sp_id { get; set; }
        public string referer { get; set; }
        public string regno { get; set; }
        public int ac_code { get; set; }
        public string qualification { get; set; }
        public string present { get; set; }
        public string professional { get; set; }
        public string specialized { get; set; }
        public string publication { get; set; }
        public string other { get; set; }
        public bool oncall { get; set; }
        public int min { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int template_id { get; set; }
        public int templateid { get; set; }
        public int sm_code { get; set; }
        public int referer_type { get; set; }
        public int consultid { get; set; }
        public bool patho { get; set; }
        public bool refering { get; set; }
        public bool consult { get; set; }
        public bool doctor { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public bool appointment { get; set; }
        public string image { get; set; }
        public double rate { get; set; }
        public string email { get; set; }
        public string zoom_user { get; set; }
        public string zoom_apikey { get; set; }
        public string zoom_secretkey { get; set; }
        public bool radiologist { get; set; }
    }



    public class SalesManGet_dt
    {
        public int sm_code { get; set; }
        public string salesman { get; set; }
    }

    public class SpecialityGet_dt
    {
        public int sp_id { get; set; }
        public string detail { get; set; }
    }

    public class RefererSetupGet_dt
    {
        public int refid { get; set; }
        public int sp_id { get; set; }
        public string referer { get; set; }
        public string regno { get; set; }
        public int ac_code { get; set; }
        public string qualification { get; set; }
        public string present { get; set; }
        public string professional { get; set; }
        public string specialized { get; set; }
        public string publication { get; set; }
        public string other { get; set; }
        public bool oncall { get; set; }
        public int min { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int template_id { get; set; }
        public int templateid { get; set; }
        public int sm_code { get; set; }
        public int referer_type { get; set; }
        public int consultid { get; set; }
        public bool patho { get; set; }
        public bool refering { get; set; }
        public bool consult { get; set; }
        public bool doctor { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public bool appointment { get; set; }
        public string image { get; set; }
        public double rate { get; set; }
        public string email { get; set; }
        public string zoom_user { get; set; }
        public string zoom_apikey { get; set; }
        public string zoom_secretkey { get; set; }
        public bool radiologist { get; set; }
        public string detail { get; set; }
        public string particular { get; set; }
        public string templatename { get; set; }
        public string salesman { get; set; }
        public string referer_type_detail { get; set; }
        public string consult_templatename { get; set; }
    }


    public class RefererSetupAcCodeGet_dt
    {
        public string reg_no1 { get; set; }
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

    //update model 

    public class RefererSetupUpdate_dt
    {
        public int refid { get; set; }
        public int sp_id { get; set; }
        public string referer { get; set; }
        public string regno { get; set; }
        public int ac_code { get; set; }
        public string qualification { get; set; }
        public string present { get; set; }
        public string professional { get; set; }
        public string specialized { get; set; }
        public string publication { get; set; }
        public string other { get; set; }
        public bool oncall { get; set; }
        public int min { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int templateid { get; set; }
        public int sm_code { get; set; }
        public int referer_type { get; set; }
        public int consultid { get; set; }
        public bool patho { get; set; }
        public bool refering { get; set; }
        public bool consult { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public bool appointment { get; set; }
        public string email { get; set; }
        public string zoom_user { get; set; }
        public string zoom_apikey { get; set; }
        public string zoom_secretkey { get; set; }
        public bool radiologist { get; set; }
    }

    //templarteid get 

    public class TemplateIdGet_dt
    {
        public int sn { get; set; }
        public string templatename { get; set; }
        public int typeid { get; set; }
    }

}