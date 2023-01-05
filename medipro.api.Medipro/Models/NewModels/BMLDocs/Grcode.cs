using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.BMLDocs
{
    public class GrcodeInsertUpdate_dt
    {
        public string mode { get; set; }
        public string gr_code { get; set; }
        public string particular { get; set; }
        public string fixedd { get; set; }
        public string ac_type { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; } 
    }

    public class GrcodeselectById_dt
    {
        public string gr_code { get; set; }
        public string particular { get; set; }
        public string fixedd { get; set; }
        public string ac_type { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
    }
    public class GrcodeSelect_dt
    {
        public string gr_code { get; set; }
        public string particular { get; set; }
        public string FIXED { get; set; }
        public string ac_type { get; set; }
        public int search { get; set; }
        public string inactive { get; set; }
        public string groups { get; set; }
        public string details { get; set; }
    }

    public class Grcode_dt
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
}