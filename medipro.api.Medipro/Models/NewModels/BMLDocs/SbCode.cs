using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.BMLDocs
{
    public class SbCodeInsertUpdate_dt 
    {
        public string mode { get; set; }
        public string sb_code { get; set; }
        public string particular { get; set; }
        public string Fixed { get; set; }
        public string gr_code { get; set; }
        public string details { get; set; }
        public string depriciation { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
    }

    public class SbcodeselectById_dt
    {
        public string sb_code { get; set; }
        public string particular { get; set; }
        public string Fixed { get; set; }
        public string gr_code { get; set; }
        public string grname { get; set; }
        public string details { get; set; }
        public string depriciation { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
    }

    public class SbcodeSelect_dt
    {
        public string sb_code { get; set; }
        public string particular { get; set; }
        public string Fixed { get; set; }
        public string gr_code { get; set; }
        public bool details { get; set; }
        public double depreciation { get; set; }
        public double depriciation { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
        public bool sbdetail { get; set; }
        public string code { get; set; }
    }

    public class Sbcode_dt 
    {
        public string sb_code { get; set; }
        public string particular { get; set; }
        public string Fixed { get; set; }
        public string gr_code { get; set; }
        public bool details { get; set; }
        public double depreciation { get; set; }
        public double depriciation { get; set; }
        public string serial { get; set; }
        public string inactive { get; set; }
        public string billmode { get; set; }
        public bool sbdetail { get; set; }
        public string code { get; set; }
    }


}