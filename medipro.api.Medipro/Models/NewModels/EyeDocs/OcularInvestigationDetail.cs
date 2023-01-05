using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class OcularInvestigationDetailInsert_dt
    {
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class OcularInvestigationDetailUpdate_dt
    {
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class OcularInvestigationDetailSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public DateTime ddate { get; set; }
        public string pname { get; set; }
        public string address { get; set; }
        public string contact { get; set; }
        public string martialstatus { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
    }

    public class OcularInvestigationDetailDelete_dt
    {
        public string mrdno { get; set; }
    }

    public class OcularInvestigationSummary_dt
    {
        //public string title { get; set; }
        public bool normal_od_tick { get; set; }
        public bool refractive_error_od_tick { get; set; }
        public bool presbyopia_od_tick { get; set; }
        public bool cataract_untreated_od_tick { get; set; }
        public bool aphakia_od_tick { get; set; }
        public bool cataract_surg_complications_od_tick { get; set; }
        public bool tco_od_tick { get; set; }
        public bool phthisis_od_tick { get; set; }
        public bool onchcercia_od_tick { get; set; }
        public bool glaucoma_od_tick { get; set; }
        public bool diabetic_od_tick { get; set; }
        public bool armd_od_tick { get; set; }
        public bool other_posterior_od_tick { get; set; }
        public string cns_od { get; set; }
        public bool others_od_tick { get; set; }
        public string others_od { get; set; }
        public bool normal_os_tick { get; set; }
        public bool refractive_error_os_tick { get; set; }
        public bool presbyopia_os_tick { get; set; }
        public bool cataract_untreated_os_tick { get; set; }
        public bool aphakia_os_tick { get; set; }
        public bool cataract_surg_complications_os_tick { get; set; }
        public bool tco_os_tick { get; set; }
        public bool phthisis_os_tick { get; set; }
        public bool onchcercia_os_tick { get; set; }
        public bool glaucoma_os_tick { get; set; }
        public bool diabetic_os_tick { get; set; }
        public bool armd_os_tick { get; set; }
        public bool other_posterior_os_tick { get; set; }
        public string cns_os { get; set; }
        public bool others_os_tick { get; set; }
        public string others_os { get; set; }
        public bool medical_treatment_od_tick { get; set; }
        public string medical_treatment_od { get; set; }
        public bool surgrical_treatment_od_tick { get; set; }
        public string surgrical_treatment_od { get; set; }
        public bool medical_treatment_os_tick { get; set; }
        public string medical_treatment_os { get; set; }
        public bool surgrical_treatment_os_tick { get; set; }
        public string surgrical_treatment_os { get; set; }
        public string followup_od { get; set; }
        public string followup_os { get; set; }
        public bool laser_treatment_od_tick { get; set; }
        public string laser_treatment_od { get; set; }
        public bool laser_treatment_os_tick { get; set; }
        public string laser_treatment_os { get; set; }
        public bool subspeciality_referal_od_tick { get; set; }
        public bool subspeciality_referal_os_tick { get; set; }
        public bool subspec_corena_od_tick { get; set; }
        public bool subspeciality_retina_od_tick { get; set; }
        public bool subspeciality_glaucoma_od_tick { get; set; }
        public bool subspeciality_opal_od_tick { get; set; }
        public bool subspeciality_referr_od_tick { get; set; }
        public bool subspeciality_squint_od_tick { get; set; }
        public bool subspeciality_uvea_od_tick { get; set; }
        public bool subspeciality_neuropthalmo_od_tick { get; set; }
        public bool subspeciality_none_od_tick { get; set; }
        public bool subspec_corena_os_tick { get; set; }
        public bool subspeciality_retina_os_tick { get; set; }
        public bool subspeciality_glaucoma_os_tick { get; set; }
        public bool subspeciality_opal_os_tick { get; set; }
        public bool subspeciality_referr_os_tick { get; set; }
        public bool subspeciality_squint_os_tick { get; set; }
        public bool subspeciality_uvea_os_tick { get; set; }
        public bool subspeciality_neuropthalmo_os_tick { get; set; }
        public bool subspeciality_none_os_tick { get; set; }
        public bool followup_od_tick { get; set; }
        public bool followup_os_tick { get; set; }
    }

    public class TempOcularInvestigationDetailsInsert_dt
    {

        public string title { get; set; }
        public string result { get; set; }
        public bool tick_mark { get; set; }
        public int userid { get; set; }
    }

    public class OcularInvestigationDetailsBulkInsert_dt
    {
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public string mrdno { get; set; }
        public int userid { get; set; }
    }

    public class TempOcularInvestigationDetailsDelete_dt
    {
        public string userid { get; set; }
    }
}