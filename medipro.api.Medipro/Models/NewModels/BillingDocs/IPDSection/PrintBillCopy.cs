using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class PrintBillCopyOpdBillGet_dt
    {
        public int claim_code { get; set; }
        public string policyid { get; set; }
        public string invno1 { get; set; }
        public int print_count1 { get; set; }
        public int consid { get; set; }
        public string consultant { get; set; }
        public string ageymd { get; set; }
        public bool canceled { get; set; }
        public string acparticular { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public string bedno { get; set; }
        public bool er { get; set; }
        public int hospid { get; set; }
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string pname { get; set; }
        public DateTime dob { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public string billtime { get; set; }
        public string telephone { get; set; }
        public string billmode { get; set; }
        public string p_type { get; set; }
        public string contact { get; set; }
        public float ageday { get; set; }
        public bool member { get; set; }
        public string department { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double vat { get; set; }
        public double roundoff { get; set; }
        public double net { get; set; }
        public string username { get; set; }
        public double tender { get; set; }
        public double paid { get; set; }
        public int firm { get; set; }
        public double advance { get; set; }
        public string remarks { get; set; }
        public string labno { get; set; }
        public string firmname { get; set; }
        public string regno { get; set; }
        public string firm_address { get; set; }
        public string firm_telephone { get; set; }
        public string ward { get; set; }
        public string organization { get; set; }
        public string groupname { get; set; }
        public string barcode { get; set; }
        public int print_count { get; set; }
        public string pan { get; set; }
        public bool refund { get; set; }
        public bool ssf { get; set; }
        public int ssf_scheme_id { get; set; }
        public double ssf_pc { get; set; }
        public double ssf_pc1 { get; set; }
        public double ssf_amt1 { get; set; }
    }

    public class PrintBillCopyOpdRecGet_dt
    {
        public int sn { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no1 { get; set; }
        public int servid { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double disc { get; set; }
        public double vat { get; set; }
        public string inv_no { get; set; }
        public bool done { get; set; }
        public bool panel { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public DateTime finish_date { get; set; }
        public string finish_time { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public double disc2 { get; set; }
        public double disc_amt { get; set; }
        public double vatamt { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public double process { get; set; }
        public string r_no { get; set; }
        public DateTime rdate { get; set; }
        public double duepaid { get; set; }
        public string due { get; set; }
        public bool sample_collected { get; set; }
        public DateTime sample_date { get; set; }
        public int sample_userid { get; set; }
        public double cost { get; set; }
        public double xchange { get; set; }
        public string testnote { get; set; }
        public bool refund { get; set; }
        public string sample_no { get; set; }
        public DateTime report_DateTime { get; set; }
        public int result_id { get; set; }
        public int verified_id { get; set; }
        public int report_userid { get; set; }
        public bool resulted { get; set; }
        public bool verified { get; set; }
        public bool reported { get; set; }
        public int pathologist_id { get; set; }
        public int technician_id { get; set; }
        public int assistant_id { get; set; }
        public string servname { get; set; }
        public string roomno { get; set; }
    }

    public class PrintBillCopyReceiptGet_dt
    {
        public string r_no { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public double amount { get; set; }
        public int user { get; set; }
        public string billtime { get; set; }
        public string due { get; set; }
        public string remarks { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public int firm { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public string inv_no1 { get; set; }
        public int serialno { get; set; }
        public bool refund { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public double rebate { get; set; }
    }

    public class PrintBillCopyPanelRecGet_dt
    {
        public int sn { get; set; }
        public int servid { get; set; }
        public string inv_no { get; set; }
        public bool done { get; set; }
        public int hospid1 { get; set; }
        public DateTime finish_date { get; set; }
        public string finish_time { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public int master_servid { get; set; }
        public DateTime sample_date { get; set; }
        public bool sample_collected { get; set; }
        public int sample_userid { get; set; }
        public string testnote { get; set; }
        public DateTime report_datetime { get; set; }
        public string sample_no { get; set; }
        public int result_id { get; set; }
        public int verified_id { get; set; }
        public int report_userid { get; set; }
        public bool resulted { get; set; }
        public bool verified { get; set; }
        public bool reported { get; set; }
        public int pathologist_id { get; set; }
        public int technician_id { get; set; }
        public int assistant_id { get; set; }
        public double ratea { get; set; }
        public string servname { get; set; }
    }

    public class PrintBillCopyOpdbillUpdate_dt
    {
        public string inv_no { get; set; }
    }
}