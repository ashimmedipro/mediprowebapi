using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DrugRackGroup_dt
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string detail { get; set; }
    }

    public class DrugRackGroupSelect_dt
    {
        public int sn { get; set; }
        public string detail { get; set; }
    }

    public class DrugRackGroupList_dt
    {
        public List<DrugRackGroupSelect_dt> Drugrackgroup { get; set; }
    }
}