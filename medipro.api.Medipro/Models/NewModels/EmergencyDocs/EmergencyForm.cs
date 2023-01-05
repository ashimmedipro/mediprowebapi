using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{   
    public class EmergencyFormInsert_dt
    {
        public int hospid { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public string phone { get; set; }
        public string brought_by { get; set; }
        public string relationship { get; set; }
        public TimeSpan ttime { get; set; }
        public string occupation { get; set; }
        public string patient_name { get; set; }
        public string address { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string bed_no { get; set; }

    }   

    public class EmergencyFormUpdate_dt
    {
        public int emergency_id { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }      
        public TimeSpan ttime { get; set; }
        public int hospid { get; set; }
        public string bed_no { get; set; }

    }

    public class EmergencyFormGetdata_dt
    {
        public int emergency_id { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public string phone { get; set; }
        public string brought_by { get; set; }
        public string relationship { get; set; }
        public int hospid { get; set; }
        public string patient_name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public TimeSpan ttime { get; set; }
        public string bed_no { get; set; }

    }

    public class EmergencyFormDelete_dt
    {
        public int emergency_id { get; set; }

    }

    public class EmergencyInvestigation_dt
    {
        public int emergency_id { get; set; }
        public int userid { get; set; }
    }

    public class tempEmergencyInvestigation_dt
    {
        public int sn { get; set; }
        public int servid { get; set; }
        public int userid { get; set; }
    }
}