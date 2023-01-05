using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs
{

     //sales register

    public class SalesRegisterOpdBillGet_dt
    {
        public string note1 { get; set; }
        public string note2 { get; set; }
        public int refid { get; set; }
        public string username { get; set; }
        public bool insurance { get; set; }
        public bool canceled { get; set; }
        public string note { get; set; }
        public int hospid { get; set; }
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double roundoff { get; set; }
        public double net { get; set; }
        public bool ipd { get; set; }
        public bool reg { get; set; }
        public string lcdcode { get; set; }
        public string referer { get; set; }
        public string appby { get; set; }
        public string reqby { get; set; }
        public string telno { get; set; }
        public string consultant { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public string patient_type { get; set; }
        public string branch_center { get; set; }
        public int userid { get; set; }
        public double disc_pc { get; set; }

    }


    //sales register

    public class SalesRegisterOpdBillTotal_dt
    {
        public float amount { get; set; }
        public float discount { get; set; }
        public float taxable { get; set; }
        public double roundoff { get; set; }
        public float vat { get; set; }
        public float net { get; set; }
        public int cnt { get; set; }
    }





    //sales summary 

        public class SalesSummaryOpdbillGet_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string firstinv { get; set; }
        public string lastinv { get; set; }
        public int totinv { get; set; }
        public double totalamount { get; set; }
        public double totaldiscount { get; set; }
        public double taxable { get; set; }
        public double totvat { get; set; }
        public double roundoff { get; set; }
        public double net { get; set; }

    }


    public class SalesSummaryDiscountSum_dt
    {
        public double discount { get; set; }
    }


    public class SalesSummarySum_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double roundoff { get; set; }
        public double net { get; set; }
    }


    public class OpdSalesSummary_dt
    {
        public int sn { get; set; }
        public string type { get; set; }
        public double roundoff { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class OpdSalesSumaryTotal_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double roundoff { get; set; }
        public double net { get; set; }
    }


    public class ServiceGroupwiseSales_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public double duepaid { get; set; }
        public int nop { get; set; }
    }


    public class ServiceGroupwiseSalesSum_dt
    {
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
    }

    public class ServiceGroupwiseSalesDue_dt
    {
        public double duepaid { get; set; }
    }

    public class ServiceGroupwisePatientCount_dt
    {
        public int cnt { get; set; }
    }

    //ServiceDivisionwiseSales

    public class ServiceDivisionwiseSales_dt
    {
        public int dp_id { get; set; }
        public string groupname { get; set; }
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public int nop { get; set; }
    }

    public class ServiceDivisonwiseSalesSum_dt
    {
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double total { get; set; }
    }

    //discount report

    public class DiscountGet_dt
    {
        public int discount_id { get; set; }
        public string discount_name { get; set; }
        public string status { get; set; }
        public bool notify { get; set; }
        public string type { get; set; }
        public double pharmacy_disc { get; set; }
        public double minimum_amount { get; set; }
        public double pharmacy_amount { get; set; }
        public int sn { get; set; }
    }

    public class DiscRepMemberSelect_dt
    {
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
        public string soilder { get; set; }
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
        public int age { get; set; }//
    }

    public class OpdDiscReport_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double disc_pc { get; set; }
        public string username { get; set; }
        public string remarks { get; set; }
        public string discount_name { get; set; }
        public string appby { get; set; }
        public string reqby { get; set; }
        public string telno { get; set; }
    }

    public class DiscByDateRange_dt
    {
        public double discount { get; set; }
    }

    public class OpdDiscSumByDateRange_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
    }




    //patient history 

    public class PatientHistory_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class PatientHistoryDiscount_dt
    {
        public double discount { get; set; }
    }

    
    public class PatientHistorySum_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }


    //cash register summary 

    public class CashRegisterSummary_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string r_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double rebate { get; set; }
        public string due { get; set; }
        public string username { get; set; }
        public string billtime { get; set; }
        public bool ipd { get; set; }
        public string inv_no { get; set; }
    }

    public class CashRegisterSummarySum_dt
    {
        public double amount { get; set; }
        public double rebate { get; set; }

    }



