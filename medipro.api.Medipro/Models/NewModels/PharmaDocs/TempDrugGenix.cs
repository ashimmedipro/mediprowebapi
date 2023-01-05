using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class TempDrugGenix_dt
    {
        public int md_code { get; set; }
        public int userid { get; set; }
    }

    public class tempDrugGenixSelect_dt
    {
        public int genid { get; set; }
        public int userid { get; set; }
        public string genericname { get; set; }
    }

    public class tempDrugGenixDelete_dt
    {
        public int userid { get; set; }
    }

}