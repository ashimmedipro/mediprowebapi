using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.AccountDocs
{
    public class CardList_dt//checking card done ok why ?
    {
        public string mode { get; set; }
        public int sn { get; set; }
        public string cardname { get; set; }
        public int ac_code { get; set; }
    }

    public class CardListSelect_dt
    { 
        public int sn { get; set; }
        public string cardname { get; set; }
        public int ac_code { get; set; }
        public string particular { get; set; }
        public string shortname { get; set; }
    }

    public class CardListList_dt
    {
        public List<CardListSelect_dt> Cardlist { get; set; }
    }
}