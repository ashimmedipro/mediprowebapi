using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class ProductDivision_dt
    {
        public int div_id { get; set; }
        public int compcode { get; set; }
        public string division_name { get; set; }
        public bool allsales { get; set; }
        public int crdays { get; set; }
        public int lockdays { get; set; }       
    }

    public class ProductDivisionSelect_dt
    {
        public int div_id { get; set; }
        public int compcode { get; set; }
        public string division_name { get; set; }
        public bool allsales { get; set; }
        public int crdays { get; set; }
        public int lockdays { get; set; }
        public string compname { get; set; }
    }

    public class ProductDivisionDelete_dt
    {
        public int div_id { get; set; }       
    }
}