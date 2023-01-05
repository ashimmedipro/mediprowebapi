using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class FearAndPreceptionDetails
    {
        public class FearAndPreceptionDetailsInsert_dt
        {
            public string mrdno { get; set; }
            public string title { get; set; }
            public string result { get; set; }
            public bool tick_mark { get; set; }
            public DateTime ddate { get; set; }
            public int hospid { get; set; }
        }

        public class FearAndPreceptionDetailsSelect_dt
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

        public class FearAndPreceptionDetailsDelete_dt
        {
            public string mrdno { get; set; }
        }


        public class TempFearAndPreceptionDetailsInsert_dt
        {

            public string title { get; set; }
            public string result { get; set; }
            public bool tick_mark { get; set; }
            public int userid { get; set; }
        }

        public class FearAndPreceptionDetailsBulkInsert_dt
        {
            public DateTime ddate { get; set; }
            public int hospid { get; set; }
            public string mrdno { get; set; }
            public int userid { get; set; }
        }

        public class TempFearAndPreceptionDetailsDelete_dt
        {
            public string userid { get; set; }
        }


    }
}