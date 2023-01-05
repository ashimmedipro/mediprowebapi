using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class AdmissionRecordsInsert_dt
    {
        public int ipdno { get; set; }
        public int userid { get; set; }
        public string bed_no { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string patient_name { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string occupation { get; set; }
        public string marital_status { get; set; }
        public string fulladdress { get; set; }
    }

    public class AdmissionRecordsUpdate_dt
    {
        public int admission_id { get; set; }
        public int ipdno { get; set; }
       // public int userid { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string bed_no { get; set; }

    }

    public class AdmissionRecordsGetData_dt
    {
        public int admission_id { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public string bed_no { get; set; }
        public int hospid { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string patient_name { get; set; }
        public string marital_status { get; set; }
        public string occupation { get; set; }
        public string full_address { get; set; }
    }


    public class AdmissionRecordsDelete_dt
    {
        public int admission_id { get; set; }
    }
}