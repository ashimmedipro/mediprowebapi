using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Ac_Code_dt
    {
        public int ac_code { get; set; }
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
        public bool FIXED { get; set; }
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
       // public DateTime print_date { get; set; }
        public int term { get; set; }
        public string mobileno { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        //public bool subledger { get; set; }
        public string email { get; set; }
        public string email1 { get; set; }
        public string mobile1 { get; set; }
        public int sect_code1 { get; set; }
    }

    public class Ac_Code_Delete_dt
    {
        public int ac_code { get; set; }
    }

    public class ac_code_select1_dt
    {
        public int ac_code { get; set; }
        public string sbname { get; set; }
        public string particular { get; set; }
        public string pan { get; set; }
    }

    public class ac_code_selectbyitem_dt
    {
        public string value { get; set; }
    }

    public class ac_code_selectbygroupname_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double DISC { get; set; }
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

    public class ac_code_selectbygroupCode_dt
    {
        public string ac_type { get; set; }
        public int sb_code { get; set; }
        public string particular { get; set; }
        public bool FIXED { get; set; }
        public int gr_code { get; set; }
        public bool details { get; set; }
        public double depreciation { get; set; }
        public double depriciation { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
        public bool sbdetail { get; set; }
        public string code { get; set; }
        public string groupname { get; set; }
    }

    public class ac_code_selectSelector_dt
    {
        public int sect_code { get; set; }
        public string sector { get; set; }
    }

    public class Ac_CodeselectDepreciation_Maintenance_dt
    {
        public int ac_code { get; set; }
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
        public bool FIXED { get; set; }
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
        public string SbDept { get; set; }
    }

}