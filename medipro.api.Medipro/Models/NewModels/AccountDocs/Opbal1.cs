using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class Opbal1_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int ac_code { get; set; }
        public int firm { get; set; }
        public double balance { get; set; }
        public double lastbal { get; set; }
        public double budget { get; set; }
        public string fy { get; set; }
    }

    public class OpbalSelect_dt
    {
        public int ac_code { get; set; }
        public string particular { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public double lastbal { get; set; }
        public double budget { get; set; }
    }

    public class OpbalList_dt
    {
        public List<OpbalSelect_dt> Opbal { get; set; }
    }

    public class Opbal_selectByFirmandBalance_dt
    {
        public int sb_code { get; set; }
        public bool debtor { get; set; }
        public bool supplier { get; set; }
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public string ref_code { get; set; }
        public string ac_type { get; set; }
        public int ac_code { get; set; }
        public string particular { get; set; }
        public int firm { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
        public double lastbal { get; set; }
        public double budget { get; set; }
        public string fy { get; set; }
        public double balance { get; set; }
    }

    public class Opbal1Debit_dt
    {
        public double debit { get; set; }
    }

    public class Opbal1Credit_dt
    {
        public double Credit { get; set; }
    }

    public class Opbal1Delete_dt
    {
        public int sn { get; set; }
    }
}