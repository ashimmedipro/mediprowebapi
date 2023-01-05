using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class CmplistVsSupSelect_dt
    {
        public int sn { get; set; }
        public int compcode { get; set; }
        public int ac_code { get; set; }
        public double disc { get; set; }
        public string compname { get; set; }
        public string particular { get; set; }
    }

    public class CmplistVsSupList_dt
    {
        public List<CmplistVsSupSelect_dt> CompanyVsSupplier { get; set; }
    }
}