using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DrugGenixSelect_dt
    {
        public int md_code { get; set; }
        public int genid { get; set; }
        public string prodname { get; set; }
        public string genericname { get; set; }
    }

    public class DrugGenixList_dt
    {
        public List<DrugGenixSelect_dt> Druggeneric { get; set; }
    }
}