using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class ChecklistInsert_dt
    {
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string bedno { get; set; }
    }

    public class ChecklistUpdate_dt
    {
        public int checklist_id { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int userid { get; set; }
        public string bedno { get; set; }
    }


    public class ChecklistGetdata_dt
    {
        public int checklist_id { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public string bedno { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }


    public class ChecklistDelete_dt
    {
        public int checklist_id { get; set; }
    }
}