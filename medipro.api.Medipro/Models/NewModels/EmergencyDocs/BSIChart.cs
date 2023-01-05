using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class BSIChartInsert_dt
    {
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string bedno { get; set; }
        public DateTime ddate { get; set; }
        public string consultant_name { get; set; }
    }

    public class BSIChartUpdate_dt
    {
        public int sn { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string bedno { get; set; }
        public DateTime ddate { get; set; }
        public string consultant_name { get; set; }
    }

    public class BSIChartGetdata_dt
    {
        public int hospid { get; set; }
        public string bedno { get; set; }
        public DateTime ddate { get; set; }
        public string consultant_name { get; set; }
        public int ipdno { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }

    public class BSIChartDelete_dt
    {
        public int sn { get; set; }
    }
}