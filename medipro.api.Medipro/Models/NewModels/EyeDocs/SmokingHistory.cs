using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class SmokingHistoryAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public int smkcig_tick { get; set; }//this is 3 value param
        public string smkcig_ps_age { get; set; }
        public string smkcig_ps_year { get; set; }
        public string smkcig_ps_no { get; set; }
        public string smkcig_ps_yrs { get; set; }
        public string smkcig_ps_ddate { get; set; }
        public string smkcig_cs_age { get; set; }
        public string smkcig_cs_no { get; set; }
        public string smkcig_cs_yrs { get; set; }
        public string smkcig_cs_ddate { get; set; }
        public bool househld_tick { get; set; }
        public int alccon_tick { get; set; }
        public string alccon_pre { get; set; }
        public bool alccon_pre_od_tick { get; set; }
        public bool alccon_pre_sd_tick { get; set; }
        public bool alccon_pre_cd_tick { get; set; }
        public string alccon_pre_usn { get; set; }
        public string alccon_pre_noyr { get; set; }
        public string alccon_pre_qt { get; set; }
        public bool alccon_pre_pan_tick { get; set; }
        public string alccon_pre_pan { get; set; }
        public string alccon_pas { get; set; }
        public bool alccon_pas_od_tick { get; set; }
        public bool alccon_pas_sd_tick { get; set; }
        public bool alccon_pas_cd_tick { get; set; }
        public string alccon_pas_usn { get; set; }
        public string alccon_pas_stop { get; set; }
        public string alccon_pas_noyr { get; set; }
        public string alccon_pas_qt { get; set; }
        public bool alccon_pas_pan_tick { get; set; }
        public string alccon_pas_pan { get; set; }
        public bool oth_pre_bd_tick { get; set; }
        public string oth_pre_bd { get; set; }
        public bool oth_pre_tm_tick { get; set; }
        public string oth_pre_tm { get; set; }
        public bool oth_pre_hka_tick { get; set; }
        public string oth_pre_hka { get; set; }
        public bool oth_pas_bd_tick { get; set; }
        public string oth_pas_bd { get; set; }
        public bool oth_pas_tm_tick { get; set; }
        public string oth_pas_tm { get; set; }
        public bool oth_pas_hka_tick { get; set; }
        public string oth_pas_hka { get; set; }
    }


    public class SmokingHistorySelectAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string smkcig_tick { get; set; }//this is 3 value param
        public string smkcig_ps_age { get; set; }
        public string smkcig_ps_year { get; set; }
        public string smkcig_ps_no { get; set; }
        public string smkcig_ps_yrs { get; set; }
        public string smkcig_ps_ddate { get; set; }
        public string smkcig_cs_age { get; set; }
        public string smkcig_cs_no { get; set; }
        public string smkcig_cs_yrs { get; set; }
        public string smkcig_cs_ddate { get; set; }
        public bool househld_tick { get; set; }
        public string alccon_tick { get; set; }
        public string alccon_pre { get; set; }
        public bool alccon_pre_od_tick { get; set; }
        public bool alccon_pre_sd_tick { get; set; }
        public bool alccon_pre_cd_tick { get; set; }
        public string alccon_pre_usn { get; set; }
        public string alccon_pre_noyr { get; set; }
        public string alccon_pre_qt { get; set; }
        public bool alccon_pre_pan_tick { get; set; }
        public string alccon_pre_pan { get; set; }
        public string alccon_pas { get; set; }
        public bool alccon_pas_od_tick { get; set; }
        public bool alccon_pas_sd_tick { get; set; }
        public bool alccon_pas_cd_tick { get; set; }
        public string alccon_pas_usn { get; set; }
        public string alccon_pas_stop { get; set; }
        public string alccon_pas_noyr { get; set; }
        public string alccon_pas_qt { get; set; }
        public bool alccon_pas_pan_tick { get; set; }
        public string alccon_pas_pan { get; set; }
        public bool oth_pre_bd_tick { get; set; }
        public string oth_pre_bd { get; set; }
        public bool oth_pre_tm_tick { get; set; }
        public string oth_pre_tm { get; set; }
        public bool oth_pre_hka_tick { get; set; }
        public string oth_pre_hka { get; set; }
        public bool oth_pas_bd_tick { get; set; }
        public string oth_pas_bd { get; set; }
        public bool oth_pas_tm_tick { get; set; }
        public string oth_pas_tm { get; set; }
        public bool oth_pas_hka_tick { get; set; }
        public string oth_pas_hka { get; set; }
    }
    public class SmokingHistoryInsert_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class SmokingHistoryUpdate_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class SmokingHistorySelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class SmokingHistoryDelete_dt
    {
        public string mrdno { get; set; }
    }
}