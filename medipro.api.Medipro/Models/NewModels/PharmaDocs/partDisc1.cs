using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class PartDisc1_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public double discount { get; set; }
        public int pt_code { get; set; }
        public string sales { get; set; }
    }

    public class PartDisc1Delete_dt
    {
        public int sn { get; set; }
    }
    
    public class ParDisc1SelectMax_dt
    {
        public int newcode { get; set; }
    }
}