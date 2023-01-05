using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class Pathology_dt
    {
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate { get; set; }
    }

    public class PathologyUpdate_dt
    {
        public int pathology_id { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate { get; set; }
    }

    public class PathologySelect_dt
    {
        public int pathology_id { get; set; }
        public int hospid { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
        public string bed_no { get; set; }
        public DateTime ddate { get; set; }
        public string patient_name { get; set; }
        public string sex { get; set; }
        public string ward { get; set; }
        public int age { get; set; }
    }

    public class PathologyDelete_dt
    {
        public int pathology_id { get; set; }
    }
}