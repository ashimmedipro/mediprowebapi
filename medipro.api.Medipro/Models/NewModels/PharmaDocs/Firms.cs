using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Firms_dt
    {
        public int firm { get; set; }
        public string firmname { get; set; }
        public string regno { get; set; }
        public string firmtype { get; set; }
        public bool active { get; set; }
        public int bank_code { get; set; }
        public string shortfirm { get; set; }
        public int pf_bank_code { get; set; }
        public bool store { get; set; }
        public int ac_code { get; set; }
        public string nepaliname { get; set; }
        public string nepaliaddress { get; set; }
        public DateTime opdbill_date { get; set; }
        public DateTime sales_date { get; set; }
        public string ims_stk_code { get; set; }
        public string firm_pan { get; set; }
        public bool stockist { get; set; }
    }

    public class FirmsDelete_dt
    {
        public int firm { get; set; }
    }

    public class photo_dt
    {
         //public string photo { get; set; }
       public byte[] photo { get; set; }

    }

    

}