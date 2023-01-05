using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class CSIAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string k1od { get; set; }
        public string k1os { get; set; }
        public string k2od { get; set; }
        public string k2os { get; set; }
        public string axial_od { get; set; }
        public string axial_os { get; set; }
        public string iol_od { get; set; }
        public string iol_os { get; set; }
        public string blood_report { get; set; }
        public bool hbsag_react_tick { get; set; }
        public bool hcv_react_tick { get; set; }
        public bool hiv_tick { get; set; }
        public bool bs_fbs_tick { get; set; }
        public bool bs_pp_tick { get; set; }
        public string remarks { get; set; }
        public bool bs_rbs_tick { get; set; }
        public string bs_rbs { get; set; }
        public string bs_fbs { get; set; }
        public string bs_pp { get; set; }
        public string a_constant_od { get; set; }
        public string a_constant_os { get; set; }
    }

    public class CsiInsert_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class CsiInsertSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }
    public class CsiDelete_dt
        {
            public string mrdno { get; set; }
        }
    
}