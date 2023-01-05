using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class BedTransaction_dt
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
        public bool ssf { get; set; }
        public string policyid { get; set; }
        public int claim_code { get; set; }
        public bool insurance_product { get; set; }
    }

    public class BedTransactionReport_dt
    {
        public int ipdno { get; set; }
        public DateTime ddate { get; set; }
        public string bedno { get; set; }
        public string billtime { get; set; }
        public int booked { get; set; }
        public string inout { get; set; }
        public int sn { get; set; }
        public string old_bed { get; set; }
        public string old_bedno { get; set; }
        public string bs_date { get; set; }
        public string ward { get; set; }
        public string book { get; set; }
    }
}