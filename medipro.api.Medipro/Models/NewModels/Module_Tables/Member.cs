using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.Module_Tables
{
    public class MemberInsert_dt
    {
        public DateTime DDATE { get; set; }
        public int ORGID { get; set; }
        public int HOSPID { get; set; }
        public int DPTID { get; set; }
        public string PNAME { get; set; }
        public string CONTACT { get; set; }
        public string ADDRESS { get; set; }
        public string SEX { get; set; }
        public string RELATION { get; set; }
        public string TELEPHONE { get; set; }
        public DateTime EXP_DATE { get; set; }
        public bool CREDIT { get; set; }
        public bool LOCKED { get; set; }
        public bool WITHHELD { get; set; }
        public double CRLIMIT { get; set; }
        public string P_TYPE { get; set; }
        public string M_TYPE { get; set; }
        public int PID { get; set; }
        public DateTime DOB { get; set; }
        public string REMARKS { get; set; }
        public bool MEMBER { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public int ac_code { get; set; }
        public string payfrom { get; set; }
        public string MartialStatus { get; set; }
        public string Occupation { get; set; }
        public string email { get; set; }
        public bool dis_id { get; set; }
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