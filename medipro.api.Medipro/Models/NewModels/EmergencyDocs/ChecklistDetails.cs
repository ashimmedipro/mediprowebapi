using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class ChecklistDetailsInsert_dt
    {
        public int checklist_id { get; set; }
        public bool ward_nurse { get; set; }
        public bool ot_nurse { get; set; }
        public string remarks { get; set; }
    }

    public class ChecklistDetailsUpdate_dt
    {
        public int checklist_id { get; set; }
        public bool ward_nurse { get; set; }
        public bool ot_nurse { get; set; }
        public string remarks { get; set; }
    }

    public class ChecklistDetailsGetdata_dt
    {
        public int sn { get; set; }
        public int checklist_id { get; set; }
        public bool ward_nurse { get; set; }
        public bool ot_nurse { get; set; }
        public string remarks { get; set; }

    }

    public class ChecklistDetailsDelete_dt
    {
        public int checklist_id { get; set; }
    }
}