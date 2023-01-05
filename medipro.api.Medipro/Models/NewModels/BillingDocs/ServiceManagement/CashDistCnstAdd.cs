using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class CashDistCnstAdd_dt
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
    }

    public class CashDistGetAccode_dt
    {
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
        public bool fixed1 {get; set; }
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
    public string subdept { get; set; }
}

    public class ServmangInsert_dt
    {
        public string inv_no { get; set; }
        public int servid { get; set; }
        public int ac_code { get; set; }
    }
}