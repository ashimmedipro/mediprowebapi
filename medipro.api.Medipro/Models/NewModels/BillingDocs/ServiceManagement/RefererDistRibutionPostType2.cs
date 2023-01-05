using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement
{
    public class TempRefTemplateInsert_dt
    {
        public int tempalteid { get; set; }
        public int userid { get; set; }
        public bool all { get; set; }
        public bool already { get; set; }
    }

    public class TRefAnalysisInsert_dt
    {
        public DateTime init { get; set; }
        public DateTime final { get; set; }
    }

    public class TemplateNameSelect_dt
    {
        //public int userid { get; set; }
        public int sn { get; set; }
        public string templatename { get; set; }
        public int typeid { get; set; }
    }

    public class RefDetailsSelect
    {
        public int ac_code { get; set; }
        public int refid { get; set; }
        public string referer { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public int qty { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double refamt { get; set; }
        public double tds { get; set; }
        public double refnet { get; set; }
    }


    public class Total_dt
    {
        public int qty { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double net { get; set; }
        public double refamt { get; set; }
        public double tds { get; set; }
        public double refnet { get; set; }
    }

}