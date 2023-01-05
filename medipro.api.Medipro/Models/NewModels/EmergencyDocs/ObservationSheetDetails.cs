using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class ObservationSheetDetailsInsert_dt
    {
        public int sn { get; set; }
        public string tprbp_details { get; set; }
        public string nurse_notes { get; set; }
    }

    public class ObservationSheetDetailsUpdate_dt
    {
        public int sn { get; set; }
        public string tprbp_details { get; set; }
        public string nurse_notes { get; set; }
    }

    public class ObservationSheetDetailsSelect_dt
    {
        public int ssn { get; set; }
        public int sn { get; set; }
        public string tprbp_details { get; set; }
        public string nurse_notes { get; set; }
    }

    public class ObservationSheetDetailsDelete_dt
    {
        public int sn { get; set; }
    }
}