using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class OperationNoteInsert_dt
    {
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string bedno { get; set; }
    }

    public class OperationNoteUpdate_dt
    {
        public int operation_id { get; set; }
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string bedno { get; set; }
    }

    public class OperationNoteGetdata_dt
    {
        public int operation_id { get; set; }
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public TimeSpan ttime { get; set; }
        public string bedno { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }

    public class OperationNoteDelete_dt
    {
        public int operation_id { get; set; }
    }
}