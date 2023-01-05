using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class TempMedicinePlanInsert_dt
    {
        public string mrdno { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string billtime { get; set; }
        public string prodname { get; set; }
        public string prodtype { get; set; }
        public int frequency { get; set; }
        public string eye { get; set; }
        public int duration { get; set; }
        public int userid { get; set; }
        public string plantype { get; set; }

    }

    public class TempMedicinePlanSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public DateTime billtime { get; set; }
        public string prodname { get; set; }
        public string prodtype { get; set; }
        public int frequency { get; set; }
        public string eye { get; set; }
        public int duration { get; set; }
        public int userid { get; set; }
        public string plantype { get; set; }
    }


    public class TempMedicinePlanDelete_dt
    {
        public int sn { get; set; }
    }

    public class MedicinePlanInsert_dt
    {
        public int userid { get; set; }
        public string mrdno { get; set; }
        public string plantype { get; set; }

    }

    public class MedicinePlanSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string billtime { get; set; }
        public string prodname { get; set; }
        public string prodtype { get; set; }
        public int frequency { get; set; }
        public string eye { get; set; }
        public int duration { get; set; }
        public int userid { get; set; }
        public string plantype { get; set; }
    }

    public class TempMedPlanInsertFromMain_dt
    {
        public string mrdno { get; set; }
        public int userid { get; set; }
        public string plantype { get; set; }
    }


}