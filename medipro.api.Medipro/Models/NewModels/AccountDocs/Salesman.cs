using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class Salesman_dt
    {
        public int sm_code { get; set; }
        public string salesman { get; set; }
    }

    public class SalesmanList_dt
    {
        public List<Salesman_dt> Salesman { get; set; }
    }

}