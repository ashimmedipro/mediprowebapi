using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class BSIChartDetailsInsert_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string blood_sugar { get; set; }
        public string insulin_given { get; set; }
        public string remarks { get; set; }
    }

    public class BSIChartDetailsUpdate_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string blood_sugar { get; set; }
        public string insulin_given { get; set; }
        public string remarks { get; set; }
    }

    public class BSIChartDetailsGetdata_dt
    {
        public int ssn { get; set; }
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string blood_sugar { get; set; }
        public string insulin_given { get; set; }
        public string remarks { get; set; }
    }

    public class BSIChartDetailsDelete_dt
    {
        public int sn { get; set; }
    }
}