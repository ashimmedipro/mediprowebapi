using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class AnaesthesiaRecordDetailsInsert_dt
    {
        public int record_id { get; set; }
        public string details { get; set; }
    }

    public class AnaesthesiaRecordDetailsUpdate_dt
    {
        public int sn { get; set; }
        public int record_id { get; set; }
        public string details { get; set; }
    }

    public class AnaesthesiaRecordDetailsGetdata_dt
    {
        public int sn { get; set; }
        public string details { get; set; }
    }

    public class AnaesthesiaRecordDetailsDelete_dt
    {
        public int record_id { get; set; }
    }
}