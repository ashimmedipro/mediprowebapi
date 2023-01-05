using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class pathologyDetails_dt
    {
        public int pathology_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
    }

    public class pathologyDetailsSelect_dt
    {
        public int sn { get; set; }
        public int pathology_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
    }

    public class pathologyDetailsDelete_dt
    {
        public int pathology_id { get; set; }
    }


}