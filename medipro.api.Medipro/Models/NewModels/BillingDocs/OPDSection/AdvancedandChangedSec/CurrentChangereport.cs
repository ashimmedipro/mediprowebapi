﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec
{
    public class CurrentChangereportSelect_dt
    {
        public int sn { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string inv_no1 { get; set; }
        public string remarks { get; set; }
        public float change { get; set; }
        public float paid { get; set; }
        public int user { get; set; }
        public int user1 { get; set; }
        public string billtime { get; set; }
        public string inv_no { get; set; }
        public int hospid1 { get; set; }
        public string pname { get; set; }
        public string bs_date { get; set; }
        public string username { get; set; }
        public string receivedby { get; set; }
    }
}