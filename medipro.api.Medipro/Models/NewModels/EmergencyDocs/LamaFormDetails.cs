using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class LamaFormDetails_dt
    {
        public int lama_id { get; set; }
        public string relative_name { get; set; }
        public string relation { get; set; }
        public string details { get; set; }
    }

    public class LamaFormDetailsSelect_dt
    {
        public int sn { get; set; }
        public int lama_id { get; set; }
        public string relative_name { get; set; }
        public string relation { get; set; }
        public string details { get; set; }
    }

    public class LamaFormDetailsDelete_dt
    {
        public int lama_id { get; set; }
    }
}