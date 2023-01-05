using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class PartDisc_dt
    {
        public int sn { get; set; }
        public int comp_code { get; set; }
        public double discount { get; set; }
        public int pt_code { get; set; }
        public string sales { get; set; }
    }
}