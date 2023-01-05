using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class HistoryDetailsInsert_dt
    {
        public int his_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
       
    }


    public class HistoryDetailsGetdata_dt
    {
        public int sn { get; set; }
        public int his_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
    }

    public class HistoryDetailsDelete_dt
    {
        public int his_id { get; set; }
    }
}