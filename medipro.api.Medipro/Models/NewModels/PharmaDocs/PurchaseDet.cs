using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class TPurchDet_dt
    {
        //public int sn { get; set; }
        public int userid { get; set; }
        public int md_code { get; set; }
        public string particular { get; set; }
        public string pack { get; set; }
        public string batch { get; set; }
        public DateTime expiry { get; set; }
        public float qty { get; set; }
        public float free { get; set; }
        public float i_price { get; set; }
        public float c_price { get; set; }
        public float s_price { get; set; }
        public float mrp { get; set; }
        public float excise { get; set; }
        public float ic_price { get; set; }
        public float cc { get; set; }
        public float vat { get; set; }
        public float disc { get; set; }
        public float disc_amt { get; set; }
        public float cccharge { get; set; }
        public float ccFree { get; set; }
        public int onminq { get; set; }
        public int bonus { get; set; }
        public int onminl { get; set; }
        public int lotbonus { get; set; }
        public int qty_limit { get; set; }
        public float margin { get; set; }
        public float cc1 { get; set; }
        public float margin2 { get; set; }
        public int wsunit { get; set; }
        public int store { get; set; }
        public int old_i_price { get; set; }
        public float old_c_price { get; set; }
        public float old_s_price { get; set; }
        public float old_mrp { get; set; }
        public string mrp_ic_nc { get; set; }
        public string barcode { get; set; }
        public double t_price { get; set; }
        public int tran_id { get; set; }
        public double scheme { get; set; }
        public double true_c_price { get; set; }
        public float prev_i_price { get; set; }
        public float prev_s_price { get; set; }
        public float prev_mrp { get; set; }
        public float prev_free { get; set; }
        public float prev_disc { get; set; }
        public string prev_inv_no { get; set; }
        public int order_qty { get; set; }
        public double xchange { get; set; }
        public bool vat_free { get; set; }
    }

    public class TpurchdetEdit_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
        public int md_code { get; set; }
        public string particular { get; set; }
        public string pack { get; set; }
        public string batch { get; set; }
        public DateTime expiry { get; set; }
        public int qty { get; set; }
        public float free { get; set; }
        public float i_price { get; set; }
        public float c_price { get; set; }
        public float s_price { get; set; }
        public float mrp { get; set; }
        public float excise { get; set; }
        public float ic_price { get; set; }
        public float cc { get; set; }
        public float vat { get; set; }
        public float disc { get; set; }
        public float disc_amt { get; set; }
        public float cccharge { get; set; }
        public float ccfree { get; set; }
        public int onminq { get; set; }
        public int bonus { get; set; }
        public int onminl { get; set; }
        public int lotbonus { get; set; }
        public int qty_limit { get; set; }
        public float margin { get; set; }
        public float cc1 { get; set; }
        public float margin2 { get; set; }
        public int wsunit { get; set; }
        public int store { get; set; }
        public int old_i_price { get; set; }
        public float old_c_price { get; set; }
        public float old_s_price { get; set; }
        public float old_mrp { get; set; }
        public string mrp_ic_nc { get; set; }
        public string barcode { get; set; }
        public double t_price { get; set; }
        public int tran_id { get; set; }
        public double scheme { get; set; }
        public double true_c_price { get; set; }
        public float prev_i_price { get; set; }
        public float prev_s_price { get; set; }
        public float prev_mrp { get; set; }
        public float prev_free { get; set; }
        public float prev_disc { get; set; }
        public string prev_inv_no { get; set; }
        public int order_qty { get; set; }
        public double xchange { get; set; }
        public bool vat_free { get; set; }
    }

    public class TPurchDetSelect_dt
    {
        public bool vat_free { get; set; }
        public int totalqty { get; set; }
        public int sn { get; set; }
        public int md_code { get; set; }
        public string particular { get; set; }
        public string pack { get; set; }
        public string batch { get; set; }
        public DateTime expiry { get; set; }
        public int qty { get; set; }
        public float free { get; set; }
        public float i_price { get; set; }
        public float c_price { get; set; }
        public float s_price { get; set; }
        public float mrp { get; set; }
        public float excise { get; set; }
        public float ic_price { get; set; }
        public float cc { get; set; }
        public float vat { get; set; }
        public float disc { get; set; }
        public float disc_amt { get; set; }
        public float cccharge { get; set; }
        public float ccFree { get; set; }
        public int onminq { get; set; }
        public int bonus { get; set; }
        public int onminl { get; set; }
        public int lotbonus { get; set; }
        public int qty_limit { get; set; }
        public float margin { get; set; }
        public int net { get; set; }
        public int wsunit { get; set; }
        public int store { get; set; }
        public float cc1 { get; set; }
        public int old_i_price { get; set; }
        public float old_c_price { get; set; }
        public float old_s_price { get; set; }
        public float old_mrp { get; set; }
        public string mrp_ic_nc { get; set; }
        public string barcode { get; set; }
        public double t_price { get; set; }
        public double scheme { get; set; }
        public double tax_rate { get; set; }
        public double true_c_price { get; set; }
        public float prev_S_price { get; set; }
        public float prev_mrp { get; set; }
        public float prev_free { get; set; }
        public float prev_disc { get; set; }
        public string prev_inv_no { get; set; }
        public string order_qty { get; set; }
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
        public float calculate_cprice { get; set; }
        public int cc_inc { get; set; }
        public float purch { get; set; }
        public int tran_id { get; set; }
    }

    public class TpurchdetSelectDrugDetails_dt
    {
        public float amount { get; set; }
        public float excise { get; set; }
        public double scheme { get; set; }
        public float vat { get; set; }
        public float amount1 { get; set; }
        public float cc_charge { get; set; }
        public float cc_free { get; set; }
        public float discount { get; set; }
    }

    public class TempPurcdetSum_dt
    {
        public float taxable { get; set; }
        public float tax { get; set; }
        public float free_vat { get; set; }
    }

    public class TPurchDetDelete_dt
    {
        public int sn { get; set; }
    }

    public class TpurchdetSelectbyUserid_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public string particular { get; set; }
        public string pack { get; set; }
        public string batch { get; set; }
        public DateTime expiry { get; set; }
        public int qty { get; set; }
        public int free { get; set; }
        public float i_price { get; set; }
        public float c_price { get; set; }
        public float s_price { get; set; }
        public double mrp { get; set; }
        public float excise { get; set; }
        public float ic_price { get; set; }
        public float cc { get; set; }
        public float vat { get; set; }
        public float disc { get; set; }
        public float discamt { get; set; }
        public float cccharge { get; set; }
        public float ccfree { get; set; }
        public int onminq { get; set; }
        public int bonus { get; set; }
        public int onminl { get; set; }
        public int lotbonus { get; set; }
        public int qty_limit { get; set; }
        public float margin { get; set; }
        public float cc1 { get; set; }
        public float margin2 { get; set; }
        public int wsunit { get; set; }
        public int store { get; set; }
        public float old_i_price { get; set; }
        public float old_c_price { get; set; }
        public float old_s_price { get; set; }
        public float old_mrp { get; set; }
        public string mrp_ic_nc { get; set; }
        public string barcode { get; set; }
        public double t_price { get; set; }
        public int tran_id { get; set; }
        public double scheme { get; set; }
        public double tax_rate { get; set; }
        public double true_c_price { get; set; }
        public float prev_i_price { get; set; }
        public float prev_s_price { get; set; }
        public float prev_mrp { get; set; }
        public float prev_free { get; set; }
        public float prev_disc { get; set; }
        public string prev_inv_no { get; set; }
        public int order_qty { get; set; }
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
        public int cc_inc { get; set; }
        public double xchange { get; set; }
        public float calculate_cprice { get; set; }
        public int userid { get; set; }
        public double vat_Free { get; set; }
    }
}