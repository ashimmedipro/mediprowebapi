using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DischargeSheetSelectInpatient_dt
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

    public class DischargeSheetSelectReferer_dt
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
    }


    public class DischargeSheetInsert_dt
    {
        public string operation { get; set; }
        public DateTime operation_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public DateTime admit_date { get; set; }
        public DateTime discharge_date { get; set; }
        public int userid { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public string billtime { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public string note11 { get; set; }
        public string note12 { get; set; }
        public string note13 { get; set; }
        public string note14 { get; set; }
        public string note15 { get; set; }
        public string note16 { get; set; }
        public string note17 { get; set; }
        public string note18 { get; set; }
        public string note19 { get; set; }
        public int consid { get; set; }
        public DateTime cons_date { get; set; }
        public int mediid { get; set; }
        public DateTime medi_date { get; set; }
        public int consid1 { get; set; }
        public DateTime cons_date1 { get; set; }
    }


    public class DischargeSheetSelect_dt
    {
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public DateTime admit_date { get; set; }
        public DateTime discharge_date { get; set; }
        public int userid { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public string billtime { get; set; }
        public string note1 { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string note5 { get; set; }
        public string note6 { get; set; }
        public string note7 { get; set; }
        public string note8 { get; set; }
        public string note9 { get; set; }
        public string note10 { get; set; }
        public string operation { get; set; }
        public DateTime operation_date { get; set; }
        public string note11 { get; set; }
        public string note12 { get; set; }
        public string note13 { get; set; }
        public string note14 { get; set; }
        public string note15 { get; set; }
        public string note16 { get; set; }
        public string note17 { get; set; }
        public string note18 { get; set; }
        public string note19 { get; set; }
        public int consid { get; set; }
        public DateTime cons_date { get; set; }
        public int mediid { get; set; }
        public DateTime medi_date { get; set; }
        public int consid1 { get; set; }
        public DateTime cons_date1 { get; set; }
        public string icdcode { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string bedno { get; set; }
        public int ageday { get; set; }
        public string telephone { get; set; }
        public string bs_date { get; set; }
        public string ward { get; set; }
        public DateTime ad_discharge_date { get; set; }
        public string bs_discharge_date { get; set; }
        public DateTime ad_admit_date { get; set; }
        public string contact { get; set; }
        public string dischargeno { get; set; }
        public string bs_admit_date { get; set; }
        public string referer { get; set; }
        public string username { get; set; }
        public string bs_operation_date { get; set; }
        public string consultant { get; set; }
        public string cons_nmc { get; set; }
        public string cons_bs_date { get; set; }
        public string medical { get; set; }
        public string medi_nmc { get; set; }
        public string medi_bs_date { get; set; }
        public string sex { get; set; }
        public string consultant1 { get; set; }
        public string cons_nmc1 { get; set; }
        public string cons_bs_date1 { get; set; }
    }
}