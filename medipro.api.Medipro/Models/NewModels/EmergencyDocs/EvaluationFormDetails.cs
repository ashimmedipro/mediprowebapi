using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class EvaluationFormDetailsInsert_dt
    {
        public int sn { get; set; }
        public string details1 { get; set; }
        public string details2 { get; set; }
        public string details3 { get; set; }
        public string details4 { get; set; }
    }

    public class EvaluationFormDetailsUpdate_dt
    {
        public int ssn { get; set; }
        public int sn { get; set; }
        public string details1 { get; set; }
        public string details2 { get; set; }
        public string details3 { get; set; }
        public string details4 { get; set; }
    }

    public class EvaluationFormDetailsGetdata_dt
    {
        public int ssn { get; set; }
        public int sn { get; set; }
        public string details1 { get; set; }
        public string details2 { get; set; }
        public string details3 { get; set; }
        public string details4 { get; set; }
    }

    public class EvaluationFormDetailsDelete_dt
    {
        public int sn { get; set; }
    }
}