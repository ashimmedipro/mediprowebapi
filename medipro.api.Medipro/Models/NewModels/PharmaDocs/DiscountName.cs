using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class DiscountName_dt
    {
        public int discount_id { get; set; }
        public string discount_name { get; set; }
        public string status { get; set; }
        public bool notify { get; set; }
        public string type { get; set; }
        public double pharmacy_disc { get; set; }
    }

    public class DiscountNameList_dt
    {
        public List<DiscountName_dt> Discountname { get; set; }
    }

    public class DiscountNameDelete_dt
    {
        public int discount_id { get; set; }       
    }

    public class DiscountNameSelectMax_dt
    {
        public int newcode { get; set; }
    }

    public class DiscountNameReprot_dt
    {
        public int discount_id { get; set; }
        public int grpid { get; set; }
        public string groupname { get; set; }
        public float disc { get; set; }
        public string type { get; set; }
    }

}