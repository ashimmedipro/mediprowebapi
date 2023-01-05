using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class EmpDept_dt
    {
        public int dptid { get; set; }
        public string department { get; set; }
        public int orgid { get; set; }
    }

    public class EmpDeptSelect_dt
    {
        public int dptid { get; set; }
        public string department { get; set; }
        public int orgid { get; set; }
        public string orgname { get; set; }
    }

    public class EmpDeptDelete_dt
    {
        public int dptid { get; set; }
    }

    public class EmpDeptSelectReport_dt
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
        public bool insurance_product { get; set; }
        public bool ssf_member { get; set; }
        public int dptid { get; set; }
        public string department { get; set; }
    }


    public class EmpDeptDetailSelectReport_dt
    {
        public string orgname { get; set; }
        public string department { get; set; }
        public DateTime ddate { get; set; }
        public int orgid { get; set; }
        public int hospid { get; set; }
        public int dptid { get; set; }
        public string pname { get; set; }
        public string contact { get; set; }
        public string address { get; set; }
        public string sex { get; set; }
        public string relation { get; set; }
        public string telephone { get; set; }
        public DateTime exp_date { get; set; }
        public bool credit { get; set; }
        public bool locked { get; set; }
        public bool withheld { get; set; }
        public double crlimit { get; set; }
        public string p_type { get; set; }
        public string m_type { get; set; }
        public int pid { get; set; }
        public DateTime dob { get; set; }
        public string remarks { get; set; }
        public bool member { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public int ac_code { get; set; }
        public string payfrom { get; set; }
        public string martialstatus { get; set; }
        public string occupation { get; set; }
        public string email { get; set; }
        public int dis_id { get; set; }
        public string regno { get; set; }
        public int discount_id { get; set; }
        public int nagar_vdc_id { get; set; }
        public int ethinic_code { get; set; }
        public string wardno { get; set; }
        public int member_name_id { get; set; }
        public int army_type_id { get; set; }
        public int rank_id { get; set; }
        public int pension_id { get; set; }
        public int units_id { get; set; }
        public int relation_id { get; set; }
        public string soilder { get; set; }
        public DateTime date_discharge { get; set; }
        public DateTime enlisted_date { get; set; }
        public string policyid { get; set; }
        public string patient_type { get; set; }
        public string ref_code { get; set; }
        public int claim_code { get; set; }
        public bool print_card { get; set; }
        public DateTime print_date { get; set; }
        public double rem_balance { get; set; }
        public bool baby { get; set; }
        public bool ssf { get; set; }
        public string pcode { get; set; }
    }
}