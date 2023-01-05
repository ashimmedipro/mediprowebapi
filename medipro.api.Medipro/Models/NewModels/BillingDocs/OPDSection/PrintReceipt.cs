using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection
{
    public class PrintReceiptSelect_dt
    {
        public string bs_date { get; set; }
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
        public string pname { get; set; }
        public string username { get; set; }
        public string firmname { get; set; }
        public string regno { get; set; }
    }

    public class PrintReceiptServiceSelect_dt
    {
        public string servname { get; set; }
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
    }
}