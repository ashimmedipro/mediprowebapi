using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class IpdRegistrationSlip_dt
    {
        public string bednumber { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int userid { get; set; }
        public double amount { get; set; }
        public bool posted { get; set; }
        public int ac_code { get; set; }
        public string p_type { get; set; }
        public bool member { get; set; }
        public bool discharge { get; set; }
        public string bedno { get; set; }
        public DateTime discharge_date { get; set; }
        public string contact { get; set; }
        public string relation { get; set; }
        public string billtime { get; set; }
        public string em_code { get; set; }
        public int ageday { get; set; }
        public int refid { get; set; }
        public string contacton { get; set; }
        public string contactno { get; set; }
        public int consid { get; set; }
        public bool foreigner { get; set; }
        public int discount_id { get; set; }
        public double ipd_crlimit { get; set; }
        public bool ipd_locked { get; set; }
        public string reg_no { get; set; }
        public int dpid { get; set; }
        public int freehealth_id { get; set; }
        public string pf { get; set; }
        public string types { get; set; }
        public string surgery_name { get; set; }
        public string patient_category { get; set; }
        public string anesthesia { get; set; }
        public string eye { get; set; }
        public int claim_code { get; set; }
        public bool stopreferer { get; set; }
        public string pno_ref_code { get; set; }
        public string patno { get; set; }
        public int fileno { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string bs_date { get; set; }
        public string username { get; set; }
        public string ward { get; set; }
        public string referer { get; set; }
        public string sex { get; set; }
        public string orgname { get; set; }
        public string reg_number { get; set; }
        public string maritalstatus { get; set; }
        public string occupation { get; set; }
    }
}