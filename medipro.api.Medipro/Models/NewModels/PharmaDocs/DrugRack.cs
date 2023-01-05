using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DrugRack_dt
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string rackno { get; set; }
        public int rack_group { get; set; }
        public string detail { get; set; }
        public int firm { get; set; }
    }

    public class DrugRackSelect_dt
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string rackno { get; set; }
        public int rack_group { get; set; }
        public string detail { get; set; }
        public int firm { get; set; }
        public string rackgroup { get; set; }
    }

    public class DrugRackList_dt
    {
        public List<DrugRackSelect_dt> Drugrack { get; set; }
    }
}