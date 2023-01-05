using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection
{
    public class BedRackList_dt
    {
        public string bedno { get; set; }
        public int wardno { get; set; }
        public string remarkstype { get; set; }
        public string remarks { get; set; }
        public DateTime discharge_date { get; set; }
        public bool discharge { get; set; }
        public int ipdno { get; set; }
        public DateTime admitdate { get; set; }
        public string bedno1 { get; set; }
        public int booked { get; set; }
        public string particular { get; set; }
        public string pname { get; set; }
        public string bs_date { get; set; }
        public string book { get; set; }
    }
}