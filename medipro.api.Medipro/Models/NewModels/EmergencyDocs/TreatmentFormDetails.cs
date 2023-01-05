using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EmergencyDocs
{
    public class TreatmentFormDetailsInsert_dt
    {
        public int order_id { get; set; }
        public DateTime ddate { get; set; }
        public string drug { get; set; }
        public string each_dose { get; set; }
        public string route { get; set; }
        public string direction { get; set; }
        public string doctor_sign { get; set; }
        public string discontinueddate_initials { get; set; }
        public string instructions { get; set; }
        public string diet { get; set; }
    }

    public class TreatmentFormDetailsUpdate_dt
    {
        public int order_id { get; set; }
        public DateTime ddate { get; set; }
        public string drug { get; set; }
        public string each_dose { get; set; }
        public string route { get; set; }
        public string direction { get; set; }
        public string doctor_sign { get; set; }
        public string discontinueddate_initials { get; set; }
        public string instructions { get; set; }
        public string diet { get; set; }
    }

    public class TreatmentFormDetailsGetdata_dt
    {
        public int sn { get; set; }
        public int orderid { get; set; }
        public DateTime ddate { get; set; }
        public string drug { get; set; }
        public string each_dose { get; set; }
        public string route { get; set; }
        public string direction { get; set; }
        public string doctor_sign { get; set; }
        public string discontinueddate_initials { get; set; }
        public string instructions { get; set; }
        public string diet { get; set; }
    }

    public class TreatmentFormDetailsDelete_dt
    {
        public int order_id { get; set; }
    }
}