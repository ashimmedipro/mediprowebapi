using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Drafts_dt
    {
        public string fy { get; set; }
        public string df_no { get; set; }
        public DateTime ddate { get; set; }
        public int pt_code { get; set; }
        public string naration { get; set; }
        public float amount { get; set; }
        public int bank_code { get; set; }
        public double commission { get; set; }
        public string vr_no { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string vr_type { get; set; }
        public string billtime { get; set; }
        public string docno { get; set; }
        public double paid { get; set; }
        public int compcode { get; set; }
        public int rep_code { get; set; }
        public int comp_code { get; set; }
        public int div_id { get; set; }
        public DateTime bank_date { get; set; }
    }

    public class DraftsList_dt
    {
        public List<Drafts_dt> Drafts { get; set; }
    }

    public class DraftsDelete_dt
    {
        public string df_no { get; set; }
    }

    public class DraftReceiptEntry_dt
    {
        public int pt_code { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public string df_no { get; set; }
        public string naration { get; set; }
        public float amount { get; set; }
        public int bank_code { get; set; }
        public double commission { get; set; }
        public string vr_no { get; set; }
        public int user { get; set; }
        public string vr_type { get; set; }
        public string billtime { get; set; }
        public string docno { get; set; }
        public double paid { get; set; }
        public int comp_code { get; set; }
        public int rep_code { get; set; }
        public int div_id { get; set; }
        public int sn { get; set; }
       
    }
}