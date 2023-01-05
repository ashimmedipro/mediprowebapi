using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class EyeRegMemberUpdate_dt
    {
        public int hospid { get; set; }
        public string pname { get; set; }
        public DateTime dob { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string wardno { get; set; }
        public string occupation { get; set; }
        public string martialStatus { get; set; }

    }

    public class EyeRegMemberSelect_dt
    {
        public int hospid { get; set; }
        public string pname { get; set; }
        public DateTime dob { get; set; }
        public string sex { get; set; }
        public string address { get; set; }
        public string wardno { get; set; }
        public string occupation { get; set; }
        public string martialStatus { get; set; }

    }
}