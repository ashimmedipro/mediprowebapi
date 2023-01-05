using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class OpenStockEntryInsert_Dt
    {
        public string inv_no { get; set; }
        public int md_code { get; set; }
        public int tran_id { get; set; }
        public int id { get; set; }
        public int sn { get; set; }
        public string batch { get; set; }
        public DateTime exp_date { get; set; }
        public int qty { get; set; }
        public int ncommitted { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double mrp { get; set; }
        public double excise { get; set; }
        public bool locked { get; set; }
        public string remarks { get; set; }
        public double onminq { get; set; }
        public double bonus { get; set; }
        public DateTime purdate { get; set; }
        public int firm { get; set; }
        public string mrnno { get; set; }
        public int ac_code { get; set; }
        public int store { get; set; }
        public double t_price { get; set; }
        public double barcode { get; set; }
        public bool reserved { get; set; }
        public int salrec_sn { get; set; }
    }
}