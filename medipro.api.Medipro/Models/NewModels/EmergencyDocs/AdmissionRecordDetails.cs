using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class AdmissionRecordsdetailsInsert_dt
    {
        public int admission_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }
    }

    public class AdmissionRecordsdetailsUpdate_dt
    {
        public int sn { get; set; }
        public int admission_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }

    }

    public class AdmissionRecordsdetailsGetData_dt
    {
        public int sn { get; set; }
        public int admission_id { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int refid { get; set; }

    }

    public class AdmissionRecordsdetailsDelete_dt
    {
        public int admission_id { get; set; }
    }


    public class AdmissionRecordsAll_dt
    {
        public int admission_id { get; set; }
        public DateTime ddate { get; set; }
        public string date_admission { get; set; }
        public string time_admission { get; set; }
        public string date_discharge { get; set; }
        public string time_discharge { get; set; }
     //   public string re_admission_discharge { get; set; }
        public string re_admission { get; set; }
        public string prov_diag { get; set; }
        public string final_diag { get; set; }
        public string sec_diag { get; set; }
        public string op_procedure { get; set; }
        public string cause_death { get; set; }
        public string result { get; set; }
        public string final_summary { get; set; }
        public int refid { get; set; }
        public string police_case { get; set; }
        public string remark { get; set; }
    }

}