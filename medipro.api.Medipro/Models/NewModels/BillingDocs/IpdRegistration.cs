using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs
{
    public class BedRackView_dt
    {
        public string bedno { get; set; }
        public int wardno { get; set; }
        public string remarkstype { get; set; }
        public string remarks { get; set; }
        public DateTime discharge_date { get; set; }
        public bool discharge { get; set; }
        public int ipdno { get; set; }
        public DateTime admitdate { get; set; }
        public string bedno1 { get; set; }
        public int booked { get; set; }
        public string particular { get; set; }
        public string pname { get; set; }
        public string bs_date { get; set; }
        public string book { get; set; }
    }


    public class RefererView_dt
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
        public string deatil { get; set; }
    }


    public class IpdRegistrationInsert_dt
    {
        public DateTime ddate { get; set; }
        public int orgid { get; set; }
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
        public string soilder { get; set; }
        public string policy_id { get; set; }
        public string patient_type { get; set; }
        public string ref_code { get; set; }
        public int claim_code { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public bool posted { get; set; }
        public bool discharge { get; set; }
        public string bedno { get; set; }
        public string billtime { get; set; }
        public string em_code { get; set; }
        public int ageday { get; set; }
        public int refid { get; set; }
        public string contactno { get; set; }
        public int consid { get; set; }
        public bool foreigner { get; set; }
        public double ipd_crlimit { get; set; }
        public bool ipd_locked { get; set; }
        public int dpid { get; set; }
        public int freehealth_id { get; set; }
        public string pf { get; set; }
        public string types { get; set; }
        public string surgery_name { get; set; }
        public string patient_category { get; set; }
        public string anesthesia { get; set; }
        public string eye { get; set; }
        public bool stopreferer { get; set; }
        public int booked { get; set; }
        public string inout { get; set; }
        public string old_bed { get; set; }
        //public string remarkstype { get; set; }
        public string fy { get; set; }
        public string inv_no { get; set; }
        public bool ssf { get; set; }
        public string pcode { get; set; }
    }
}