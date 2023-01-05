using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.OpdRegistration
{

    public class ServSelectByReg_dt
    {
        public int servid { get; set; }
        public int serial { get; set; }
        public string servname { get; set; }
        public bool newmember { get; set; }
        public double ratea { get; set; }
        public double vat { get; set; }

    }

    public class OpdRegistration_dt
    {
        public int sn { get; set; }
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string servname { get; set; }
        public string referer { get; set; }
        public string consultant { get; set; }
        public double amount { get; set; }
        public bool new1 {get; set; }
        public bool old { get; set; }
        public bool er { get; set; }
        public bool insurance { get; set; }
        public bool member { get; set; }
        public string p_type { get; set; }
        public string billmode { get; set; }
}

    public class OpdRegMemberSelect_dt
    {
        public int ac_code1 { get; set; }
        public string district { get; set; }
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
        public float crlimit { get; set; }
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
        public int ethic_code { get; set; }
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
        public int claim_code { get; set; }
        public string patient_type { get; set; }
        public string ref_code { get; set; }
        public bool print_card { get; set; }
        public DateTime print_date { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public bool ssf { get; set; }
        public int age { get; set; }
        public string orgname { get; set; }
        public string account_name { get; set; }
        public string account_name1 { get; set; }
        public string discount_name { get; set; }
        public string discount_type { get; set; }
    }


    public class OpdRegDepartmentSelect_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public float disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public float amt { get; set; }
        public float pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
    }


    public class OpdRegConsultantSelect_dt
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
        public string password { get; set; }
        public int min { get; set; }
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
        public bool doctor { get; set; }
        public bool appointment { get; set; }
        public string email { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public string zoom_user { get; set; }
        public string zoom_apikey { get; set; }
        public string zoom_secretkey { get; set; }
        public int template_id { get; set; }
        public double rate { get; set; }
        public string image { get; set; }
        public bool radiologist { get; set; }
        public string detail { get; set; }
    }

   public class OpdRegInsert_dt
    {
        public string fy { get; set; }
        public int firm { get; set; }
        public string reg_inv_no { get; set; }
      //  public bool new1 {get; set; }
    //public bool old { get; set; }
    public bool er { get; set; }
    public bool insurance { get; set; }
    public bool member { get; set; }
    public string salestype { get; set; }
    public int servid { get; set; }
    public DateTime ddate { get; set; }
    public int hospid { get; set; }
    public int refid { get; set; }
    public double amount { get; set; }
    public int userid { get; set; }
    public string billtime { get; set; }
    public string billmode { get; set; }
    public string p_type { get; set; }
    public string remarks { get; set; }
    public int ageday { get; set; }
    public int grpid { get; set; }
    public int consid { get; set; }
    public int service_type_id { get; set; }
    public int claim_code { get; set; }
    public int dailynumber { get; set; }
    public int ipdno { get; set; }
    public int ac_code { get; set; }
    public double discount { get; set; }
    public double vat { get; set; }
    public double paid { get; set; }
    public double advance { get; set; }
    public double tender { get; set; }
    public double due { get; set; }
    public bool posted { get; set; }
    public string contact { get; set; }
    public string opdbill_inv_no { get; set; }
    public bool canceled { get; set; }
    public bool postledger { get; set; }
    public bool ipd { get; set; }
    public string bedno { get; set; }
    public string labno { get; set; }
    public int scheme { get; set; }
    public string clinical { get; set; }
   // public DateTime collection_date { get; set; }
   // public DateTime report_date { get; set; }
    public int technician { get; set; }
    public int pathologist { get; set; }
    public string appointment_id { get; set; }
    public string regtype { get; set; }
    public string martialstatus { get; set; }
    public string occupation { get; set; }
    public bool reg { get; set; }
    public string email { get; set; }
    public bool foreigner { get; set; }
    public string appby { get; set; }
    public string telno { get; set; }
    public string reqby { get; set; }
    public string organization { get; set; }
    public int dpid  {get; set; }
public double xchange { get; set; }
public string foreign_currenty { get; set; }
public string barcode  {get; set; }
public string prev_inv_no { get; set; }
public bool refund { get; set; }
public int freehealth_id  {get; set; }
public double roundoff { get; set; }
public string pf { get; set; }
public string speciality { get; set; }
public string patienttype { get; set; }
public string mrlocation { get; set; }
public string patient_category { get; set; }
public bool night { get; set; }
public string patient_type { get; set; }
public string branch_center { get; set; }
public int return_id { get; set; }
public bool ssf { get; set; }
public int ssf_scheme_id { get; set; }
public double ssf_pc { get; set; }
public double insurance_amount { get; set; }
public int qty  {get; set; }
public double rate { get; set; }
public double disc { get; set; }
public bool done { get; set; }
public bool panel { get; set; }
public bool formatted { get; set; }
public int lines { get; set; }
public double disc_amt { get; set; }
public double vatamt { get; set; }
public double dueamt { get; set; }
public double process { get; set; }
public string r_no { get; set; }
public int serialno { get; set; }
public double rebate { get; set; }
public string receipt_due { get; set; }
    }


    public class MemberSelect_dt
    {
        public string new_ref_code { get; set; }
        public int ac_code1 { get; set; }
        public int member_code { get; set; }
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
        public string payform { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public string email { get; set; }
        public int dis_id { get; set; }
        public string reg_no { get; set; }
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
        public DateTime print_date { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public bool ssf { get; set; }
        public string pcode { get; set; }
        public string orgname { get; set; }
        public string account_name { get; set; }
        public string account_name1 { get; set; }
        public double pharma_disc1 { get; set; }
        public double pharma_disc2 { get; set; }
        public bool insurance { get; set; }
        public bool ssf_member { get; set; }
        public bool insurance_product { get; set; }
    }


    public class OrganizSelect_dt
    {
        public int orgid { get; set; }
        public string orgname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public bool locked { get; set; }
        public DateTime exp_date { get; set; }
        public int ac_code { get; set; }
        public string discount { get; set; }
        public string p_type { get; set; }
        public string org_type { get; set; }
        public double pharma_disc1 { get; set; }
        public double pharma_disc2 { get; set; }
        public bool insurance { get; set; }
        public string ref_code { get; set; }
        public bool insurance_product { get; set; }
        public bool ssf_member { get; set; }
    }

}