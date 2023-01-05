using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Purcdet_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int firm { get; set; }
        public int md_code { get; set; }
        public string fy { get; set; }
        public string inv_no { get; set; }
        public int pt_code { get; set; }
        public int free { get; set; }
        public string batch { get; set; }
        public DateTime exp_date { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double excise { get; set; }
        public double mrp { get; set; }
        public double vat { get; set; }
        public double cc { get; set; }
        public double disc { get; set; }
        public double discamt { get; set; }
        public int user { get; set; }
        public int onminq { get; set; }
        public int bonus { get; set; }
        public double xchange { get; set; }
        public int wsunit { get; set; }
        public int store { get; set; }
        public double ic_price { get; set; }
        public double free_amount { get; set; }
        public double percentage { get; set; }
        public float invoice_price { get; set; }
        public float new_cc { get; set; }
        public double discpercentage { get; set; }
        public double cost_price { get; set; }
        public float cc1 { get; set; }
        public float pc { get; set; }
        public float net { get; set; }
        public float c_price1 { get; set; }
        public string mrp_ic_nc { get; set; }
        public string barcode { get; set; }
        public int barqty { get; set; }
        public double t_price { get; set; }
        public double scheme { get; set; }
        public bool bulk { get; set; }
        public double true_c_price { get; set; }
        public double prev_i_price { get; set; }
        public double prev_s_price { get; set; }
        public double prev_mrp { get; set; }
        public double prev_free { get; set; }
        public double prev_disc { get; set; }
        public string prev_inv_no { get; set; }
        public int order_qty { get; set; }
        public double e_price { get; set; }
        public string vatable_ { get; set; }
        public double pc_ { get; set; }
        public double purch_amount_ { get; set; }
        public double extra_ { get; set; }
        public double rd_ { get; set; }
        public double discount_ { get; set; }
        public double freight_ { get; set; }
        public double vat_adjust_ { get; set; }
        public double vat_free_ { get; set; }
        public double adjust_ { get; set; }
        public double calculate_cprice { get; set; }
        public int cc_inc { get; set; }
        public bool calculate_price_correct { get; set; }
        public bool website_update { get; set; }
    }
    public class PurcdetList_dt
    {
        public List<Purcdet_dt> Purcdet { get; set; }
    }

    public class PurcdetDelete_dt
    {
        public int sn { get; set; }
    }
}