using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace medipro.api.Medipro.Models.NewModels.EyeDocs
{
    public class OcularInvestigationInsertAll_dt
    {
        public string mrdno { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
        public bool at_od_tick { get; set; }
        public bool at_os_tick { get; set; }
        public string at_od { get; set; }
        public string at_os { get; set; }
        public bool at_mh_od_tick { get; set; }
        public bool at_mh_os_tick { get; set; }
        public bool at_pc_od_tick { get; set; }
        public bool at_pc_os_tick { get; set; }
        public bool at_nf_od_tick { get; set; }
        public bool at_nf_os_tick { get; set; }
        public bool at_other_od_tick { get; set; }
        public bool at_other_os_tick { get; set; }
        public string at_other_od { get; set; }
        public string at_other_os { get; set; }
        public bool at_erpretation_od_tick { get; set; }
        public bool at_erpretation_os_tick { get; set; }
        public string at_erpretation_od { get; set; }
        public string at_erpretation_os { get; set; }
        public bool gonioscopy_od_tick { get; set; }
        public bool gonioscopy_os_tick { get; set; }
        public bool gonioscopy_od_open_tick { get; set; }
        public bool gonioscopy_od_close_tick { get; set; }
        public bool gonioscopy_od_occludable_tick { get; set; }
        public bool gonioscopy_od_nonoccludable_tick { get; set; }
        public bool gonioscopy_os_open_tick { get; set; }
        public bool gonioscopy_os_close_tick { get; set; }
        public bool gonioscopy_os_occludable_tick { get; set; }
        public bool gonioscopy_os_nonoccludable_tick { get; set; }
        public bool gonioscopy_mh_od_tick { get; set; }
        public bool gonioscopy_mh_os_tick { get; set; }
        public bool gonioscopy_pc_od_tick { get; set; }
        public bool gonioscopy_pc_os_tick { get; set; }
        public bool gonioscopy_nf_od_tick { get; set; }
        public bool gonioscopy_nf_os_tick { get; set; }
        public bool gonioscopy_other_od_tick { get; set; }
        public bool gonioscopy_other_os_tick { get; set; }
        public string gonioscopy_other_od { get; set; }
        public string gonioscopy_other_os { get; set; }
        public bool gonioscopy_erpretation_od_tick { get; set; }
        public bool gonioscopy_erpretation_os_tick { get; set; }
        public string gonioscopy_erpretation_od { get; set; }
        public string gonioscopy_erpretation_os { get; set; }
        public bool normal_od_tick { get; set; }
        public bool refractive_error_od_tick { get; set; }
        public bool presbyopia_od_tick { get; set; }
        public bool cataract_untreated_od_tick { get; set; }     
        public bool phthisis_od_tick { get; set; }
        public bool glaucoma_od_tick { get; set; }
        public bool diabetic_od_tick { get; set; }
        public bool other_posterior_od_tick { get; set; }
        public bool others_od_tick { get; set; }
        public string others_od { get; set; }
        public bool normal_os_tick { get; set; }
        public bool refractive_error_os_tick { get; set; }
        public bool presbyopia_os_tick { get; set; }
        public bool cataract_untreated_os_tick { get; set; }
        public bool phthisis_os_tick { get; set; }
        public bool glaucoma_os_tick { get; set; }
        public bool diabetic_os_tick { get; set; }
        public bool other_posterior_os_tick { get; set; }
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
        public bool followup_od_tick { get; set; }
        public bool followup_os_tick { get; set; }
        public bool fundus_od_tick { get; set; }
        public bool fundus_mh_od_tick { get; set; }
        public bool fundus_pc_od_tick { get; set; }
        public bool fundus_nf_od_tick { get; set; }
        public bool fundus_others_od_tick { get; set; }
        public string fundus_others_od { get; set; }
        public bool fundus_os_tick { get; set; }
        public bool fundus_mh_os_tick { get; set; }
        public bool fundus_pc_os_tick { get; set; }
        public bool fundus_nf_os_tick { get; set; }
        public bool fundus_others_os_tick { get; set; }
        public string fundus_others_os { get; set; }
        public bool funudus_erpretation_od_tick { get; set; }
        public string funudus_erpretation_od { get; set; }
        public bool funudus_erpretation_os_tick { get; set; }
        public string funudus_erpretation_os { get; set; }
        public bool disc_od_tick { get; set; }
        public bool disc_mh_od_tick { get; set; }
        public bool disc_pc_od_tick { get; set; }
        public bool disc_nf_od_tick { get; set; }
        public bool disc_others_od_tick { get; set; }
        public string disc_others_od { get; set; }
        public bool disc_os_tick { get; set; }
        public bool disc_mh_os_tick { get; set; }
        public bool disc_pc_os_tick { get; set; }
        public bool disc_nf_os_tick { get; set; }
        public bool disc_others_os_tick { get; set; }
        public string disc_others_os { get; set; }
        public bool disc_erpretation_od_tick { get; set; }
        public string disc_erpretation_od { get; set; }
        public bool disc_erpretation_os_tick { get; set; }
        public string disc_erpretation_os { get; set; }
        public bool post_od_tick { get; set; }
        public string post_sga_od { get; set; }
        public string post_it1_od { get; set; }
        public string post_it2_od { get; set; }
        public string post_ac_od { get; set; }
        public string post_acw_od { get; set; }
        public string post_lv_od { get; set; }
        public string post_ara_od { get; set; }
        public string post_aod500_od { get; set; }
        public string post_aod7500_od { get; set; }
        public string post_tisa_od { get; set; }
        public string post_tia_od { get; set; }
        public bool post_os_tick { get; set; }
        public string post_sga_os { get; set; }
        public string post_it1_os { get; set; }
        public string post_it2_os { get; set; }
        public string post_ac_os { get; set; }
        public string post_acw_os { get; set; }
        public string post_lv_os { get; set; }
        public string post_ara_os { get; set; }
        public string post_aod500_os { get; set; }
        public string post_aod7500_os { get; set; }
        public string post_tisa_os { get; set; }
        public string post_tia_os { get; set; }
        public bool post_mh_od_tick { get; set; }
        public bool post_pc_od_tick { get; set; }
        public bool post_nf_od_tick { get; set; }
        public bool post_others_od_tick { get; set; }
        public string post_others_od { get; set; }
        // public bool post_os_tick { get; set; }
        public bool post_mh_os_tick { get; set; }
        public bool post_pc_os_tick { get; set; }
        public bool post_nf_os_tick { get; set; }
        public bool post_others_os_tick { get; set; }
        public string post_others_os { get; set; }
        public bool post_erpretation_od_tick { get; set; }
        public string post_erpretation_od { get; set; }
        public bool post_erpretation_os_tick { get; set; }
        public string post_erpretation_os { get; set; }
        public bool fdp_od_tick { get; set; }
        public bool fdp_mh_od_tick { get; set; }
        public bool fdp_pc_od_tick { get; set; }
        public bool fdp_nf_od_tick { get; set; }
        public bool fdp_others_od_tick { get; set; }
        public string fdp_others_od { get; set; }
        public bool fdp_os_tick { get; set; }
        public bool fdp_mh_os_tick { get; set; }
        public bool fdp_pc_os_tick { get; set; }
        public bool fdp_nf_os_tick { get; set; }
        public bool fdp_others_os_tick { get; set; }
        public string fdp_others_os { get; set; }
        public bool fdp_erpretation_od_tick { get; set; }
        public string fdp_erpretation_od { get; set; }
        public bool fdp_erpretation_os_tick { get; set; }
        public string fdp_erpretation_os { get; set; }
        public bool anterior_segment_tick { get; set; }
        public bool ct_od_tick { get; set; }
        public bool ct_os_tick { get; set; }
        public string cct_od { get; set; }
        public string k1_od { get; set; }
        public string k2_od { get; set; }
        public string cct_os { get; set; }
        public string k1_os { get; set; }
        public string k2_os { get; set; }
        public bool ct_mh_od_tick { get; set; }
        public bool ct_mh_os_tick { get; set; }
        public bool ct_pc_od_tick { get; set; }
        public bool ct_pc_os_tick { get; set; }
        public bool ct_nf_od_tick { get; set; }
        public bool ct_nf_os_tick { get; set; }
        public bool ct_other_od_tick { get; set; }
        public bool ct_other_os_tick { get; set; }
        public string ct_other_od { get; set; }
        public string ct_other_os { get; set; }
        public bool ct_erpretation_od_tick { get; set; }
        public bool ct_erpretation_os_tick { get; set; }
        public string ct_erpretation_od { get; set; }
        public string ct_erpretation_os { get; set; }
        public bool ascan_od_tick { get; set; }
        public bool ascan_os_tick { get; set; }
        public string ascan_acp_od { get; set; }
        public string ascan_al_od { get; set; }
        public string ascan_iolpower_od { get; set; }
        public string ascan_lt_od { get; set; }
        public string ascan_acp_os { get; set; }
        public string ascan_al_os { get; set; }
        public string ascan_iolpower_os { get; set; }
        public string ascan_lt_os { get; set; }
        public bool ascan_mh_od_tick { get; set; }
        public bool ascan_mh_os_tick { get; set; }
        public bool ascan_pc_od_tick { get; set; }
        public bool ascan_pc_os_tick { get; set; }
        public bool ascan_nf_od_tick { get; set; }
        public bool ascan_nf_os_tick { get; set; }
        public bool ascan_other_od_tick { get; set; }
        public bool ascan_other_os_tick { get; set; }
        public string ascan_other_od { get; set; }
        public string ascan_other_os { get; set; }
        public bool ascan_erpretation_od_tick { get; set; }
        public bool ascan_erpretation_os_tick { get; set; }
        public string ascan_erpretation_od { get; set; }
        public string ascan_erpretation_os { get; set; }
        public bool anterioroct_od_tick { get; set; }
        public bool anterioroct_os_tick { get; set; }
        public string anteriorsga_od { get; set; }
        public string anteriorit1_od { get; set; }
        public string anteriorit2_od { get; set; }
        public string anterioracdepth_od { get; set; }
        public string anterioracwidth_od { get; set; }
        public string anteriorlv_od { get; set; }
        public string anteriorara_od { get; set; }
        public string anterioraod500_od { get; set; }
        public string anterioraod750_od { get; set; }
        public string anteriortisa_od { get; set; }
        public string anteriortia_od { get; set; }
        public string anteriorsga_os { get; set; }
        public string anteriorit1_os { get; set; }
        public string anteriorit2_os { get; set; }
        public string anterioracdepth_os { get; set; }
        public string anterioracwidth_os { get; set; }
        public string anteriorlv_os { get; set; }
        public string anteriorara_os { get; set; }
        public string anterioraod500_os { get; set; }
        public string anterioraod750_os { get; set; }
        public string anteriortisa_os { get; set; }
        public string anterior_tia_os { get; set; }
        public bool anterioroct_mh_od_tick { get; set; }
        public bool anterioroct_mh_os_tick { get; set; }
        public bool anterioroct_pc_od_tick { get; set; }
        public bool anterioroct_pc_os_tick { get; set; }
        public bool anterioroct_nf_od_tick { get; set; }
        public bool anterioroct_nf_os_tick { get; set; }
        public bool anterioroct_other_od_tick { get; set; }
        public bool anterioroct_other_os_tick { get; set; }
        public string anterioroct_other_od { get; set; }
        public string anterioroct_other_os { get; set; }
        public bool anterioroct_erpretation_od_tick { get; set; }
        public bool anterioroct_erpretation_os_tick { get; set; }
        public string anterioroct_erpretation_od { get; set; }
        public string anterioroct_erpretation_os { get; set; }
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
        public bool visual_field_od_tick { get; set; }
        public bool visual_field_interpret_od_tick { get; set; }
        public string visual_field_interpret_od { get; set; }
        public bool visual_field_os_tick { get; set; }
        public bool visual_field_interpret_os_tick { get; set; }
        public string visual_field_interpret_os { get; set; }
        public bool treatment_od_tick { get; set; }
        public bool treatment_os_tick { get; set; }
        public bool schirmer_od_tick { get; set; }
        public string schirmer_od { get; set; }
        public bool schirmer_os_tick { get; set; }
        public string schirmer_os { get; set; }
        public string tx_plan { get; set; }
        public bool conjunc_od_tick { get; set; }
        public string conjunc_od { get; set; }
        public bool conjunc_os_tick { get; set; }
        public string conjunc_os { get; set; }
        public string glaucoma_od { get; set; }
        public string glaucoma_os { get; set; }
        public string catar_od { get; set; }
        public string catar_os { get; set; }
        public string diabe_ret_od { get; set; }
        public string DIabete_ret_os { get; set; }
        public bool hpt_od_tick { get; set; }
        public string hpt_od { get; set; }
        public bool hpt_os_tick { get; set; }
        public string hpt_os { get; set; }
        public string poster_od { get; set; }
        public string poster_os { get; set; }
        public string uveal_od { get; set; }
        public string uveal_os { get; set; }
        public string pthisis_od { get; set; }
        public string pthsis_os { get; set; }
        public bool anterior_od_tick { get; set; }
        public bool anterior_os_tick { get; set; }
        public string anterior_od_text { get; set; }
        public string anterior_os_text { get; set; }
        public string referror_od { get; set; }
        public string referror_os { get; set; }
        public bool uveal_od_tick { get; set; }
        public bool uveal_os_tick { get; set; }
        public bool anteriorint_od_tick { get; set; }
        public bool anteriorint_os_tick { get; set; }
    }

    public class OcularInvestigationInsert_dt
    {
        public string mrdno { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class OcularInvestigationUpdate_dt
    {
        public string mrdno { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class OcularInvestigationSelect_dt
    {
        public int sn { get; set; }
        public string mrdno { get; set; }
        public int userid { get; set; }
        public DateTime ddate { get; set; }
        public int hospid { get; set; }
    }

    public class OcularInvestigationDelete_dt
    {
        public string mrdno { get; set; }
    }
}