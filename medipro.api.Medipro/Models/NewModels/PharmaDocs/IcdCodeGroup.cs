using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class IcdCodeGroup_dt
    {
        public int icdgroup { get; set; }
        public string particular { get; set; }
        public int serial { get; set; }
        public string status { get; set; }
    }

    public class IcdCodeGroupDelete_dt
    {
        public int icdgroup { get; set; }
    }


}