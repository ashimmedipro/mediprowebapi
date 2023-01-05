using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class IntakeOutputDetailInsert_dt
    {
        public int intakeoutput_id { get; set; }
        public string texttitle_oral_parental { get; set; }
        public string value_oral { get; set; }
        public string value_parental { get; set; }
        public string ty { get; set; }
        public string ty_intake { get; set; }
        public string ty_output { get; set; }
    }

    public class IntakeOutputDetailUpdate_dt
    {
        public int intakeoutput_id { get; set; }
        public string texttitle_oral_parental { get; set; }
        public string value_oral { get; set; }
        public string value_parental { get; set; }
        public string ty { get; set; }
        public string ty_intake { get; set; }
        public string ty_output { get; set; }
    }

    public class IntakeOutputDetailGetdata_dt
    {
        public int sn { get; set; }
        public string texttitle_oral_parental { get; set; }
        public string value_oral { get; set; }
        public string value_parental { get; set; }
        public string ty { get; set; }
        public string ty_intake { get; set; }
        public string ty_output { get; set; }
    }


    public class IntakeOutputDetailDelete_dt
    {
        public int intakeoutput_id { get; set; }
    }
}