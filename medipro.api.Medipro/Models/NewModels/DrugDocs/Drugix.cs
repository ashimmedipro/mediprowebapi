using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Drugix_dt
    {
        public int md_code { get; set; }
        public int genid { get; set; }
        public int compcode { get; set; }
        public string refcode { get; set; }
        public string prodname { get; set; }
        public string unit { get; set; }
        public string packing { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double ic_price { get; set; }
        public double mrp { get; set; }
        public double ex_price { get; set; }
        public double excise { get; set; }
        public double margin { get; set; }
        public double custom { get; set; }
        public double vatamt { get; set; }
        public string vat { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
        public string rackno { get; set; }
        public double onminq { get; set; }
        public double bonus { get; set; }
        public double onminl { get; set; }
        public double lotbonus { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public int drugcat { get; set; }
        public double qty_limit { get; set; }
        public string status { get; set; }
        public string ref_code { get; set; }
        public double margin2 { get; set; }
        public int grpid { get; set; }
        public int wsunit { get; set; }
        public int period { get; set; }
        public int stockday { get; set; }
        public int leadtime { get; set; }
        public int box { get; set; }
        public string barcode { get; set; }
        public string discount { get; set; }
        public string mrp_ic_nc { get; set; }
        public double t_price { get; set; }
        public int div_code { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int div_id { get; set; }
        public double t_price_ic { get; set; }
        public double mrrate { get; set; }
        public bool insurance { get; set; }
        public double insurance_rate { get; set; }
        public bool morning { get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public bool night { get; set; }
        public bool empty { get; set; }
        public bool after_meal { get; set; }
        public bool before_meal { get; set; }
        public bool sleep { get; set; }
        public string times { get; set; }
        public string english { get; set; }
        public string nepali { get; set; }
        public int days { get; set; }
        public string remarks { get; set; }
        public int dosetype { get; set; }
        public float dose_unit { get; set; }
        public int safety_stock { get; set; }
        public int rackid { get; set; }
        public string vat_free { get; set; }
    }

    public class DrugixList_dt
    {
        public List<DrugixSelect_dt> Drug { get; set; }
    }
    public class DrugixSelect_dt
    {
        public int md_code { get; set; }
        public int genid { get; set; }
        public int compcode { get; set; }
        public string refcode { get; set; }
        public string prodname { get; set; }
        public string unit { get; set; }
        public string packing { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double ic_price { get; set; }
        public double mrp { get; set; }
        public double ex_price { get; set; }
        public double excise { get; set; }
        public double margin { get; set; }
        public double custom { get; set; }
        public double vatamt { get; set; }
        public string vat { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
        public string rackno { get; set; }
        public double onminq { get; set; }
        public double bonus { get; set; }
        public double onminl { get; set; }
        public double lotbonus { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public int drugcat { get; set; }
        public double qty_limit { get; set; }
        public string status { get; set; }
        public string ref_code { get; set; }
        public double margin2 { get; set; }
        public int grpid { get; set; }
        public int wsunit { get; set; }
        public int period { get; set; }
        public int stockday { get; set; }
        public int leadtime { get; set; }
        public int box { get; set; }
        public string barcode { get; set; }
        public string discount { get; set; }
        public string mrp_ic_nc { get; set; }
        public double t_price { get; set; }
        public int div_code { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int div_id { get; set; }
        public double t_price_ic { get; set; }
        public double mrrate { get; set; }
        public bool insurance { get; set; }
        public double insurance_rate { get; set; }
        public bool morning { get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public bool night { get; set; }
        public bool empty { get; set; }
        public bool after_meal { get; set; }
        public bool before_meal { get; set; }
        public bool sleep { get; set; }
        public string times { get; set; }
        public string english { get; set; }
        public string nepali { get; set; }
        public int days { get; set; }
        public string remarks { get; set; }
        public int dosetype { get; set; }
        public float dose_unit { get; set; }
        public int safety_stock { get; set; }
        public int rackid { get; set; }
        public string vat_free { get; set; }
        public int catid { get; set; }
        public double Ws_Sprice { get; set; }
        public double WS_MRP { get; set; }
        public string compname { get; set; }
    }

    public class DrugixDelete_dt
    {
        public int md_code { get; set; }
    }

    public class DrugMaxSelect_dt
    {
        public int newcode { get; set; }
    }

    public class DrugSelectbyId_dt
    {
        public string division_name { get; set; }
        public string detail { get; set; }
        public string rackno { get; set; }
        public int md_code { get; set; }
        public int genid { get; set; }
        public int compcode { get; set; }
        public string refcode { get; set; }
        public string prodname { get; set; }
        public string unit { get; set; }
        public string packing { get; set; }
        public double i_price { get; set; }
        public double c_price { get; set; }
        public double s_price { get; set; }
        public double ic_price { get; set; }
        public double mrp { get; set; }
        public double ex_price { get; set; }
        public double excise { get; set; }
        public double margin { get; set; }
        public double custom { get; set; }
        public double vatamt { get; set; }
        public string vat { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
       // public string rackno { get; set; }
        public double onminq { get; set; }
        public double bonus { get; set; }
        public double onminl { get; set; }
        public double lotbonus { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public int drugcat { get; set; }
        public double qty_limit { get; set; }
        public string status { get; set; }
        public string ref_code { get; set; }
        public double margin2 { get; set; }
        public int grpid { get; set; }
        public int wsunit { get; set; }
        public int period { get; set; }
        public int stockday { get; set; }
        public int leadtime { get; set; }
        public int box { get; set; }
        public string barcode { get; set; }
        public string discount { get; set; }
        public string mrp_ic_nc { get; set; }
        public double t_price { get; set; }
        public int div_code { get; set; }
        public string color { get; set; }
        public string size { get; set; }
        public int div_id { get; set; }
        public double t_price_ic { get; set; }
        public double mrrate { get; set; }
        public bool insurance { get; set; }
        public double insurance_rate { get; set; }
        public bool morning { get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public bool night { get; set; }
        public bool empty { get; set; }
        public bool after_meal { get; set; }
        public bool before_meal { get; set; }
        public bool sleep { get; set; }
        public string times { get; set; }
        public string english { get; set; }
        public string nepali { get; set; }
        public int days { get; set; }
        public string remarks { get; set; }
        public int dosetype { get; set; }
        public float dose_unit { get; set; }
        public int safety_stock { get; set; }
        public int rackid { get; set; }
        public string vat_free { get; set; }
        public int catid { get; set; }
        public int qty { get; set; }
    }

}