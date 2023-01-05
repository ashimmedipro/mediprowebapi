using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class Cluster_dt
    {
        public int cluster_no { get; set; }
        public string district { get; set; }
        public string vdc_mnp { get; set; }
        public int ward_no { get; set; }
    }

    public class ClusterMaxKesId_dt
    {
        public int max_kesid { get; set; }
    }
}