using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.PharmaDocs
{
    public class Config_dt
    {
        public int sn { get; set; }
        public string item { get; set; }
        public string   value { get; set; }
        public string description { get; set; }
        public string edited { get; set; }
    }



    public class ConfigDelete_dt
    {
        public int sn { get; set; }
    }
}