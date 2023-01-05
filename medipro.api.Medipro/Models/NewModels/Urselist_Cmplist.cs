using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels
{
    public class Temp_Urselist_CmplistInsert_dt
    {
        public int userid { get; set; }
        public int compcode { get; set; }
    }




    public class Temp_Urselist_CmplistDelete_dt
    {
        public int sn { get; set; }

    }

    public class UserCmplistGet_dt
    {
        public int sn { get; set; }
        public int userid { get; set; }
        public int compcode { get; set; }
        public string compname { get; set; }
        public string address { get; set; }
    }


}