
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport
{
    public class ConsultantReportSelect_dt
    {
        public int cons_code { get; set; }
        public int nob { get; set; }
        public double techamt { get; set; }
        public double consamt { get; set; }
        public double tdsamt { get; set; }
        public string consultant { get; set; }
    }

    public class ConsultantReportTotal_dt
    {
        public int nob { get; set; }
        public double techamt { get; set; }
        public double consamt { get; set; }
        public double tdsamt { get; set; }
    }
}