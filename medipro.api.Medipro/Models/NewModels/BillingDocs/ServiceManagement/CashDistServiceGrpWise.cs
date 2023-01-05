using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class GrpNameSelect_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }

    }

    public class ConsultantClassSelect_dtP
    {
        public int sdid { get; set; }
        public int stid { get; set; }
        public int grpid { get; set; }
        public float amount { get; set; }
        public float pc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public string status { get; set; }
        public string servtype { get; set; }
    }

    public class TechDetSelect_dt
    {
        public int techid { get; set; }
        public int sdid { get; set; }
        public int ac_code { get; set; }
        public string status { get; set; }
        public string particular { get; set; }
        public float pc { get; set; }
        public float amount { get; set; }
    }

    public class SelectByDateRange_dt
    {
        public string bs_date { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no { get; set; }
        public string pname { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double taxable { get; set; }
        public double vat { get; set; }
        public double net { get; set; }
        public bool posted { get; set; }
        public int cnt { get; set; }
    }
}