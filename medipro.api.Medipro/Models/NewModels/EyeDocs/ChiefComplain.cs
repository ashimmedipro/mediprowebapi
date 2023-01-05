using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class ChiefComplainAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public bool cheye_devi_od_tick { get; set; }
        public string cheye_devi_od { get; set; }
        public bool cheye_pain_od_tick { get; set; }
        public string cheye_red_od { get; set; }
        public bool cheye_water_od_tick { get; set; }
        public string cheye_water_od { get; set; }
        public bool cheye_fbsen_od_tick { get; set; }
        public string cheye_fbsen_od { get; set; }
        public bool cheye_itch_od_tick { get; set; }
        public string cheye_itch_od { get; set; }
        public bool cheye_ptb_od_tick { get; set; }
        public string cheye_ptb_od { get; set; }
        public bool cheye_flo_od_tick { get; set; }
        public string cheye_flo_od { get; set; }
        public bool cheye_fla_od_tick { get; set; }
        public string cheye_fla_od { get; set; }
        public bool cheye_dip_od_tick { get; set; }
        public string cheye_dip_od { get; set; }
        public bool cheye_sco_od_tick { get; set; }
        public string cheye_sco_od { get; set; }
        public bool cheye_colha_od_tick { get; set; }
        public string cheye_colha_od { get; set; }
        public bool cheye_oth_od_tick { get; set; }
        public string cheye_oth_od { get; set; }
        public bool cheye_devi_os_tick { get; set; }
        public string cheye_devi_os { get; set; }
        public bool cheye_pain_os_tick { get; set; }
        public string cheye_red_os { get; set; }
        public bool cheye_water_os_tick { get; set; }
        public string cheye_water_os { get; set; }
        public bool cheye_fbsen_os_tick { get; set; }
        public string cheye_fbsen_os { get; set; }
        public bool cheye_itch_os_tick { get; set; }
        public string cheye_itch_os { get; set; }
        public bool cheye_ptb_os_tick { get; set; }
        public string cheye_ptb_os { get; set; }
        public bool cheye_flo_os_tick { get; set; }
        public string cheye_flo_os { get; set; }
        public bool cheye_fla_os_tick { get; set; }
        public string cheye_fla_os { get; set; }
        public bool cheye_dip_os_tick { get; set; }
        public string cheye_dip_os { get; set; }
        public bool cheye_sco_os_tick { get; set; }
        public string cheye_sco_os { get; set; }
        public bool cheye_colha_os_tick { get; set; }
        public string cheye_colha_os { get; set; }
        public bool cheye_oth_os_tick { get; set; }
        public string cheye_oth_os { get; set; }
        public bool eyeconsult_tick { get; set; }
        // public bool eyeconsult_no_tick { get; set; }
        public string eyeconsult_no_lt { get; set; }
        public string eyeconsult_no_lm { get; set; }
        public string eyeconsult_no_lc { get; set; }
        public string eyeconsult_no_o { get; set; }
        public bool eyeconsult_yes_pharmacy_tick { get; set; }
        public bool eyeconsult_yes_health_i_tick { get; set; }
        public bool eyeconsult_eye_clinic_tick { get; set; }
        public bool eyeconsult_eye_hospital_tick { get; set; }
    }

    public class ChiefComplainInsert_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class ChiefComplainUpdate_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public int hospid { get; set; }
    }

    public class ChiefComplainSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public int userid { get; set; }
        public DateTime biltime { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class ChiefComplainDelete_dt
    {
        public string mrdno { get; set; }
    }
}