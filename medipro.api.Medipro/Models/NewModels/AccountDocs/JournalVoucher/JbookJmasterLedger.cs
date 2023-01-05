using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.BMLDocs
{
    public class JbookJmasterLedgerPosting_dt
    {
        public string vr_type { get; set; }
        public string firm { get; set; }
        public string ddate { get; set; }
        public string id { get; set; }
        public string naration { get; set; }
        public string userid { get; set; }
        public string posted { get; set; }
        public string vr_no { get; set; }
        public string inv_no { get; set; }
        public string fy { get; set; }
        public string billtime { get; set; }
        public string currency { get; set; }
    }

    public class JmasterSelectById_dt
    {
        public string vr_no1 { get; set; }
        public string vr_type { get; set; }
        public string firm { get; set; }
        public string ddate { get; set; }
        public string id { get; set; }
        public string naration { get; set; }
        public string user { get; set; }
        public string posted { get; set; }
        public string vr_no { get; set; }
        public string fy { get; set; }
        public string New { get; set; }
        public int userid { get; set; }
    }


    public class JbookSelectById_dt
    {
        public string firm { get; set; }
        public DateTime  ddate { get; set; }
        public DateTime ddate1 { get; set; }
        public int ac_code { get; set; }
        public string naration { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string vr_type { get; set; }
        public string vr_no { get; set; }
        public string fy { get; set; }
        public string currency { get; set; }
        public string bs_date { get; set; }
        public bool account_close { get; set; }
        public string fiscalyear { get; set; }

        
    }

    public class JbookList_dt
    {
        public string vr_no { get; set; }
        
        public string vr_type { get; set; }
        public DateTime ddate { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string bs_date { get; set; }



    }
    



}