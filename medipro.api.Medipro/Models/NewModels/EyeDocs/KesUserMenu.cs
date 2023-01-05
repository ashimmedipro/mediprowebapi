using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class KesUserMenuInsert_dt
    {
        public int userid { get; set; }
    }

    public class KesUserMenuEdit_dt
    {
        public bool flag { get; set; }
        public int menuid { get; set; }
        public int userid { get; set; }
    }

    public class KesUserMenuSelect_dt
    {

        public int nouseid { get; set; }
        public int menuid { get; set; }
        public int userid { get; set; }
        public bool flag { get; set; }
        public string menuname { get; set; }

    }
}