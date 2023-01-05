using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Adjrec_dt
    {
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
        public double rate { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double excise { get; set; }
        public double mrp { get; set; }
        public double vat { get; set; }
        public double disco { get; set; }
        public int user { get; set; }
        public double cc { get; set; }
        public string remarks { get; set; }
        public DateTime purdate { get; set; }
        public string mrnno { get; set; }
        public int ac_code { get; set; }
        public int store { get; set; }
        public int bonus { get; set; }
        public int onminq { get; set; }
        public int edited { get; set; }
        public string barcode { get; set; }
        public int barqty { get; set; }
        public double t_price { get; set; }
        public int tran_id { get; set; }
        public bool stocktransfer { get; set; }
        public bool website_update { get; set; }
    }
    public class AdjrecDelete_dt
    {
        public int sn { get; set; }
    }

    public class AdjrecList_dt
    {
        public List<Adjrec_dt> Adjrec { get; set; }
    }
}