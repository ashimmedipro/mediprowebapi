using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class OperationNoteDetails
    {
        public class OperationNoteDetailsInsert_dt
        {
            public int operation_id { get; set; }
            public string details1 { get; set; }
            public string details2 { get; set; }
        }

        public class OperationNoteDetailsUpdate_dt
        {
            public int sn { get; set; }
            public int operation_id { get; set; }
            public string details1 { get; set; }
            public string details2 { get; set; }
        }

        public class OperationNoteDetailsGetdata_dt
        {
            public int operation_id { get; set; }
            public int sn { get; set; }
            public string details1 { get; set; }
            public string details2 { get; set; }
        }

        public class OperationNoteDetailsDelete_dt
        {
            public int operation_id { get; set; }
        }
    }
}