using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class sbcode1_dt
    {
        public int sb_code { get; set; }
        public string particular { get; set; }
        public bool FIXED { get; set; }
        public int gr_code { get; set; }
        public bool details { get; set; }
        public double depriciation { get; set; }
        //public double depreciation { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
    }


    public class sbcode1Select_dt
    {
        public int sb_code { get; set; }
        public string particular { get; set; }
        public bool FIXED { get; set; }
        public int gr_code { get; set; }
        public bool details { get; set; }
        public double depreciation { get; set; }
        public double depriciation { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
        public bool sbdetail { get; set; }
        public string code { get; set; }
    }

    public class sbcode1LIst_dt
    {
        public List<sbcode1Select_dt> Sbcode { get; set; }
    }
    public class sbcode1Delete_dt
    {
        public int sb_code { get; set; }
    }
}