//
    public class RefererAnalysis_dt
    {
        public int refid { get; set; }
        public string referer { get; set; }
        public int nob { get; set; }
        public double disc { get; set; }
        public double namt { get; set; }
    }

    public class RefererAnalysisSum_dt
    {
        public int nob { get; set; }
        public double disc { get; set; }
        public double namt { get; set; }
    }

    //



    public class RefererSelect_dt
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


    public class RefererSummary_dt
    {
        public string inv_no { get; set; }
        public double amount { get; set; }
        public int qty { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public string referer { get; set; }
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string pname { get; set; }
        public string servname { get; set; }
    }

    public class RefererSummaryGrpwise_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int nob { get; set; }
        public double namt { get; set; }
    }

    //RefererPaytSlipTypeBDelete
    public class RefererPaytSlipTypeBDelete_dt
    {
        public  int tempalteid  { get; set; }
        public  int userid  { get; set; }
        public  bool all  { get; set; }
    }

    //

    public class ServicewiseSalesSummary_dt
    {
        public int servid { get; set; }
        public string servname { get; set; }
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public double duepaid { get; set; }
    }


    public class ServicewiseSalesSum_dt
    {
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }

    }


    public class ServiceSalesDuePaid_dt
    {
        public double duepaid { get; set; }
    }


    //general health

    public class GeneralHealthScreenReport_dt
    {
        public string sn { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public int firm { get; set; }
        public string past_history { get; set; }
        public string tb { get; set; }
        public string diabetes { get; set; }
        public string allergy { get; set; }
        public string height { get; set; }
        public string weight { get; set; }
        public string pulse { get; set; }
        public string temp { get; set; }
        public string bp { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public DateTime ddate { get; set; }
        public string note2 { get; set; }
        public string bmi { get; set; }
        public string pname { get; set; }
        public string bs_date { get; set; }
    }


    // OpdServiceCashDetail

    public class OpdServiceCashDetailInsert_dt
    {
        public DateTime init { get; set; }
        public DateTime final { get; set; }
        public int userid { get; set; }
        public int firm { get; set; }
    }


    public class OpdServiceCashDetailSelect_dt
    {
        public int sn { get; set; }
        public int dp_id { get; set; }
        public string division { get; set; }
        public bool detail { get; set; }
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int hosqty { get; set; }
        public int qty { get; set; }
        public double amt { get; set; }
        public double cashpaid { get; set; }
        public double dueamt { get; set; }
        public double duepaid { get; set; }
        public double cash { get; set; }
    }

    public class OpdServCashDetailSum_dt
    {
        public int hospqty { get; set; }
        public int qty { get; set; }
        public double amt { get; set; }
        public double cashpaid { get; set; }
        public double dueamt { get; set; }
        public double duepaid { get; set; }
        public double cash { get; set; }
    }

    public class OpdServDiscServSum_dt
    {
        public double discount  { get; set; }
        public double salesreverse { get; set; }

    }




    //Organization Member Section 
    //Organization Statement 

    public class OrganizMemberSelect_dt
    {
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
        public string soilder { get; set; }
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

    }


    public class OrganizSelectDateRange_dt
    {
        public string claim_code { get; set; }
        public int sn { get; set; }
        public DateTime dt { get; set; }
        public string inv { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }

    //organization summary statement & organization  dept summary

    public class OrganizeSummarySelect_dt
    {
        public string groupname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class OrganizeSummarySumSelect_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class DeptSelect_dt
    {
        public int dptid { get; set; }
        public string department { get; set; }
        public int orgid { get; set; }
    }


    //organization member statement 
    public class OrgMemberStatementSelect_dt
    {
        public int hospid { get; set; }
        public string pname { get; set; }
        public string policyid { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class OrgMemberStatementSumSelect_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }


    //departmentwise Statement 

    public class DptwiseStatementSelect_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }


    //Member Statement 

    public class MemberStmtSelect_dt
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

    public class DobToYear_dt
    {
        public int yr { get; set; }
        public int mnt { get; set; }
        public int dy { get; set; }
    }

    public class OrgMemberReport_dt
    {
        public string inv { get; set; }
        public DateTime dt { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }

    public class OrgMemberReportSummary_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }


    //servicewise report 

    public class servwiseRptServieGet_dt
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
        public int grpac_code { get; set; }
        public int disc_code { get; set; }
        public int plid { get; set; }
        public double netfee { get; set; }
        public string groupname { get; set; }
    }

    public class ServicewiseReportGet_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string pname { get; set; }
        public string orgname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }

    //service center report 
    public class ServCenterRepSelect_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string pname { get; set; }
        public string orgname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
    }

    //insurance live claim post 

    public class SsfPatientSalesList_dt
    {
        public bool ipd { get; set; }
        public int ipdno { get; set; }
        public bool ssf { get; set; }
        public int claim_code { get; set; }
        public int scheme_id { get; set; }
        public string ssf_claim_id { get; set; }
        public int scheme_product_id { get; set; }
        public DateTime ddate { get; set; }
        public string icdcode { get; set; }
        public string ssf_claim_code { get; set; }
        public bool ssf_post { get; set; }
        public bool ssf_claim_post { get; set; }
        public string outcome { get; set; }
        public DateTime min_date { get; set; }
        public DateTime max_date { get; set; }
        public string policyid { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public double net { get; set; }
        public int service_bill { get; set; }
        public int pharmacy_bill { get; set; }
        public int uuid { get; set; }
        public string employerid { get; set; }
        public string admitted { get; set; }
        public string woundcondition { get; set; }
        public string injuredbodypart { get; set; }
        public string isdisable { get; set; }
        public string isdead { get; set; }
        public string accidentdescription { get; set; }
        public string reasonofsickness { get; set; }
        public string dischargetype { get; set; }
        public string dischargesummary { get; set; }
        public DateTime dischargedate { get; set; }
        public string cancer { get; set; }
        public string hiv { get; set; }
        public string heartattack { get; set; }
        public string highbp { get; set; }
        public string diabetes { get; set; }
    }


    //registration report 

    public class RegSelect_dt
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

    //sales materalized view 
    public class opdbillViewGet_dt
    {
        public DateTime ddate { get; set; }
        public string fiscalyear { get; set; }
        public string bill_no { get; set; }
        public string customer_name { get; set; }
        public string customer_pan { get; set; }
        public string bill_date { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable_amount { get; set; }
        public double tax_amount { get; set; }
        public int is_printed { get; set; }
        public int is_active { get; set; }
        public string printed_time { get; set; }
        public string entered_by { get; set; }
        public string printed_by { get; set; }
        public int firm { get; set; }
        public double net { get; set; }
        public bool sync_with_ird { get; set; }
        public bool is_realtime { get; set; }
        public DateTime ird_DateTime { get; set; }
        public int print_count { get; set; }
        public DateTime ad_date { get; set; }
        public string bs_date { get; set; }
        public string ird { get; set; }
    }

    //Service-Divisionwise Sales Summary For Lab
    
    public class ServdivSalesLabGet_dt
    {
        public int dp_id { get; set; }
        public string groupname { get; set; }
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public int nop { get; set; }
    }

    public class ServdivSalesLabTotalGet_dt
    {
        public int nob { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double taxable { get; set; }
        public double nontaxable { get; set; }
        public double total { get; set; }
    }

    //service groupwise analysis

    public class ServGrpWiseDetailGet_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int cnt { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double vatamt { get; set; }
        public double total { get; set; }
    }

    //Member Sales Register 

    public class MemberSalesRegGet_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    public class MemSalesRegSumGet_dt
    {
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
    }

    //Credit Invoice Due Clear Report

    public class CdtInvDueClearRptGet_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string vr_no { get; set; }
        public int ac_code { get; set; }
        public string particular { get; set; }
        public double paid { get; set; }
        public int bank_code { get; set; }
        public string bank_name { get; set; }
    }

    public class CdtInvDueClearRptGetTotalt_dt
    {
        public double paid { get; set; }
    }


    //Patient Record 

    public class PatientRecMemberGet_dt
    {
        public int ac_code { get; set; }
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
        public double crlimit { get; set; }
        public string p_type { get; set; }
        public string m_type { get; set; }
        public int pid { get; set; }
        public DateTime dob { get; set; }
        public string remarks { get; set; }
        public bool member { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
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
        public int age { get; set; }
        public string orgname { get; set; }
        public string account_name { get; set; }
        public string account_name1 { get; set; }
        public string discount_name { get; set; }
        public string discount_type { get; set; }
    }

    public class MemOpdRecGet_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int servid { get; set; }
        public string servname { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double disc { get; set; }
        public double net { get; set; }

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
        public string soilder { get; set; }
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
    }

    public class MemPharmaRecGet_dt
    {
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string inv_no { get; set; }
        public int md_code { get; set; }
        public string prodname { get; set; }
        public int batch { get; set; }
        public double exp_date { get; set; }
        public double qty { get; set; }
        public double rate { get; set; }
        public double disco { get; set; }
        public double net { get; set; }

        public int orgid { get; set; }
        public int hospid { get; set; }
        public int dptid { get; set; }
        public string pname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string relation { get; set; }
        public string telephone { get; set; }
        
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
        public string soilder { get; set; }
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
    }

    public class ServiceVsPatientGet_dt
    {
        public int servid { get; set; }
        public string servname { get; set; }
        public int qty { get; set; }
    }
}