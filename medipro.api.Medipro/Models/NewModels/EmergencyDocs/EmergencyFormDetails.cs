using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class EmergencyFormDetailsInsert_dt
    {
        public int emergency_id { get; set; }
        public string text_title { get; set; }
        public string note { get; set; }
        public bool tick_mark { get; set; }
        public DateTime date_time { get; set; }
    }

    public class EmergencyFormDetailsUpdate_dt
    {
        public int sn { get; set; }
        public int emergency_id { get; set; }
        public string text_title { get; set; }
        public string note { get; set; }
        public bool tick_mark { get; set; }
        public DateTime date_time { get; set; }
    }

    public class EmergencyFormDetailsGetData_dt
    {
        public int sn { get; set; }
        public string text_title { get; set; }
        public string note { get; set; }
        public bool tick_mark { get; set; }
        public DateTime date_time { get; set; }
        public int emergency_id { get; set; }
        public int hospid { get; set; }
        public string pname { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string occupation { get; set; }
        public string address { get; set; }
    }


    public class EmergencyFormDetailsDelete_dt
    {
        public int emergency_id { get; set; }
    }

    public class EmergencyFormAll_dt
     {
         public int hospid { get; set; }
        public int userid { get; set; }
        public int emergency_id { get; set; }
         public string patient_name { get; set; }
         public string sex { get; set; }
         public int age { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate { get; set; }
        public  TimeSpan ttime { get; set; }
        public string phone { get; set; }
        public string occupation { get; set; }
        public string address { get; set; }
        public string brought_by { get; set; }
        public string relationship { get; set; }
        public string vital_pulse { get; set; }
         public string vital_temp { get; set; }
         public string vital_resp { get; set; }
         public string vital_bp { get; set; }
         public string vital_spo2 { get; set; }
         public string gcs_e { get; set; }
         public string gcs_m { get; set; }
         public string gcs_v { get; set; }
         public string provdiag_history { get; set; }
         public string provdiag_examination { get; set; }
         public string provdiag_emergencytreatment { get; set; }
         public string provdiag_adviceondischarge { get; set; }
         public bool hbtcdc_tick { get; set; }
         public bool blodgroupingncross_tick { get; set; }
         public bool matching_tick { get; set; }
         public bool blodsugar_tick { get; set; }
         public bool ures_tick { get; set; }
         public bool creatinine_tick { get; set; }
         public bool lft_tick { get; set; }
         public bool amylase_tick { get; set; }
         public bool cpkmb_tick { get; set; }
         public bool electrolysis_tick { get; set; }
         public bool urineketone_tick { get; set; }
         public bool stooltest_tick { get; set; }
         public bool pregnancytest_tick { get; set; }
         public bool ecg_tick { get; set; }
         public bool xray_tick { get; set; }
         public bool ctscanmri_tick { get; set; }
         public bool others_tick { get; set; }
         public string admtward_no { get; set; }
         public DateTime discharge_ddate { get; set; }
         public string condition { get; set; }
         public string doc_name { get; set; }
         public string doc_no { get; set; }
         public string doc_signature { get; set; }
     }



}