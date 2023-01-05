using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class IntakeOutputInsert_dt
    {
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan billtime { get; set; }
        public int hospid { get; set; }
        public string bed_no { get; set; }
    }

    public class IntakeOutputUpdate_dt
    {
        public int intakeoutput_id { get; set; }
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan billtime { get; set; }
        public int hospid { get; set; }
        public string bed_no { get; set; }
    }

    public class IntakeOutputGetdata_dt
    {
        public int sn { get; set; }
        public int intakeoutput_id { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan billtime { get; set; }
        public int ipdno { get; set; }
        public string bed_no { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string ward { get; set; }
    }

    public class IntakeOutputDelete_dt
    {
        public int intakeoutput_id { get; set; }
    }
}