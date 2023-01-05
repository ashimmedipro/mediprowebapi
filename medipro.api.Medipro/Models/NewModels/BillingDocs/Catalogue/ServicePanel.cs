using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue
{
    public class ServicePanelView_dt
    {
        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float rateb { get; set; }
        public float ratec { get; set; }
        public double vat { get; set; }
        public bool vatincl { get; set; }
        public bool drpc { get; set; }
        public bool tds { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public int wardmin { get; set; }
        public int icumin { get; set; }
        public int opdmin { get; set; }
        public int postmin { get; set; }
        public int serial { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public float pc { get; set; }
        public int cons_code { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public string roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public int groupid { get; set; }
        public string footnote { get; set; }
        public string samplesource { get; set; }
        public int samplesoure { get; set; }
        public string ref_code { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool imageupload { get; set; }
        public string machinname { get; set; }
        public bool test_panel { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
        public string referer { get; set; }
        public string username { get; set; }
        public string groupname { get; set; }
        public string particular { get; set; }
        public string servtype { get; set; }
        public string prodname { get; set; }
        public double withtax { get; set; }
        public string external_particular { get; set; }

    }


    public class ServicePanelInsert_dt
    {
        public int grpid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public int cons_code { get; set; }
        public float pc { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public double roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public double vat { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public string ref_code { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool test_panel { get; set; }
        public float rateb { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
    }

    public class ServicePanelUpdate_dt
    {
        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public int serial { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public int cons_code { get; set; }
        public float pc { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public double roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public double vat { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public string ref_code { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool test_panel { get; set; }
        public float rateb { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
    }

    public class ServicePanelGetGroup_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
    }

    public class ServicePanelGetCode_dt
    {
        public bool group_show { get; set; }
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
        public bool FIXED {get; set; }
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
    public string sbdept { get; set; }

}

    public class ServicePanelGetUser_dt
    {
        public int userid { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string department { get; set; }
        public bool logedin { get; set; }
        public int dpid { get; set; }
        public bool discount { get; set; }
        public bool c_price { get; set; }
        public bool supervisor { get; set; }
        public string status { get; set; }
        public bool opdcredit { get; set; }
        public int usersid { get; set; }
        public DateTime ddate { get; set; }
        public bool blocklastyr { get; set; }
        public int sessionid { get; set; }
        public int ipdcredit { get; set; }
        public int gencredit { get; set; }
        public int salreturn { get; set; }
        public int opensales { get; set; }
        public double guserpharmadisc { get; set; }
        public double userpharmadisc { get; set; }
        public int user_inv_return { get; set; }
        public int refid { get; set; }
        public int refund { get; set; }
        public int opddisc { get; set; }
        public bool sample_collection { get; set; }
        public bool testresult { get; set; }
        public bool verify { get; set; }
        public bool report { get; set; }
        public bool setup { get; set; }
        public string loginid { get; set; }
        public bool ipdcash { get; set; }
        public bool gencash { get; set; }
        public string bimaid { get; set; }
        public string bimapw { get; set; }
        public string designation { get; set; }
        public string nmcno { get; set; }
        public bool auto_backup { get; set; }
        public string hashpassword { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string resetpasswordcode { get; set; }
        public DateTime resetpasswordcreation { get; set; }
        public string image { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string blood_group { get; set; }
        public string medical_condition { get; set; }
        public string bloodgroup { get; set; }
        public int hospid { get; set; }
        public bool online_user { get; set; }
        public string idcardno { get; set; }
        public string idcard { get; set; }
        public bool memberedit { get; set; }
        public DateTime upDateTime { get; set; }
        public bool cashreport { get; set; }

    }




    public class ServicePanelGetReferer_dt
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


    public class ServicePanelGetByGrpid_dt
    {

        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float rateb { get; set; }
        public float ratec { get; set; }
        public double vat { get; set; }
        public bool vatincl { get; set; }
        public bool drpc { get; set; }
        public bool tds { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public int wardmin { get; set; }
        public int icumin { get; set; }
        public int opdmin { get; set; }
        public int postmin { get; set; }
        public int serial { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public float pc { get; set; }
        public int cons_code { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public string roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public int groupid { get; set; }
        public string footnote { get; set; }
        public string samplesource { get; set; }
        public int samplesoure { get; set; }
        public string ref_code { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool imageupload { get; set; }
        public string machinname { get; set; }
        public bool test_panel { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
    }

    public class ServiceCheckView_dt
    {
        public int servid1 { get; set; }
        public int servid2 { get; set; }
        public string servname { get; set; }

    }

    public class ServiceCheckInsert_dt
    {
        public int servid1 { get; set; }
        public int servid2 { get; set; }

    }

    public class ServiceCheckSelect_dt
    {
        public int servid1 { get; set; }
        public string servname { get; set; }

    }

    public class ServiceCheckSelectServid2_dt
    {
        public int servid2 { get; set; }
        public string servname { get; set; }

    }

    //report
    public class ServPanelReport_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
    }

    //inclusion list

    public class ServInculaionList_dt
    {
        public int grpid { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double ratea { get; set; }
        public float rateb { get; set; }
        public float ratec { get; set; }
        public double vat { get; set; }
        public bool vatincl { get; set; }
        public bool drpc { get; set; }
        public bool tds { get; set; }
        public float disc { get; set; }
        public bool patho { get; set; }
        public bool panel { get; set; }
        public string status { get; set; }
        public int wardmin { get; set; }
        public int icumin { get; set; }
        public int opdmin { get; set; }
        public int postmin { get; set; }
        public int serial { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public string method { get; set; }
        public string remarks { get; set; }
        public int sdid { get; set; }
        public float pc { get; set; }
        public int cons_code { get; set; }
        public int md_code { get; set; }
        public double process { get; set; }
        public int gpid { get; set; }
        public string roomno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public int groupid { get; set; }
        public string footnote { get; set; }
        public string samplesource { get; set; }
        public int samplesoure { get; set; }
        public string ref_code { get; set; }
        public bool registration { get; set; }
        public bool newmember { get; set; }
        public int external_code { get; set; }
        public double less_share_pc { get; set; }
        public bool er { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public bool echs { get; set; }
        public bool imageupload { get; set; }
        public string machinname { get; set; }
        public bool test_panel { get; set; }
        public string ssf_code { get; set; }
        public bool nightcharge { get; set; }
        public string lab_code { get; set; }
        public bool template { get; set; }
        public double echs_rate { get; set; }
        public int ac_code { get; set; }
        public int disc_code { get; set; }
        public int plid { get; set; }
    }


    //servname report 

    public class ServiceNameRpt_dt
    {
        public string service1 { get; set; }
        public string service2 { get; set; }
    }



}