using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Salretu_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int md_code { get; set; }
        public string fy { get; set; }
        public string inv_no { get; set; }
        public int pt_code { get; set; }
        public string batch { get; set; }
        public DateTime exp_date { get; set; }
        public int qty { get; set; }
        public int free { get; set; }
        public float rate { get; set; }
        public double i_price { get; set; }
        public float c_price { get; set; }
        public double s_price { get; set; }
        public double excise { get; set; }
        public double mrp { get; set; }
        public double vat { get; set; }
        public double disc { get; set; }
        public int rep_code { get; set; }
        public string salestype { get; set; }
        public double cc { get; set; }
        public double scheme { get; set; }
        public int store { get; set; }
        public int bonus { get; set; }
        public int onminq { get; set; }
        public string ref_no { get; set; }
        public double sales_rate { get; set; }
        public float c_price2 { get; set; }
        public string barcode { get; set; }
        public int barqty { get; set; }
        public double t_price { get; set; }
        public int wsunit { get; set; }
        public bool bulk { get; set; }
        public int case_qty { get; set; }
        public int case_free { get; set; }
        public int loose_qty { get; set; }
        public int loose_free { get; set; }
        public double mrrrate { get; set; }
        public double true_rate { get; set; }
        public bool website_update { get; set; }
    }

    public class SalretuList_dt
    {
        public List<Salretu_dt> Salretu { get; set; }
    }
    public class SalretuDelete_dt
    {
        public int sn { get; set; }
    }
}