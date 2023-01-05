using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class ChiefComplainDetailsInsert_dt
    {
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class ChiefComplainDetailsUpdate_dt
    {
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class ChiefComplainDetailsSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string martialstatus { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }

    public class ChiefComplainDetailsDelete_dt
    {
        public string mrdno { get; set; }
    }

    //common eye problem

    public class TempCommonEyeProblemDetailsInsert_dt
    {

        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public int userid { get; set; }
    }

    public class CommonEyeProblemDetailsBulkInsert_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string mrdno { get; set; }
        public int userid { get; set; }
    }

    public class CommonEyeProblemDetailsDelete_dt
    {
        public string userid { get; set; }
    }


}