using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs
{
    public class servGroupPost_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
    }

    public class servGroupGet_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
        public string particular { get; set; }
        public string technical { get; set; }
        public string discount { get; set; }
        public string division { get; set; }
    }


    public class serviceSelect_dt
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
        public string referer { get; set; }
        public string username { get; set; }
        public string groupname { get; set; }
        public string particular { get; set; }
        public string servtype { get; set; }
        public string prodname { get; set; }
        public double withtax { get; set; }
        public string external_particular { get; set; }
    }

    //get by sbcode

    public class ServGrpgetBySbCode_dt
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
        public bool fixed1 { get; set; }
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
        public bool fixed2 {get; set; }
    public string nepali_particular { get; set; }
    public string subdept { get; set; }
}






}