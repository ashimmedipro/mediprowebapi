using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Organiz_dt
    {
        public int orgid { get; set; }
        public string orgname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public bool locked { get; set; }
        public DateTime  exp_date { get; set; }
        public int ac_code { get; set; }
        public string discount { get; set; }
        public string p_type { get; set; }
        public string org_type { get; set; }
        public double pharma_disc1 { get; set; }
        public double pharma_disc2 { get; set; }
        public bool insurance { get; set; }
        public string ref_code { get; set; }
        public bool insurance_product { get; set; }
        public string ssf_member { get; set; }
    }

    public class OrganizSelect_dt
    {
        public int orgid { get; set; }
        public string orgname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public bool locked { get; set; }
        public DateTime exp_date { get; set; }
        public int ac_code { get; set; }
        public string discount { get; set; }
        public string p_type { get; set; }
        public string org_type { get; set; }
        public double pharma_disc1 { get; set; }
        public double pharma_disc2 { get; set; }
        public bool insurance { get; set; }
        public string ref_code { get; set; }
        public string particular { get; set; }
    }

    public class OrganizDelete_dt
    {
        public int orgid { get; set; }       
    }
}