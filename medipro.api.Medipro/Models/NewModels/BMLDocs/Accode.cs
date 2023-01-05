using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.BMLDocs
{
    public class AccodeInsertUpdate_dt // checking
    {
        public string mode { get; set; }
        public string ac_code { get; set; }
        public string ref_code { get; set; }
        public string sb_code { get; set; }
        public string firm { get; set; }
        public string particular { get; set; }
        public string c_person { get; set; }
        public string reg_no { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string cr_limit { get; set; }
        public string sect_code { get; set; }
        public string locked { get; set; }
        public string withheld { get; set; }
        public string fixedd { get; set; }
        public string boss { get; set; }
        public string cr_days { get; set; }
        public string tds_code { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
        public string tds { get; set; }
        public string disc { get; set; }
        public string bank_code { get; set; }
        public string bank { get; set; }
        public string paymode { get; set; }
        public string category { get; set; }
        public string supplier { get; set; }
        public string shortname { get; set; }
        public string CrCard { get; set; }  
        public string term { get; set; }
        public string  mobileno { get; set; }
        public string subledger { get; set; }
    }


    public class AccodeselectById_dt
    {
        public string firm { get; set; }
        public string ref_code { get; set; }
        public string serial { get; set; }
        public string gr_code { get; set; }
        public string grname { get; set; }
        public string sb_code { get; set; }
        public string sbname { get; set; }
        public string ac_code { get; set; }
        public string particular { get; set; }
        public string sect_code { get; set; }
        public string sector { get; set; }
        public string shortname { get; set; }
        public string debtor { get; set; }
        public string supplier { get; set; }
        public string bank { get; set; }
        public string crcard { get; set; }
        public string regno { get; set; }
        public string c_person { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }
        public string crlimit { get; set; }
        public string crdays { get; set; }
        public string tds_code { get; set; }
        public string tdsparticular { get; set; }
        public string bank_code { get; set; }
        public string bank_particular { get; set; }
        public string bank_ac { get; set; }
        public string paymode { get; set; }
        public string locked { get; set; }
        public string fixedd { get; set; }
        public string term { get; set; }
        public string boss { get; set; }
        public string withheld { get; set; }
        public string tds { get; set; }
        public string disc { get; set; }
        public string subledger { get; set; }
    }

    public class AccodeSearch_dt
    {
        public string sbname { get; set; }
        public string ac_type { get; set; }
        public int gr_code { get; set; }
        public string grname { get; set; }
        public int ac_code { get; set; }
        public string ref_code { get; set; }
        public int gr_code1 { get; set; }
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
        public bool fixedd { get; set; }
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
    }
}