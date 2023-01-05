using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class AdjBook_dt
    {
        public DateTime ddate { get; set; }
        public string fy { get; set; }
        public string inv_no { get; set; }
        public string naration { get; set; }
        public double amount { get; set; }
        public int user { get; set; }
        public int firm { get; set; }
        public string remarks { get; set; }
        public string billtime { get; set; }
        public float amount1 { get; set; }
        public int pt_code { get; set; }
        public bool website_update { get; set; }
    }

    public class AdjBookDelete_dt
    {
        public string inv_no { get; set; }
    }

    public class AdjBookList_dt
    {
        public List<AdjBook_dt> AdjBook { get; set; }
    }
}