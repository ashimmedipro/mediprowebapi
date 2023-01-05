using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue
{
    public class NagarVdcGet_dt
    {
        public int sn { get; set; }
        public int dis_id { get; set; }
        public string nagar_vdc { get; set; }
        public string nagar_vdc_type { get; set; }
        public string district { get; set; }
        public string zone { get; set; }
    }

    public class NagarVdcAddEdit_dt
    {
    public int sn { get; set; }
    public string mode { get; set; }
    public int dis_id { get; set; }
    public string nagar_vdc { get; set; }
    public string nagar_vdc_type { get; set; }
    }

    //ethinics
    public class EthinicsPost_dt
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string ethinic_code { get; set; }
        public string ethinics { get; set; }
    }

    public class EthinicsGet_dt
    {
        public int sn { get; set; }
        public string ethinic_code { get; set; }
        public string ethinics { get; set; }
    }


}