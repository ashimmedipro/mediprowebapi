using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class PurchaseTerm_dt
    {
        public int sn { get; set; }
        public string particular { get; set; }
        public int ac_code { get; set; }
        public bool status { get; set; }
        public int tax_code { get; set; }
    }

    public class PurchaseTermselect_dt
    {
        public int sn { get; set; }
        public string particular { get; set; }
        public int ac_code { get; set; }
        public int tax_code { get; set; }
        public bool status { get; set; }
        public string acname { get; set; }
        public string tax_particular { get; set; }
    }   

    public class PurchaseTermList_dt
    {
        public List<PurchaseTermselect_dt> Purchaseterm { get; set; }
    }
}