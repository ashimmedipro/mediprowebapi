using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class AdjLedger_dt 
    {
        public int sn { get; set; }
        public int firm { get; set; }
        public string  vr_no { get; set; }
        public DateTime ddate { get; set; }
        public int ac_code { get; set; }
        public string naration { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public string vr_type { get; set; }
        public string billtime { get; set; }
        public int user { get; set; }
    }

    public class AdjledgerList_dt
    {
        public List<AdjLedger_dt> Adjledger { get; set; }
    }
}