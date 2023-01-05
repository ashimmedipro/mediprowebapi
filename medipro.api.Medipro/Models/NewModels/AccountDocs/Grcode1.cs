using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class Grcode1_dt
    {
        public int gr_code { get; set; }
        public string particular { get; set; }
        public bool FIXED { get; set; }
        public string ac_type { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public string groups { get; set; }
        public string details { get; set; }
    }

    public class Grcode1InsertSelect_dt
    {
        public int gr_code { get; set; }
        public string particular { get; set; }
        public bool FIXED { get; set; }
        public string ac_type { get; set; }
        public int serial { get; set; }
        public string inactive { get; set; }
        public string groups { get; set; }
        public string details { get; set; }
        public int groupname { get; set; }
    }

    public class Grcode1Delete_dt
    {
        public int gr_code { get; set; }

    }

    public class GrcodeList_dt
    {
        public List<Grcode1_dt> Grcode { get; set; }
    }
}