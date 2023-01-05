using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.BMLDocs
{
    public class VoucherEntryDeleteAll_dt
    {
        public int userid { get; set; }
    }

    public class VoucherEntryInsertJbook_dt
    {
        public int userid { get; set; }
        public string vr_no { get; set; }
    }   

    public class VoucherEntryInsertUpdate_dt 
    {
        public string mode { get; set; }
        public string sn { get; set; }
        public string ac_code { get; set; }
        public string naration { get; set; }
        public string rate { get; set; }
        public string debit { get; set; }
        public string credit { get; set; }
        public string fc_debit { get; set; }
        public string fc_credit { get; set; }
        public string userid { get; set; }
        public string sbled_code { get; set; } 
    }

    public class VoucherEntryDeleteById_dt
    {
        public int userid { get; set; }
        public int sn { get; set; }
    }

    public class VoucherEntrySelect_dt
    {
        public string sn { get; set; }
        public string ac_code { get; set; }
        public string particular { get; set; }
        public string naration { get; set; }
        public string rate { get; set; }
        public string debit { get; set; }
        public string credit { get; set; }
        public string fc_debit { get; set; }
        public string fc_credit { get; set; }   
        public int userid { get; set; }
        public string sbled_code { get; set; }
        public string subledgerac { get; set; }
    }

    public class Jbook2TempVoucher_dt
    {
        public string vr_no { get; set; }
        public int userid { get; set; }
    }


}