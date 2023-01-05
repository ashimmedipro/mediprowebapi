using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Division_dt
    {
        public int dp_id { get; set; }
        public string groupname { get; set; }
        public string status { get; set; }
        public bool detail { get; set; }
        public bool lab { get; set; }
        public bool service { get; set; }
    }

    public class Divisionselectbydate_dt
    {
        public string bs_date { get; set; }
    }

    public class DivisionList_dt
    {
        public List<Division_dt> Division { get; set; }
    }

    public class DivisionReport_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public int tech_code { get; set; }
        public int disc_code { get; set; }
        public double amt { get; set; }
        public double pc { get; set; }
        public bool gross { get; set; }
        public int plid { get; set; }
        public int serial { get; set; }
        public int dp_id { get; set; }
        public bool opddepart { get; set; }
        public bool referer { get; set; }
        public bool report { get; set; }
        public string reporttitle { get; set; }
        public string appointment_endtime { get; set; }
        public int hospital_code { get; set; }
        public int appointment_limit { get; set; }
        public bool appointment { get; set; }
        public bool su { get; set; }
        public bool mo { get; set; }
        public bool tu { get; set; }
        public bool we { get; set; }
        public bool th { get; set; }
        public bool fr { get; set; }
        public bool sa { get; set; }
        public string particular { get; set; }
        public string technical { get; set; }
        public string discount { get; set; }
    }

}