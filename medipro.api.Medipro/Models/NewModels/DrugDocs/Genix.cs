using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class Genix_dt
    {
        public int genid { get; set; }
        public string genericname { get; set; }
        public int grpid { get; set; }
        public int drugcat { get; set; }
        public bool morning { get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public bool night { get; set; }
        public bool empty { get; set; }
        public bool after_meal { get; set; }
        public bool before_meal { get; set; }
        public bool sleep { get; set; }
        public string times { get; set; }
        public string english { get; set; }
        public string nepali { get; set; }
        public int days { get; set; }
        public string remarks { get; set; }
        public int dosetype { get; set; }
        public int dose_detail { get; set; }
    }
    public class GenixSelect_dt
    {
        public int genid { get; set; }
        public string genericname { get; set; }
        public int grpid { get; set; }
        public int drugcat { get; set; }
        public bool morning { get; set; }
        public bool afternoon { get; set; }
        public bool evening { get; set; }
        public bool night { get; set; }
        public bool empty { get; set; }
        public bool after_meal { get; set; }
        public bool before_meal { get; set; }
        public bool sleep { get; set; }
        public string times { get; set; }
        public string english { get; set; }
        public string nepali { get; set; }
        public int days { get; set; }
        public string remarks { get; set; }
        public int dosetype { get; set; }
        public int dose_detail { get; set; }
        public int catid { get; set; }
        public string groupname { get; set; }
        public string doses_name { get; set; }
        public string detail_nepali { get; set; }
        public string category_name { get; set; }
      //  public string grupname1 { get; set; }
    }

    public class GenixDelete_dt
    {
        public int genid { get; set; }
    }

    public class generic_dt
    {
        public List<Genix_dt> Generic { get; set; }
    }

    
}