using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class receipt_dt
    {
        public string r_no { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public double amount { get; set; }
        public int user { get; set; }
        public string billtime { get; set; }
        public string due { get; set; }
        public string remarks { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public int firm { get; set; }
        public bool canceled { get; set; }
        public bool postledger { get; set; }
        public int ipdno { get; set; }
        public bool ipd { get; set; }
        public string inv_no1 { get; set; }
        public int serialno { get; set; }
        public bool refund { get; set; }
        public int cancel_id { get; set; }
        public DateTime cancel_date { get; set; }
        public double rebate { get; set; }
    }

    public class receiptList_dt
    {
        public List<receipt_dt> Receipt { get; set; }
    }
    public class receiptDelete_dt
    {
        public int r_no { get; set; }
    }
}