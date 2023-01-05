using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class AdjrecPurch_dt 
    {
        public double c_price1 { get; set; }
        public double i_price1 { get; set; }
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int md_code { get; set; }
        public string fy { get; set; }
        public string inv_no { get; set; }
        public int pt_code { get; set; }
        public string type { get; set; }
        public string batch { get; set; }
        public DateTime exp_date { get; set; }
        public int qty { get; set; }
        public int free { get; set; }
        public float truerate { get; set; }
        public float rate { get; set; }
        public float i_price { get; set; }
        public float c_price { get; set; }
        public float s_price { get; set; }
        public float excise { get; set; }
        public float mrp { get; set; }
        public float vat { get; set; }  
        public float disco { get; set; }
        public int user { get; set; }
        public float cc { get; set; }
        public string remarks { get; set; }
        public DateTime purdate { get; set; }
        public string mrnno { get; set; }
        public int ac_code { get; set; }
        public int store { get; set; }
    }

    public class AdjrecPurchList_dt
    {
        public List<AdjrecPurch_dt> Adjrecpurch { get; set; }
    }
}