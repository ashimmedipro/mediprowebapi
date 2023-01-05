using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class CmpListix_dt
    {
        public int compcode { get; set; }
        public int firm { get; set; }
        public string compname { get; set; }
        public string address { get; set; }
        public int ac_code { get; set; }
        public double custom { get; set; }
        public bool ncbill { get; set; }
        public bool superstock { get; set; }
        public double rofactor { get; set; }
        public double commission { get; set; }
        public int user { get; set; }
        public bool nctrade { get; set; }
        public string series { get; set; }
        public string ref_code { get; set; }
        public double excise { get; set; }
        public int account_code { get; set; }
        public int userid { get; set; }
        public string tag { get; set; }
        public string lens { get; set; }
        public string cconrate { get; set; }
        public int income_code { get; set; }
        public int cc_code { get; set; }
        public int discount_code { get; set; }
        public int excise_code { get; set; }
        public double disc { get; set; }
        public int crdays { get; set; }
        public bool locked { get; set; }
        public bool expirycc { get; set; }
        public double sp_pc { get; set; }
        public double tp_pc { get; set; }
        public double mrp_pc { get; set; }
        public bool divsalesoff { get; set; }
        public bool discon { get; set; }
        public bool addcc { get; set; }
    }

    public class CmpListixSelect_dt
    {
        public int compcode { get; set; }
        public int firm { get; set; }
        public string compname { get; set; }
        public string address { get; set; }
        public int ac_code { get; set; }
        public double custom { get; set; }
        public bool ncbill { get; set; }
        public bool superstock { get; set; }
        public double rofactor { get; set; }
        public double commission { get; set; }
        public int user { get; set; }
        public bool nctrade { get; set; }
        public string series { get; set; }
        public string ref_code { get; set; }
        public double excise { get; set; }
        public int account_code { get; set; }
        public int userid { get; set; }
        public string tag { get; set; }
        public string lens { get; set; }
        public string cconrate { get; set; }
        public int income_code { get; set; }
        public int cc_code { get; set; }
        public int discount_code { get; set; }
        public int excise_code { get; set; }
        public double disc { get; set; }
        public int crdays { get; set; }
        public bool locked { get; set; }
        public bool expirycc { get; set; }
        public double sp_pc { get; set; }
        public double tp_pc { get; set; }
        public double mrp_pc { get; set; }
        public bool divsalesoff { get; set; }
        public bool discon { get; set; }
        public bool addcc { get; set; }
        public string particular { get; set; }
    }


    public class CmpListixDelete_dt
    {
        public int compcode { get; set; }
    }

    public class CompanyList_dt
    {
        public List<CmpListix_dt> Cmplist { get; set; }
    }
}