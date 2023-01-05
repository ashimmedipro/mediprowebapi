using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class EvaluationFormInsert_dt
    {
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public double weight { get; set; }
        public DateTime ddate { get; set; }
        public int wardno { get; set; }
        public string bedno { get; set; }

    }

    public class EvaluationFormUpdate_dt
    {
        public int sn { get; set; }
        public int ipdno { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public double weight { get; set; }
        public DateTime ddate { get; set; }
        public int wardno { get; set; }
        public string bedno { get; set; }
    }

    public class EvaluationFormGetdata_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
        public int hospid { get; set; }
        public double weight { get; set; }
        public int wardno { get; set; }
        public string bedno { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public int ipdno { get; set; }
    }

    public class EvaluationFormDelete_dt
    {
        public int sn { get; set; }
    }
}