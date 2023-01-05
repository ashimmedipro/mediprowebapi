using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs.ReportAccount.Statement
{
    public class GroupStatement_dt
    {
        public int sect_code { get; set; }
        public string sector { get; set; }
        public string ac_code { get; set; }
        public string particular { get; set; }
        public double opening { get; set; }
        public double balance { get; set; }
        public double debit { get; set; }
        public double credit { get; set; }
    }
}