using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class NepaliMonth_dt
    {
        public int sn { get; set; }
        public string serial { get; set; }
        public string monthname { get; set; }
        public string engmonth { get; set; }
    }

    public class NepaliMonthDelete_dt
    {
        public string serial { get; set; }
    }
}