using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class DeathCertificateSelectInpatient_dt
    {
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public bool posted { get; set; } 
        public bool member { get; set; }
        public bool discharge { get; set; }
        public DateTime admit_date { get; set; }
        public DateTime discharge_date { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public string em_code { get; set; }
        public string bedno { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string telephone { get; set; }
        public string contact { get; set; }
        public int ac_code { get; set; }
        public string maritialstatus { get; set; }
        public string occupation { get; set; }
        public DateTime dob { get; set; }
        public string p_type { get; set; }
        public int orgid { get; set; }
        public string m_type { get; set; }
        public string orgname { get; set; }
    }


    public class DeathCertificateInsert_dt
    {
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public int ipdno { get; set; }
        public DateTime expire_date { get; set; }
        public string expire_time { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public string remarks { get; set; }
        public string note2 { get; set; }
        public string note3 { get; set; }
        public string note4 { get; set; }
        public string salute { get; set; }
        public string nominee { get; set; }
        public int refid { get; set; }
        public string note1 { get; set; }
    }
}