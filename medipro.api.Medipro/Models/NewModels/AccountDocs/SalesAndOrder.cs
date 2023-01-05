using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class tempSalesOrderSelect_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public string prodname { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public int received { get; set; }
        public int temp_qty { get; set; }
        public double amount { get; set; }
        public double temp_amount { get; set; }
        public double bonus { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
        public int stock { get; set; }
        public int sales { get; set; }
        public string Packing { get; set; }
        public string unit { get; set; }
        public double vat { get; set; }
    }

    public class tempSalesOrderSelectSum_dt
    {
        public double amount { get; set; }
        public double temp_amount { get; set; }
    }
    public class tempSalesOrderInsert_dt 
    {
        public int md_code { get; set; }
        public int qty { get; set; }
        public int userid { get; set; }
        public double rate { get; set; }
        public double bonus { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
        public int sales { get; set; }
        public int stock { get; set; }
        public double vat { get; set; }
    }

    public class tempSalesOrderUpdate_dt
    {
        public string inv_no { get; set; }
        public int userid { get; set; }
    }

    public class tempSalesOrderDetailsInsert_dt
    {
        public string inv_no { get; set; }
        public int userid { get; set; }
    }

    public class SalesOrderInsert_dt
    {
        public string inv_no { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public int pt_code { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public string bill_no { get; set; }
        public DateTime bill_date { get; set; }
        public bool approved { get; set; }
        public DateTime delivery_date { get; set; }
        public string p_type { get; set; }
        public string remarks { get; set; }
    }

    public class tempSalesOrderDelete_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
    }

    public class SalesOrderSelectByDateRange_dt
    {
        public string inv_no { get; set; }
        public int firm { get; set; }
        public string fy { get; set; }
        public int pt_code { get; set; }
        public string particular { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public string billtime { get; set; }
        public string bill_no { get; set; }
        public DateTime bill_date { get; set; }
        public bool approved { get; set; }
        public DateTime delivery_date { get; set; }
        public int approved_id { get; set; }
        public DateTime approved_date { get; set; }
        public string p_type { get; set; }
    }

    public class SalesOrderSelectbyInvNo_dt
    {
        public int sn { get; set; }
        public int md_code { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double bonus { get; set; }
        public double disc { get; set; }
        public int rolevel { get; set; }
        public int sales { get; set; }
        public int stock { get; set; }
        public double vat { get; set; }
        public string prodname { get; set; }
        public int received { get; set; }
    }

    public class SalesOrderApproveUpdate_dt
    {
        public string inv_no { get; set; }
        public int approved_id { get; set; }
        public DateTime approved_date { get; set; }
        public bool approved { get; set; }
    }
}