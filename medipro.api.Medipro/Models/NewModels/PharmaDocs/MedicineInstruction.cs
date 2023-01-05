using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class MedicineInstruction_dt
    {
        public string short_name { get; set; }
        public string full_name { get; set; }
        public string nepali_full_name { get; set; }
        public float times { get; set; }
    }

    public class MedicineInstructionSelect_dt
    {
        public int sn { get; set; }
        public string short_name { get; set; }
        public string full_name { get; set; }
        public string nepali_full_name { get; set; }
        public float times { get; set; }
    }
}