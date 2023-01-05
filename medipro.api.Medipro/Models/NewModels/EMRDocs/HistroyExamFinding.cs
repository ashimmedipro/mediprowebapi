using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EMRDocs
{
    public class HistroyExamFindingSelect_dt
    {
        public int sn { get; set; }
        public string inv_no { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public int ipdno { get; set; }
        public int hospid { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string patient_name { get; set; }
        public string bedno { get; set; }
        public string wardno { get; set; }
    }

    public class HisExamFindDelete_dt
    {
        public string inv_no { get; set; }
    }
}