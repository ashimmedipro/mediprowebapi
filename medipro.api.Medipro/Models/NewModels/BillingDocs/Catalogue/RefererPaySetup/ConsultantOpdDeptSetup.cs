using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.RefererPaySetup
{
    public class RefererGet_dt
    {
        public int refid { get; set; }
        public string referer { get; set; }
    }

    public class DepartmentGet_dt
    {
        public string groupname { get; set; }
        public int grpid { get; set; }
    }


    public class Ref_DepartmentGet_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public string type { get; set; }
    }


}