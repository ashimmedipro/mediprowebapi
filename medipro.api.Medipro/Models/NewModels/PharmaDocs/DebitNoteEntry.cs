using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DebitNoteEntry_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public string dr_no { get; set; }
        public string vr_type { get; set; }
        public int pt_code { get; set; }
        public float amount { get; set; }
        public string vr_no { get; set; }
        public int ac_code { get; set; }
        public string naration { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string billtime { get; set; }
        public double paid { get; set; }
        public int comp_code { get; set; }
        public int rep_code { get; set; }
        public bool opening { get; set; }
        public string ref_no { get; set; }
        public int div_id { get; set; }
    }
}