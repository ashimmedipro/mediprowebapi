using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.DueSection
{
    public class CurrentDueReportSelect_dt
    {
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string pname { get; set; }
        public double invamt { get; set; }
        public double due { get; set; }
        public string username { get; set; }
        public string referer { get; set; }
        public Boolean reg { get; set; }
    }

    public class tOpdBilldue1Select_dt
    {
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public string bs_date { get; set; }
        public string pname { get; set; }
        public double invamt { get; set; }
        public double due { get; set; }
        public string username { get; set; }
        public string referer { get; set; }
        public Boolean reg { get; set; }
    }

    public class tOpdBilldue1Total_dt
    {
        public double invamt { get; set; }
        public double due { get; set; }
    }

    public class CurrDueRepRefererSelect_dt
    {
        public int refid { get; set; }
        public int sp_id { get; set; }
        public string referer { get; set; }
        public string regno { get; set; }
        public int ac_code { get; set; }
        public string qualification { get; set; }
        public string present { get; set; }
        public string professional { get; set; }
        public string specialized { get; set; }
        public string publication { get; set; }
        public string other { get; set; }
        public bool oncall { get; set; }
        public int min { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string status { get; set; }
        public int template_id { get; set; }
        public int templateid { get; set; }
        public int sm_code { get; set; }
        public int referer_type { get; set; }
        public int consultid { get; set; }
        public bool patho { get; set; }
        public bool refering { get; set; }
        public bool consult { get; set; }
        public bool doctor { get; set; }
        public string intime { get; set; }
        public string outtime { get; set; }
        public bool appointment { get; set; }
        public string image { get; set; }
        public double rate { get; set; }
        public string email { get; set; }
        public string zoom_user { get; set; }
        public string zoom_apikey { get; set; }
        public string zoom_secretkey { get; set; }
        public bool radiologist { get; set; }
        public string detail { get; set; }
    }



}