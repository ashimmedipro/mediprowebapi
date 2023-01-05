using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class CsParty_dt 
    {
        public int code { get; set; }
        public string particular { get; set; }
        public string reg_no { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int userid { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        public int ac_link_code { get; set; }
        public string ref_code { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
    }

    public class CsPartyList_dt
    {
        public List<CsPartySelect_dt> Csparty { get; set; }
    }

    public class CsPartySelect_dt
    {
        public int code { get; set; }
        public string particular { get; set; }
        public string reg_no { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int userid { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        public int ac_link_code { get; set; }
        public string ref_code { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string ac_particular { get; set; }
    }

    public class CsPartySelect1_dt
    {
        public int code { get; set; }
        public string particular { get; set; }
        public string reg_no { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int userid { get; set; }
        public int pan { get; set; }
        public string dda { get; set; }
        public string ncda { get; set; }
        public int ac_link_code { get; set; }
        public string ref_code { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
      //  public string ac_particular { get; set; }
    }

    public class CsPartyDelete_dt
    {
        public int code { get; set; }
    }
}