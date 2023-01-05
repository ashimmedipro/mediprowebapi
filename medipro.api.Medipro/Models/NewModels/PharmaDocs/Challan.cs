using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{


    //ALL CHALLAN REC
    public class allChallan_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public int pt_code { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public string pname { get; set; }
        public string particular { get; set; }
        public string particular_ { get; set; }
        public double amount { get; set; }
        public bool post { get; set; }
        public int userid { get; set; }

    }


    //GET DRUG LIST FOR CHALLAN

    public class challanGetDrugList_dt
    {
        public DateTime days { get; set; }
        public string Code { get; set; }
        public string vat_Free { get; set; }
        public double insurance_rate { get; set; }
        public bool insurance { get; set; }
        public string ref_code { get; set; }
        public int md_code { get; set; }
        public string prodname { get; set; }
        public int compcode { get; set; }
        public string packing { get; set; }
        public double i_price { get; set; }
        public double ic_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double mrp { get; set; }
        public double excise { get; set; }
        public double ex_price { get; set; }
        public double margin { get; set; }
        public double custom { get; set; }
        public double vatamt { get; set; }
        public string vat { get; set; }
        public double disc { get; set; }
        public double onminq { get; set; }
        public double onminl { get; set; }
        public double bonus { get; set; }
        public double qty_limit { get; set; }
        public double lotbonus { get; set; }
        public bool ncbill { get; set; }
        public bool nctrade { get; set; }
        public bool superstock { get; set; }
        public int firm { get; set; }
        public string unit { get; set; }
        public string barcode { get; set; }
        public int wsunit { get; set; }
        public int rolevel { get; set; }
        public string mrp_ic_nc { get; set; }
        public double t_price { get; set; }
        public int drugcat { get; set; }
        public int qty { get; set; }
    }





    public class challanGet_dt
    {
        public int quantity { get; set; }
       
    }



    //second get from stbal
        public class challanGetBatch_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public string batch { get; set; }
        public DateTime exp_date { get; set; }
        public int qty { get; set; }
        public int ncommited { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double mrp { get; set; }
        public double excise { get; set; }
        public bool locked { get; set; }
        public string remarks { get; set; }
        public double onminq { get; set; }
        public double bonus { get; set; }
        public DateTime purdate { get; set; }
        public int firm { get; set; }
        public string mrnno { get; set; }
        public int ac_code { get; set; }
        public int quantity { get; set; }
        public int store { get; set; }
        public string barcode { get; set; }
        public int tran_id { get; set; }
        public double t_price { get; set; }


    }

    //GET PARTY

    public class partySelect_dt{
        public string reg_no { get; set; }
        public string sbname { get; set; }
        public bool details { get; set; }
        public double depriciation { get; set; }
        public int snsb { get; set; }
        public string grname { get; set; }
        public string ac_type { get; set; }
        public int sngr { get; set; }
        public int snac { get; set; }
        public string billmode { get; set; }
        public string groupname { get; set; }
        public string groups { get; set; }
        public string groupdetail { get; set; }
        public string grdetail { get; set; }
        public bool sbdetail { get; set; }
        public int ac_code { get; set; }
        public string Ref_code { get; set; }
        public int gr_code { get; set; }
        public int sb_code { get; set; }
        public int firm { get; set; }
        public string particular { get; set; }
        public string c_person { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public double cr_limit { get; set; }
        public int sect_code { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public bool _fixed {get; set;}
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
    public bool CrCard { get; set; }
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

    //CHALLAN MASTER INSERT
    public class challanInsert_dt
    {
        public int id { get; set; }
        public int nid { get; set; }
        public int comp_code { get; set; }
        //public string particular { get; set; }
        //public string pack { get; set; }
        public int md_code { get; set; }
        public int qty { get; set; }
        public int free { get; set; }
       // public int ac_code { get; set; }
        public string batch { get; set; }
        public string type { get; set; }
        public double rate { get; set; }
        public double cc { get; set; }
        //public double vat { get; set; }
        public double disco { get; set; }
        //public double vatamt { get; set; }
        public string remarks { get; set; }
        public double scheme { get; set; }
        public string inv_no { get; set; }
        //public string salestype { get; set; }
        public string fy { get; set; }
        public DateTime ddate { get; set; }
        public int pt_code { get; set; }
        public bool post { get; set; }
        public int userid { get; set; }
        //public double t_price { get; set; }
        //public int rep_code { get; set; }
        //public int hospid { get; set; }
        //public int ipdno { get; set; }
        //public bool ipd { get; set; }

    }


    public class challanDetails_dt
    {
        public int md_code { get; set; }
        public string particular { get; set; }
        public string batch { get; set; }
        public string pack { get; set; }
        public int qty { get; set; }
        public string type { get; set; }
        public double rate { get; set; }
        public double discount { get; set; }
        public double scheme { get; set; }
        public double amount { get; set; }
        public string remarks { get; set; }
    }
}