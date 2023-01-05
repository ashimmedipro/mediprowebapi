using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EMRDocs
{
    public class EmrMaster_dt
    {

        public string inv_no { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public string bedno { get; set; }
        public int ipdno { get; set; }
        public int refid { get; set; }
    }


    public class EmrMasterDelete_dt
    {

        public string inv_no { get; set; }

    }

}