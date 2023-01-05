using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DrugGroup_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int catid { get; set; }
    }


    public class DrugGroupSelect_dt
    {
        public int grpid { get; set; }
        public string groupname { get; set; }
        public int catid { get; set; }
        public string category_name { get; set; }

    }

    public class DrugGroupDelete_dt
    {
        public int grpid { get; set; }
    }
}