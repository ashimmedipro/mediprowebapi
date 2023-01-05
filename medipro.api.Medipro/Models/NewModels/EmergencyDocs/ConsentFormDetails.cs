using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class ConsentFormDetailsInsert_dt
    {
        public int consent_id { get; set; }
        public string relative_fullname { get; set; }
        public string relation { get; set; }
        public string relative_address { get; set; }
    }

    public class ConsentFormDetailsUpdate_dt
    {
        public int consent_id { get; set; }
        public string relative_fullname { get; set; }
        public string relation { get; set; }
        public string relative_address { get; set; }
    }

    public class ConsentFormDetailsGetdata_dt
    {
        public string sn { get; set; }
        public int consent_id { get; set; }
        public string relative_fullname { get; set; }
        public string relation { get; set; }
        public string relative_address { get; set; }
    }

    public class ConsentFormDetailsDelete_dt
    {
        public int consent_id { get; set; }
    }
}