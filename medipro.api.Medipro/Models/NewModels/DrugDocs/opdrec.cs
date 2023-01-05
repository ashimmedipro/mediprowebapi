using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.DrugDocs
{
    public class opdrec_dt
    {
        public int sn { get; set; }
        public int hospid { get; set; }
        public DateTime ddate { get; set; }
        public string inv_no1 { get; set; }
        public int servid { get; set; }
        public int qty { get; set; }
        public double rate { get; set; }
        public double disc { get; set; }
        public double vat { get; set; }
        public string inv_no { get; set; }
        public bool done { get; set; }
        public bool panel { get; set; }
        public int hospid1 { get; set; }
        public int firm { get; set; }
        public DateTime finish_date { get; set; }
        public string finish_time { get; set; }
        public bool formatted { get; set; }
        public int lines { get; set; }
        public double disc2 { get; set; }
        public double disc_amt { get; set; }
        public double vatamt { get; set; }
        public double dueamt { get; set; }
        public double paid { get; set; }
        public double process { get; set; }
        public string r_no { get; set; }
        public DateTime rdate { get; set; }
        public double duepaid { get; set; }
        public string due { get; set; }
        public bool sampled_collected { get; set; }
        public DateTime sample_date { get; set; }
        public int sample_userid { get; set; }
        public double cost { get; set; }
        public double xchange { get; set; }
        public string testnote { get; set; }
        public bool refund { get; set; }
        public string sample_no { get; set; }
        public DateTime report_datetime { get; set; }
        public int result_id { get; set; }
        public int verified_id { get; set; }
        public int report_userid { get; set; }
        public bool resulted { get; set; }
        public bool verified { get; set; }
        public bool reported { get; set; }
        public int pathologist_id { get; set; }
        public int technician_id { get; set; }
        public int assistant_id { get; set; }
    }

    public class opdrecList_dt
    {
        public List<opdrec_dt> Opdrec { get; set; }
    }

    public class opdrecDelete_dt
    {
        public int sn { get; set; }
    }
}