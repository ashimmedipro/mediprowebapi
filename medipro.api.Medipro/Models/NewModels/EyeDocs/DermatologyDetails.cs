using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class DermatologyDetails_dt
    {
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class DermatologyDetailsSelect_dt
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
        public string education { get; set; }
        public string income { get; set; }
    }

    public class DermatologyDetailsDelete_dt
    {
        public string mrdno { get; set; }
    }
}