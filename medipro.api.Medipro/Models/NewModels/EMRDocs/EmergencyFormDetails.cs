using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EMRDocs
{
    public class TempEmergencyFormDetailsInsert_dt
    {
        public int userid { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }

    }

    public class EmergencyFormDetailsBulkInsert_dt
    {
        public string inv_no { get; set; }
        public int userid { get; set; }

    }

    public class EmergencyFormDetailsSelect_dt
    {
        public string inv_no { get; set; }
        public int userid { get; set; }

    }


    public class EmergencyFormDetailsDelete_dt
    {
        public string inv_no { get; set;}
    }



}