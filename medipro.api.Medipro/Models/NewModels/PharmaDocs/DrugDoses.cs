using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DrugDoses_dt
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string doses_name { get; set; }
    }

    public class DrugDosesSelect_dt
    {
        public int sn { get; set; }
        public string doses_name { get; set; }
    }

    public class DrugDoseList_dt
    {
        public List<DrugDosesSelect_dt> Drugdoses { get; set; }
    }

    public class DrugDosesDelete_dt
    {
        public int sn { get; set; }
    }

    public class DrugDosesDetail_dt
    {
        public int sn { get; set; }
        public int serial { get; set; }
        public string detail_english { get; set; }
        public string detail_Nepali { get; set; }
        public float dose_times { get; set; }
        public int id { get; set; }
    }

    public class DrugDosesDetailSelect_dt
    {
        public int id { get; set; }
        public int sn { get; set; }
        public int serial { get; set; }
        public string detail_english { get; set; }
        public string detail_Nepali { get; set; }
        public float dose_times { get; set; }
       // public string doses_name { get; set; }
    }

    public class DrugDosesDetailList_dt
    {
        public List<DrugDosesDetailSelect_dt> Drugdosesdetail { get; set; }
    }
}