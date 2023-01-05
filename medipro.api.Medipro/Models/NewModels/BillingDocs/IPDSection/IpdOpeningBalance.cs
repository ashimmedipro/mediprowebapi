using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class IpdOpeningBalanceSelectInpatient_dt
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

    public class IpdOpeningBalanceInsert_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int ac_code { get; set; }
        public int refid { get; set; }
        public int firm { get; set; }
        public int user {get; set; }
    public float amount { get; set; }
    public float discount { get; set; }
    public float vat { get; set; }
    public float paid { get; set; }
    public float advance { get; set; }
    public float tender { get; set; }
    public float due { get; set; }
    public float ageday { get; set; }
    public bool member { get; set; }
    public bool posted { get; set; }
    public string billtime { get; set; }
    public string billmode { get; set; }
    public string p_type { get; set; }
    public string remarks { get; set; }
    public string contact { get; set; }
    public string inv_no { get; set; }
    public string fy { get; set; }
    public bool canceled { get; set; }
    public bool postledger { get; set; }
    public bool ipd { get; set; }
    public string bedno { get; set; }
    public string labno { get; set; }
    public int grpid { get; set; }
    public int scheme { get; set; }
    public string clinical { get; set; }
    public bool er { get; set; }
    public DateTime collection_date { get; set; }
    public DateTime report_date { get; set; }
    public int technician { get; set; }
    public int pathologist { get; set; }
    public string appointment_id { get; set; }
    public string regtype { get; set; }
    public string martialstatus { get; set; }
    public string occupation { get; set; }
    public bool reg { get; set; }
    public string email { get; set; }
    public int consid { get; set; }
    public bool foreigner { get; set; }
    public string appby { get; set; }
    public string telno { get; set; }
    public string reqby { get; set; }
    public string organization { get; set; }
    public int dpid { get; set; }
    public double xchange { get; set; }
    public string foreign_currenty { get; set; }
    public string barcode { get; set; }
    public string prev_inv_no { get; set; }
    public bool refund { get; set; }
    public int service_type_id { get; set; }
    public int freehealth_id { get; set; }
    public string salestype { get; set; }
    public float roundoff { get; set; }
    public int dailynumber { get; set; }
    public string pf { get; set; }
    public string speciality { get; set; }
    public string patienttype { get; set; }
    public string mrlocation { get; set; }
    public string patient_category { get; set; }
    public bool insurance { get; set; }
    public bool night { get; set; }
    public string patient_type { get; set; }
    public int claim_code { get; set; }
    public string branch_center { get; set; }
    public int return_id { get; set; }
}
}