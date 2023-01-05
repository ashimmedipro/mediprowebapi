using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    

    public class fiscalyrInsert_dt
    {
        public string prefix { get; set; }
        public string startdate { get; set; }
        public string fiscalyear { get; set; }
        public string account_close { get; set; }
    }

    public class fiscalyearList_dt
    {
        public List<fiscalyear_dt> Fiscalyear { get; set; }
    }

    public class fiscalyear_dt
    {
        public string prefix { get; set; }
        public string startdate { get; set; }
        public string fiscalyear { get; set; }
        public string account_close { get; set; }
        public DateTime initdt { get; set; }
        public DateTime finaldt { get; set; }
    }
}