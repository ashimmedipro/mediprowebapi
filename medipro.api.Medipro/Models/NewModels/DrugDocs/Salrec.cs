using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Salrec_dt
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
        public double truerate { get; set; }
        public float rate { get; set; }
        public double i_price { get; set; }
        public float c_price { get; set; }
        public double s_price { get; set; }
        public double excise { get; set; }
        public double mrp { get; set; }
        public double vat { get; set; }
        public double disco { get; set; }
        public int rep_code { get; set; }
        public double cc { get; set; }
        public string salestype { get; set; }
        public DateTime purdate { get; set; }
        public string mrnno { get; set; }
        public int ac_code { get; set; }
        public string billon { get; set; }
        public bool department { get; set; }
        public double scheme { get; set; }
        public int store { get; set; }
        public int bonus { get; set; }
        public int onminq { get; set; }
        public int retqty { get; set; }
        public string ref_code { get; set; }
        public float pc { get; set; }
        public float net { get; set; }
        public float c_price2 { get; set; }
        public string barcode { get; set; }
        public double t_price { get; set; }
        public int tran_id { get; set; }
        public string sl_type { get; set; }
        public bool bulk { get; set; }
        public double mrrate { get; set; }
        public string refno { get; set; }
        public int reserved_qty { get; set; }
        public int reserved_free { get; set; }
        public string vat_free { get; set; }
    }

    public class SalrecList_dt
    {
        public List<Salrec_dt> Salrec { get; set; }
    }
    public class SalrecDelete_dt
    {
        public int sn { get; set; }
    }
}