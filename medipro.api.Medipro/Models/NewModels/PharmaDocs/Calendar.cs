using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Calendar_dt 
    {
        public DateTime ad_date { get; set; }
        public string bs_date { get; set; }
        public string remarks { get; set; }
        public bool holiday_fl { get; set; }
    }

    public class CalendarList_dt
    {
        public List<Calendar_dt> Calendar { get; set; }
    }

    public class CalendarSelectbyAd_dt
    {
        public string bs_date { get; set; }
    }


    public class CalendarDelete_dt
    {
        public DateTime ad_date { get; set; }
    }

}