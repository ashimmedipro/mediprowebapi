using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DailyCensusReport_dt
    {
        public DateTime admitdate { get; set; }
        public string bs_date { get; set; }
        public int ipdno { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public string ward { get; set; }
        public string bedno { get; set; }
        public int hospid { get; set; }
    }

    public class DailyCensusReportWardWise_dt
    {
        public int sn { get; set; }
        public int wardno { get; set; }
        public string particular { get; set; }
        public int total { get; set; }
        public int occupaid { get; set; }
        public int vaccant { get; set; }
    }

    public class DailyCensusReportRefererWise_dt
    {
        public int sn { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public int opd { get; set; }
        public int ipd { get; set; }
        public int admit { get; set; }
        public int discharge { get; set; }
    }

    public class RefererGet_dt
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

    public class GetTotalBed_dt
    {
        public int total { get; set; }
        public int occupaid { get; set; }
        public int vaccant { get; set; }
    }
}