using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Transporter_dt
    {
        public int sn { get; set; }
        public string transpoter { get; set; }
    }

    public class TransporterDelete_dt
    {
        public int sn { get; set; }
    }

    public class TransporterList_dt
    {
        public List<Transporter_dt> Transporter { get; set; }
    }
}