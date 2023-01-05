using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue
{
    public class BedRack_dt
    {
        public string bedno { get; set; }
        public int wardno { get; set; }
        public string remarkstype { get; set; }
        public string remarks { get; set; }
    }

    public class BedRackSelect_dt
    {
        public string bedno { get; set; }
        public string wardno { get; set; }
        public string remarkstype { get; set; }
        public string remarks { get; set; }
        public DateTime discharge_date { get; set; }
        public bool discharge { get; set; }
        public int ipdno { get; set; }
        public DateTime admitdate { get; set; }
        public int booked { get; set; }
        public string particular { get; set; }
    }

}