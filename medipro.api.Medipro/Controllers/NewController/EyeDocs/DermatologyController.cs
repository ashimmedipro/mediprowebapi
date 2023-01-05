using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class DermatologyController : ApiController
    {
        [HttpPost]
        [Route("api/DermatologyAll")]
        public IHttpActionResult PostAll(DermatologyAll_dt model)
        {
            try
            {

            
            DermatologyDetails_dt model1 = new DermatologyDetails_dt();
            InsertDerma(model, model1);

            return Ok();

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpPost]
        [Route("api/DermatologyAll/Update")]
        public IHttpActionResult UpdateAll(DermatologyAll_dt model)
        {
            try
            {

            
            DermatologyDetailsDelete_dt model_new = new DermatologyDetailsDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsDelete", model_new);
            DermatologyDetails_dt model1 = new DermatologyDetails_dt();
            InsertDerma(model, model1);
            return Ok();

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        private static void InsertDerma(DermatologyAll_dt model, DermatologyDetails_dt model1)
        {
            model1.mrdno = model.mrdno;
            model1.ddate = model.ddate;
            model1.hospid = model.hospid;
            model1.title = "mucosal_lesion_pain_tick";
            model1.result = "";
            model1.tick_mark = model.mucosal_lesion_pain_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lesion_tick";
            model1.result = "";
            model1.tick_mark = model.lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "cutaneous_tick";
            model1.result = "";
            model1.tick_mark = model.cutaneous_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "oral_tick";
            model1.result = "";
            model1.tick_mark = model.oral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "genital_tick";
            model1.result = "";
            model1.tick_mark = model.genital_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "nail_tick";
            model1.result = "";
            model1.tick_mark = model.nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "scalp_tick";
            model1.result = "";
            model1.tick_mark = model.scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "macule_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.macule_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "papules_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.papules_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "palques_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.palques_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "erosions_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.erosions_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ulcers_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.ulcers_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "vesicles_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.vesicles_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "bullae_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.bullae_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "scalp_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.scalp_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "face_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.face_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "trunk_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.trunk_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "upper_extremities_tick";
            model1.result = "";
            model1.tick_mark = model.upper_extremities_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lower_extremities_tick";
            model1.result = "";
            model1.tick_mark = model.lower_extremities_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "flexure_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.flexure_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "extensor_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.extensor_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "palm_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.palm_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "soles_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.soles_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "nails_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.nails_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "oral_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.oral_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "genital_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.genital_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lips_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.lips_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "past_ho_lesion_tick";
            model1.result = "";
            model1.tick_mark = model.past_ho_lesion_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "family_history_tick";
            model1.result = "";
            model1.tick_mark = model.family_history_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "dm_tick";
            model1.result = "";
            model1.tick_mark = model.dm_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "liver_tick";
            model1.result = "";
            model1.tick_mark = model.liver_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hypertension_tick";
            model1.result = "";
            model1.tick_mark = model.hypertension_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "anaemia_tick";
            model1.result = "";
            model1.tick_mark = model.anaemia_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "asthma_tick";
            model1.result = "";
            model1.tick_mark = model.asthma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pul_tb_tick";
            model1.result = "";
            model1.tick_mark = model.pul_tb_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ihd_tick";
            model1.result = "";
            model1.tick_mark = model.ihd_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "other_disease_tick";
            model1.result = "";
            model1.tick_mark = model.other_disease_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "macule_skin_tick";
            model1.result = "";
            model1.tick_mark = model.macule_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "papules_skin_tick";
            model1.result = "";
            model1.tick_mark = model.papules_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "plaques_skin_tick";
            model1.result = "";
            model1.tick_mark = model.plaques_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperkeratotic_skin_tick";
            model1.result = "";
            model1.tick_mark = model.hyperkeratotic_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "atrophic_skin_tick";
            model1.result = "";
            model1.tick_mark = model.atrophic_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "follicular_skin_tick";
            model1.result = "";
            model1.tick_mark = model.follicular_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "violaceous_skin_tick";
            model1.result = "";
            model1.tick_mark = model.violaceous_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "eryth_skin_tick";
            model1.result = "";
            model1.tick_mark = model.eryth_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperpigment_skin_tick";
            model1.result = "";
            model1.tick_mark = model.hyperpigment_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "annular_skin_tick";
            model1.result = "";
            model1.tick_mark = model.annular_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "bullous_skin_tick";
            model1.result = "";
            model1.tick_mark = model.bullous_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ulcerative_skin_tick";
            model1.result = "";
            model1.tick_mark = model.ulcerative_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "fissur_skin_tick";
            model1.result = "";
            model1.tick_mark = model.fissur_skin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "buccal_mucosa_unilateral_tick";
            model1.result = "";
            model1.tick_mark = model.buccal_mucosa_unilateral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "buccal_mucosa_bilateral_tick";
            model1.result = "";
            model1.tick_mark = model.buccal_mucosa_bilateral_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "tongue_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.tongue_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "palatal_arch_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.palatal_arch_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "mouth_floor_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.mouth_floor_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "labial_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.labial_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "gingiva_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.gingiva_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "white_plaque_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.white_plaque_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "violaceous_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.violaceous_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperpigmentation_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.hyperpigmentation_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "papules_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.papules_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "reticulate_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.reticulate_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ulcer_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.ulcer_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "atrophic_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.atrophic_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "erosive_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.erosive_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "bullous_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.bullous_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "mixed_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.mixed_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "erythema_genitalia_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.erythema_genitalia_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "voilaceous_genitalia_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.voilaceous_genitalia_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "papules_genitalia_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.papules_genitalia_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "plaques_genitalia_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.plaques_genitalia_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ulcers_genitalia_mucosa_tick";
            model1.result = "";
            model1.tick_mark = model.ulcers_genitalia_mucosa_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "fin_tick";
            model1.result = "";
            model1.tick_mark = model.fin_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "toe_tick";
            model1.result = "";
            model1.tick_mark = model.toe_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "b_tick";
            model1.result = "";
            model1.tick_mark = model.b_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "thining_nail_tick";
            model1.result = "";
            model1.tick_mark = model.thining_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "onycho_nail_tick";
            model1.result = "";
            model1.tick_mark = model.onycho_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "subungual_nail_tick";
            model1.result = "";
            model1.tick_mark = model.subungual_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pterygium_nail_tick";
            model1.result = "";
            model1.tick_mark = model.pterygium_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "totaloss_nail_tick";
            model1.result = "";
            model1.tick_mark = model.totaloss_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "long_melanon_nail_tick";
            model1.result = "";
            model1.tick_mark = model.long_melanon_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperpigment_nail_tick";
            model1.result = "";
            model1.tick_mark = model.hyperpigment_nail_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "diffuse_alop_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.diffuse_alop_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "male_pattern_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.male_pattern_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "scarring_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.scarring_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pupules_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.pupules_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "follicular_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.follicular_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "black_dots_scalp_tick";
            model1.result = "";
            model1.tick_mark = model.black_dots_scalp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "palms_soles_tick";
            model1.result = "";
            model1.tick_mark = model.palms_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "macule_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.macule_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "papules_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.papules_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "plaques_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.plaques_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperkerato_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.hyperkerato_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "atrophic_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.atrophic_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "erythem_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.erythem_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "hyperpigment_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.hyperpigment_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "bullous_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.bullous_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "ulcer_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.ulcer_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "fissur_palm_soles_tick";
            model1.result = "";
            model1.tick_mark = model.fissur_palm_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pruritus_tick";
            model1.result = "";
            model1.tick_mark = model.pruritus_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "senile_pruritus_tick";
            model1.result = "";
            model1.tick_mark = model.senile_pruritus_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "cuta_derma_pruritus_tick";
            model1.result = "";
            model1.tick_mark = model.cuta_derma_pruritus_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "systemic_disease_pruritus_tick";
            model1.result = "";
            model1.tick_mark = model.systemic_disease_pruritus_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "senile_xerosis_tick";
            model1.result = "";
            model1.tick_mark = model.senile_xerosis_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "senile_purpura_tick";
            model1.result = "";
            model1.tick_mark = model.senile_purpura_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "telang_tick";
            model1.result = "";
            model1.tick_mark = model.telang_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "comedones_tick";
            model1.result = "";
            model1.tick_mark = model.comedones_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "asta_exz_tick";
            model1.result = "";
            model1.tick_mark = model.asta_exz_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "atop_derma_tick";
            model1.result = "";
            model1.tick_mark = model.atop_derma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "sebor_derma_tick";
            model1.result = "";
            model1.tick_mark = model.sebor_derma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "stasis_derma_tick";
            model1.result = "";
            model1.tick_mark = model.stasis_derma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "contact_derma_tick";
            model1.result = "";
            model1.tick_mark = model.contact_derma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lichen_simplex_tick";
            model1.result = "";
            model1.tick_mark = model.lichen_simplex_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "nummular_eczema_tick";
            model1.result = "";
            model1.tick_mark = model.nummular_eczema_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "photoderma_tick";
            model1.result = "";
            model1.tick_mark = model.photoderma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "auto_derma_tick";
            model1.result = "";
            model1.tick_mark = model.auto_derma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "fissured_soles_tick";
            model1.result = "";
            model1.tick_mark = model.fissured_soles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pemp_vulg_tick";
            model1.result = "";
            model1.tick_mark = model.pemp_vulg_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pemphi_tick";
            model1.result = "";
            model1.tick_mark = model.pemphi_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "psoriasis_tick";
            model1.result = "";
            model1.tick_mark = model.psoriasis_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "vitiligo_tick";
            model1.result = "";
            model1.tick_mark = model.vitiligo_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "idio_guttate_tick";
            model1.result = "";
            model1.tick_mark = model.idio_guttate_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "cherry_tick";
            model1.result = "";
            model1.tick_mark = model.cherry_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "sebor_kerat_tick";
            model1.result = "";
            model1.tick_mark = model.sebor_kerat_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "idio_guttate_tick";
            model1.result = "";
            model1.tick_mark = model.idio_guttate_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "achro_tick";
            model1.result = "";
            model1.tick_mark = model.achro_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "xanthel_tick";
            model1.result = "";
            model1.tick_mark = model.xanthel_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lichen_planus_tick";
            model1.result = "";
            model1.tick_mark = model.lichen_planus_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "urticaria_tick";
            model1.result = "";
            model1.tick_mark = model.urticaria_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "miliaria_tick";
            model1.result = "";
            model1.tick_mark = model.miliaria_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "erythoderma_tick";
            model1.result = "";
            model1.tick_mark = model.erythoderma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "lenti_tick";
            model1.result = "";
            model1.tick_mark = model.lenti_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "callos_tick";
            model1.result = "";
            model1.tick_mark = model.callos_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "milia_tick";
            model1.result = "";
            model1.tick_mark = model.milia_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "acanthosis_tick";
            model1.result = "";
            model1.tick_mark = model.acanthosis_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "rhino_tick";
            model1.result = "";
            model1.tick_mark = model.rhino_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "freckles_tick";
            model1.result = "";
            model1.tick_mark = model.freckles_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "fungal_tick";
            model1.result = "";
            model1.tick_mark = model.fungal_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "tinea_fungal_tick";
            model1.result = "";
            model1.tick_mark = model.tinea_fungal_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "candida_fungal_tick";
            model1.result = "";
            model1.tick_mark = model.candida_fungal_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pity_fungal_tick";
            model1.result = "";
            model1.tick_mark = model.pity_fungal_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "deep_fungal_tick";
            model1.result = "";
            model1.tick_mark = model.deep_fungal_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "herpes_tick";
            model1.result = "";
            model1.tick_mark = model.herpes_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "post_herpes_tick";
            model1.result = "";
            model1.tick_mark = model.post_herpes_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "herpes_simplex_tick";
            model1.result = "";
            model1.tick_mark = model.herpes_simplex_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "pyoderma_tick";
            model1.result = "";
            model1.tick_mark = model.pyoderma_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "leprosy_tick";
            model1.result = "";
            model1.tick_mark = model.leprosy_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "scabies_tick";
            model1.result = "";
            model1.tick_mark = model.scabies_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "warts_tick";
            model1.result = "";
            model1.tick_mark = model.warts_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "bedsore_tick";
            model1.result = "";
            model1.tick_mark = model.bedsore_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "prime_syp_tick";
            model1.result = "";
            model1.tick_mark = model.prime_syp_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "tb_verru_tick";
            model1.result = "";
            model1.tick_mark = model.tb_verru_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            model1.title = "others_tick";
            model1.result = "";
            model1.tick_mark = model.others_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);

            if ((model.complaints is null ? "" : model.complaints).Length > 0)
            {
                model1.title = "complaints";
                model1.result = model.complaints;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.itching is null ? "" : model.itching).Length > 0)
            {
                model1.title = "itching";
                model1.result = model.itching;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.cutaneous is null ? "" : model.cutaneous).Length > 0)
            {
                model1.title = "cutaneous";
                model1.result = model.cutaneous;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.oral is null ? "" : model.oral).Length > 0)
            {
                model1.title = "oral";
                model1.result = model.oral;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.genital is null ? "" : model.genital).Length > 0)
            {
                model1.title = "genital";
                model1.result = model.genital;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.nail is null ? "" : model.nail).Length > 0)
            {
                model1.title = "nail";
                model1.result = model.nail;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.scalp is null ? "" : model.scalp).Length > 0)
            {
                model1.title = "scalp";
                model1.result = model.scalp;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.other_disease is null ? "" : model.other_disease).Length > 0)
            {
                model1.title = "other_disease";
                model1.result = model.other_disease;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.morphology is null ? "" : model.morphology).Length > 0)
            {
                model1.title = "morphology";
                model1.result = model.morphology;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.others is null ? "" : model.others).Length > 0)
            {
                model1.title = "others";
                model1.result = model.others;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.leucocytes_cnt is null ? "" : model.leucocytes_cnt).Length > 0)
            {
                model1.title = "leucocytes_cnt";
                model1.result = model.leucocytes_cnt;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.dlc_n is null ? "" : model.dlc_n).Length > 0)
            {
                model1.title = "dlc_n";
                model1.result = model.dlc_n;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.dlc_l is null ? "" : model.dlc_l).Length > 0)
            {
                model1.title = "dlc_l";
                model1.result = model.dlc_l;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.dlc_e is null ? "" : model.dlc_e).Length > 0)
            {
                model1.title = "dlc_e";
                model1.result = model.dlc_e;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.dlc_m is null ? "" : model.dlc_m).Length > 0)
            {
                model1.title = "dlc_m";
                model1.result = model.dlc_m;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.esr is null ? "" : model.esr).Length > 0)
            {
                model1.title = "esr";
                model1.result = model.esr;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.hemoglobin is null ? "" : model.hemoglobin).Length > 0)
            {
                model1.title = "hemoglobin";
                model1.result = model.hemoglobin;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.bloodsugar_f is null ? "" : model.bloodsugar_f).Length > 0)
            {
                model1.title = "bloodsugar_f";
                model1.result = model.bloodsugar_f;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.bloodsugar_p is null ? "" : model.bloodsugar_p).Length > 0)
            {
                model1.title = "bloodsugar_p";
                model1.result = model.bloodsugar_p;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.blood_urea is null ? "" : model.blood_urea).Length > 0)
            {
                model1.title = "blood_urea";
                model1.result = model.blood_urea;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.serum_proteins is null ? "" : model.serum_proteins).Length > 0)
            {
                model1.title = "serum_proteins";
                model1.result = model.serum_proteins;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.serum_albumin is null ? "" : model.serum_albumin).Length > 0)
            {
                model1.title = "serum_albumin";
                model1.result = model.serum_albumin;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.lft is null ? "" : model.lft).Length > 0)
            {
                model1.title = "lft";
                model1.result = model.lft;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.skin_biopsy is null ? "" : model.skin_biopsy).Length > 0)
            {
                model1.title = "skin_biopsy";
                model1.result = model.skin_biopsy;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }

            if ((model.treatment is null ? "" : model.treatment).Length > 0)
            {
                model1.title = "treatment";
                model1.result = model.treatment;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Dermatology_detailsInsert", model1);
            }
        }

        [HttpPost]
        [Route("api/Dermatology")]
        public IHttpActionResult Post(Dermatology_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DermatologyInsert", model);
            return Ok();

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpPost]
        [Route("api/Dermatology/Update")]
        public IHttpActionResult Update(Dermatology_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DermatologyUpdate", model);
            return Ok();

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/Dermatology")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DermatologySelect_dt>
                ("sp_DermatologySelect", new { mrdno = mrdno }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpPost]
        [Route("api/Dermatology/Delete")]
        public IHttpActionResult Delete(DermatologyDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DermatologyDelete ", model);
            return Ok();

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

        [HttpGet]
        [Route("api/DermatologyAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DermatologyDetailsSelect_dt>
                ("sp_Dermatology_detailsSelect", new { mrdno = mrdno }).ToList();
            DermatologyAll_dt model_new = new DermatologyAll_dt();
            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;
                model_new.ddate = x.ddate;
                if (x.title == "complaints") { model_new.complaints = x.result; }
                if (x.title == "itching") { model_new.itching = x.result; }
                if (x.title == "mucosal_lesion_pain_tick") { model_new.mucosal_lesion_pain_tick = x.tick_mark; }
                if (x.title == "lesion_tick") { model_new.lesion_tick = x.tick_mark; }
                if (x.title == "cutaneous_tick") { model_new.cutaneous_tick = x.tick_mark; }
                if (x.title == "cutaneous") { model_new.cutaneous = x.result; }
                if (x.title == "oral_tick") { model_new.oral_tick = x.tick_mark; }
                if (x.title == "oral") { model_new.oral = x.result; }
                if (x.title == "genital_tick") { model_new.genital_tick = x.tick_mark; }
                if (x.title == "genital") { model_new.genital = x.result; }
                if (x.title == "nail_tick") { model_new.nail_tick = x.tick_mark; }
                if (x.title == "nail") { model_new.nail = x.result; }
                if (x.title == "scalp_tick") { model_new.scalp_tick = x.tick_mark; }
                if (x.title == "scalp") { model_new.scalp = x.result; }
                if (x.title == "macule_lesion_tick") { model_new.macule_lesion_tick = x.tick_mark; }
                if (x.title == "papules_lesion_tick") { model_new.papules_lesion_tick = x.tick_mark; }
                if (x.title == "palques_lesion_tick") { model_new.palques_lesion_tick = x.tick_mark; }
                if (x.title == "erosions_lesion_tick") { model_new.erosions_lesion_tick = x.tick_mark; }
                if (x.title == "ulcers_lesion_tick") { model_new.ulcers_lesion_tick = x.tick_mark; }
                if (x.title == "vesicles_lesion_tick") { model_new.vesicles_lesion_tick = x.tick_mark; }
                if (x.title == "bullae_lesion_tick") { model_new.bullae_lesion_tick = x.tick_mark; }
                if (x.title == "scalp_lesion_tick") { model_new.scalp_lesion_tick = x.tick_mark; }
                if (x.title == "face_lesion_tick") { model_new.face_lesion_tick = x.tick_mark; }
                if (x.title == "trunk_lesion_tick") { model_new.trunk_lesion_tick = x.tick_mark; }
                if (x.title == "upper_extremities_tick") { model_new.upper_extremities_tick = x.tick_mark; }
                if (x.title == "lower_extremities_tick") { model_new.lower_extremities_tick = x.tick_mark; }
                if (x.title == "flexure_lesion_tick") { model_new.flexure_lesion_tick = x.tick_mark; }
                if (x.title == "extensor_lesion_tick") { model_new.extensor_lesion_tick = x.tick_mark; }
                if (x.title == "palm_lesion_tick") { model_new.palm_lesion_tick = x.tick_mark; }
                if (x.title == "soles_lesion_tick") { model_new.soles_lesion_tick = x.tick_mark; }
                if (x.title == "nails_lesion_tick") { model_new.nails_lesion_tick = x.tick_mark; }
                if (x.title == "oral_lesion_tick") { model_new.oral_lesion_tick = x.tick_mark; }
                if (x.title == "genital_lesion_tick") { model_new.genital_lesion_tick = x.tick_mark; }
                if (x.title == "lips_lesion_tick") { model_new.lips_lesion_tick = x.tick_mark; }
                if (x.title == "past_ho_lesion_tick") { model_new.past_ho_lesion_tick = x.tick_mark; }
                if (x.title == "family_history_tick") { model_new.family_history_tick = x.tick_mark; }
                if (x.title == "dm_tick") { model_new.dm_tick = x.tick_mark; }
                if (x.title == "liver_tick") { model_new.liver_tick = x.tick_mark; }
                if (x.title == "hypertension_tick") { model_new.hypertension_tick = x.tick_mark; }
                if (x.title == "anaemia_tick") { model_new.anaemia_tick = x.tick_mark; }
                if (x.title == "asthma_tick") { model_new.asthma_tick = x.tick_mark; }
                if (x.title == "pul_tb_tick") { model_new.pul_tb_tick = x.tick_mark; }
                if (x.title == "ihd_tick") { model_new.ihd_tick = x.tick_mark; }
                if (x.title == "other_disease_tick") { model_new.other_disease_tick = x.tick_mark; }
                if (x.title == "other_disease") { model_new.other_disease = x.result; }
                if (x.title == "morphology") { model_new.morphology = x.result; }
                if (x.title == "macule_skin_tick") { model_new.macule_skin_tick = x.tick_mark; }
                if (x.title == "papules_skin_tick") { model_new.papules_skin_tick = x.tick_mark; }
                if (x.title == "plaques_skin_tick") { model_new.plaques_skin_tick = x.tick_mark; }
                if (x.title == "hyperkeratotic_skin_tick") { model_new.hyperkeratotic_skin_tick = x.tick_mark; }
                if (x.title == "atrophic_skin_tick") { model_new.atrophic_skin_tick = x.tick_mark; }
                if (x.title == "follicular_skin_tick") { model_new.follicular_skin_tick = x.tick_mark; }
                if (x.title == "violaceous_skin_tick") { model_new.violaceous_skin_tick = x.tick_mark; }
                if (x.title == "eryth_skin_tick") { model_new.eryth_skin_tick = x.tick_mark; }
                if (x.title == "hyperpigment_skin_tick") { model_new.hyperpigment_skin_tick = x.tick_mark; }
                if (x.title == "annular_skin_tick") { model_new.annular_skin_tick = x.tick_mark; }
                if (x.title == "bullous_skin_tick") { model_new.bullous_skin_tick = x.tick_mark; }
                if (x.title == "ulcerative_skin_tick") { model_new.ulcerative_skin_tick = x.tick_mark; }
                if (x.title == "fissur_skin_tick") { model_new.fissur_skin_tick = x.tick_mark; }
                if (x.title == "buccal_mucosa_unilateral_tick") { model_new.buccal_mucosa_unilateral_tick = x.tick_mark; }
                if (x.title == "buccal_mucosa_bilateral_tick") { model_new.buccal_mucosa_bilateral_tick = x.tick_mark; }
                if (x.title == "tongue_mucosa_tick") { model_new.tongue_mucosa_tick = x.tick_mark; }
                if (x.title == "palatal_arch_mucosa_tick") { model_new.palatal_arch_mucosa_tick = x.tick_mark; }
                if (x.title == "mouth_floor_mucosa_tick") { model_new.mouth_floor_mucosa_tick = x.tick_mark; }
                if (x.title == "labial_mucosa_tick") { model_new.labial_mucosa_tick = x.tick_mark; }
                if (x.title == "gingiva_mucosa_tick") { model_new.gingiva_mucosa_tick = x.tick_mark; }
                if (x.title == "white_plaque_mucosa_tick") { model_new.white_plaque_mucosa_tick = x.tick_mark; }
                if (x.title == "violaceous_mucosa_tick") { model_new.violaceous_mucosa_tick = x.tick_mark; }
                if (x.title == "hyperpigmentation_mucosa_tick") { model_new.hyperpigmentation_mucosa_tick = x.tick_mark; }
                if (x.title == "papules_mucosa_tick") { model_new.papules_mucosa_tick = x.tick_mark; }
                if (x.title == "reticulate_mucosa_tick") { model_new.reticulate_mucosa_tick = x.tick_mark; }
                if (x.title == "ulcer_mucosa_tick") { model_new.ulcer_mucosa_tick = x.tick_mark; }
                if (x.title == "atrophic_mucosa_tick") { model_new.atrophic_mucosa_tick = x.tick_mark; }
                if (x.title == "erosive_mucosa_tick") { model_new.erosive_mucosa_tick = x.tick_mark; }
                if (x.title == "bullous_mucosa_tick") { model_new.bullous_mucosa_tick = x.tick_mark; }
                if (x.title == "mixed_mucosa_tick") { model_new.mixed_mucosa_tick = x.tick_mark; }
                if (x.title == "erythema_genitalia_mucosa_tick") { model_new.erythema_genitalia_mucosa_tick = x.tick_mark; }
                if (x.title == "voilaceous_genitalia_mucosa_tick") { model_new.voilaceous_genitalia_mucosa_tick = x.tick_mark; }
                if (x.title == "papules_genitalia_mucosa_tick") { model_new.papules_genitalia_mucosa_tick = x.tick_mark; }
                if (x.title == "plaques_genitalia_mucosa_tick") { model_new.plaques_genitalia_mucosa_tick = x.tick_mark; }
                if (x.title == "ulcers_genitalia_mucosa_tick") { model_new.ulcers_genitalia_mucosa_tick = x.tick_mark; }
                if (x.title == "fin_tick") { model_new.fin_tick = x.tick_mark; }
                if (x.title == "toe_tick") { model_new.toe_tick = x.tick_mark; }
                if (x.title == "b_tick") { model_new.b_tick = x.tick_mark; }
                if (x.title == "thining_nail_tick") { model_new.thining_nail_tick = x.tick_mark; }
                if (x.title == "onycho_nail_tick") { model_new.onycho_nail_tick = x.tick_mark; }
                if (x.title == "subungual_nail_tick") { model_new.subungual_nail_tick = x.tick_mark; }
                if (x.title == "pterygium_nail_tick") { model_new.pterygium_nail_tick = x.tick_mark; }
                if (x.title == "totaloss_nail_tick") { model_new.totaloss_nail_tick = x.tick_mark; }
                if (x.title == "long_melanon_nail_tick") { model_new.long_melanon_nail_tick = x.tick_mark; }
                if (x.title == "hyperpigment_nail_tick") { model_new.hyperpigment_nail_tick = x.tick_mark; }
                if (x.title == "diffuse_alop_scalp_tick") { model_new.diffuse_alop_scalp_tick = x.tick_mark; }
                if (x.title == "male_pattern_scalp_tick") { model_new.male_pattern_scalp_tick = x.tick_mark; }
                if (x.title == "scarring_scalp_tick") { model_new.scarring_scalp_tick = x.tick_mark; }
                if (x.title == "pupules_scalp_tick") { model_new.pupules_scalp_tick = x.tick_mark; }
                if (x.title == "follicular_scalp_tick") { model_new.follicular_scalp_tick = x.tick_mark; }
                if (x.title == "black_dots_scalp_tick") { model_new.black_dots_scalp_tick = x.tick_mark; }
                if (x.title == "palms_soles_tick") { model_new.palms_soles_tick = x.tick_mark; }
                if (x.title == "macule_palm_soles_tick") { model_new.macule_palm_soles_tick = x.tick_mark; }
                if (x.title == "papules_palm_soles_tick") { model_new.papules_palm_soles_tick = x.tick_mark; }
                if (x.title == "plaques_palm_soles_tick") { model_new.plaques_palm_soles_tick = x.tick_mark; }
                if (x.title == "hyperkerato_palm_soles_tick") { model_new.hyperkerato_palm_soles_tick = x.tick_mark; }
                if (x.title == "atrophic_palm_soles_tick") { model_new.atrophic_palm_soles_tick = x.tick_mark; }
                if (x.title == "erythem_palm_soles_tick") { model_new.erythem_palm_soles_tick = x.tick_mark; }
                if (x.title == "hyperpigment_palm_soles_tick") { model_new.hyperpigment_palm_soles_tick = x.tick_mark; }
                if (x.title == "bullous_palm_soles_tick") { model_new.bullous_palm_soles_tick = x.tick_mark; }
                if (x.title == "ulcer_palm_soles_tick") { model_new.ulcer_palm_soles_tick = x.tick_mark; }
                if (x.title == "fissur_palm_soles_tick") { model_new.fissur_palm_soles_tick = x.tick_mark; }
                if (x.title == "pruritus_tick") { model_new.pruritus_tick = x.tick_mark; }
                if (x.title == "senile_pruritus_tick") { model_new.senile_pruritus_tick = x.tick_mark; }
                if (x.title == "cuta_derma_pruritus_tick") { model_new.cuta_derma_pruritus_tick = x.tick_mark; }
                if (x.title == "systemic_disease_pruritus_tick") { model_new.systemic_disease_pruritus_tick = x.tick_mark; }
                if (x.title == "senile_xerosis_tick") { model_new.senile_xerosis_tick = x.tick_mark; }
                if (x.title == "senile_purpura_tick") { model_new.senile_purpura_tick = x.tick_mark; }
                if (x.title == "telang_tick") { model_new.telang_tick = x.tick_mark; }
                if (x.title == "comedones_tick") { model_new.comedones_tick = x.tick_mark; }
                if (x.title == "asta_exz_tick") { model_new.asta_exz_tick = x.tick_mark; }
                if (x.title == "atop_derma_tick") { model_new.atop_derma_tick = x.tick_mark; }
                if (x.title == "sebor_derma_tick") { model_new.sebor_derma_tick = x.tick_mark; }
                if (x.title == "stasis_derma_tick") { model_new.stasis_derma_tick = x.tick_mark; }
                if (x.title == "contact_derma_tick") { model_new.contact_derma_tick = x.tick_mark; }
                if (x.title == "lichen_simplex_tick") { model_new.lichen_simplex_tick = x.tick_mark; }
                if (x.title == "nummular_eczema_tick") { model_new.nummular_eczema_tick = x.tick_mark; }
                if (x.title == "photoderma_tick") { model_new.photoderma_tick = x.tick_mark; }
                if (x.title == "auto_derma_tick") { model_new.auto_derma_tick = x.tick_mark; }
                if (x.title == "fissured_soles_tick") { model_new.fissured_soles_tick = x.tick_mark; }
                if (x.title == "pemp_vulg_tick") { model_new.pemp_vulg_tick = x.tick_mark; }
                if (x.title == "pemphi_tick") { model_new.pemphi_tick = x.tick_mark; }
                if (x.title == "psoriasis_tick") { model_new.psoriasis_tick = x.tick_mark; }
                if (x.title == "vitiligo_tick") { model_new.vitiligo_tick = x.tick_mark; }
                if (x.title == "idio_guttate_tick") { model_new.idio_guttate_tick = x.tick_mark; }
                if (x.title == "cherry_tick") { model_new.cherry_tick = x.tick_mark; }
                if (x.title == "sebor_kerat_tick") { model_new.sebor_kerat_tick = x.tick_mark; }
                if (x.title == "naevi_tick") { model_new.naevi_tick = x.tick_mark; }
                if (x.title == "achro_tick") { model_new.achro_tick = x.tick_mark; }
                if (x.title == "xanthel_tick") { model_new.xanthel_tick = x.tick_mark; }
                if (x.title == "lichen_planus_tick") { model_new.lichen_planus_tick = x.tick_mark; }
                if (x.title == "urticaria_tick") { model_new.urticaria_tick = x.tick_mark; }
                if (x.title == "miliaria_tick") { model_new.miliaria_tick = x.tick_mark; }
                if (x.title == "erythoderma_tick") { model_new.erythoderma_tick = x.tick_mark; }
                if (x.title == "lenti_tick") { model_new.lenti_tick = x.tick_mark; }
                if (x.title == "callos_tick") { model_new.callos_tick = x.tick_mark; }
                if (x.title == "milia_tick") { model_new.milia_tick = x.tick_mark; }
                if (x.title == "acanthosis_tick") { model_new.acanthosis_tick = x.tick_mark; }
                if (x.title == "rhino_tick") { model_new.rhino_tick = x.tick_mark; }
                if (x.title == "freckles_tick") { model_new.freckles_tick = x.tick_mark; }
                if (x.title == "fungal_tick") { model_new.fungal_tick = x.tick_mark; }
                if (x.title == "tinea_fungal_tick") { model_new.tinea_fungal_tick = x.tick_mark; }
                if (x.title == "candida_fungal_tick") { model_new.candida_fungal_tick = x.tick_mark; }
                if (x.title == "pity_fungal_tick") { model_new.pity_fungal_tick = x.tick_mark; }
                if (x.title == "deep_fungal_tick") { model_new.deep_fungal_tick = x.tick_mark; }
                if (x.title == "herpes_tick") { model_new.herpes_tick = x.tick_mark; }
                if (x.title == "post_herpes_tick") { model_new.post_herpes_tick = x.tick_mark; }
                if (x.title == "herpes_simplex_tick") { model_new.herpes_simplex_tick = x.tick_mark; }
                if (x.title == "pyoderma_tick") { model_new.pyoderma_tick = x.tick_mark; }
                if (x.title == "leprosy_tick") { model_new.leprosy_tick = x.tick_mark; }
                if (x.title == "scabies_tick") { model_new.scabies_tick = x.tick_mark; }
                if (x.title == "warts_tick") { model_new.warts_tick = x.tick_mark; }
                if (x.title == "bedsore_tick") { model_new.bedsore_tick = x.tick_mark; }
                if (x.title == "prime_syp_tick") { model_new.prime_syp_tick = x.tick_mark; }
                if (x.title == "tb_verru_tick") { model_new.tb_verru_tick = x.tick_mark; }
                if (x.title == "others_tick") { model_new.others_tick = x.tick_mark; }
                if (x.title == "others") { model_new.others = x.result; }
                if (x.title == "leucocytes_cnt") { model_new.leucocytes_cnt = x.result; }
                if (x.title == "dlc_n") { model_new.dlc_n = x.result; }
                if (x.title == "dlc_l") { model_new.dlc_l = x.result; }
                if (x.title == "dlc_e") { model_new.dlc_e = x.result; }
                if (x.title == "dlc_m") { model_new.dlc_m = x.result; }
                if (x.title == "esr") { model_new.esr = x.result; }
                if (x.title == "hemoglobin") { model_new.hemoglobin = x.result; }
                if (x.title == "bloodsugar_f") { model_new.bloodsugar_f = x.result; }
                if (x.title == "bloodsugar_p") { model_new.bloodsugar_p = x.result; }
                if (x.title == "blood_urea") { model_new.blood_urea = x.result; }
                if (x.title == "serum_proteins") { model_new.serum_proteins = x.result; }
                if (x.title == "serum_albumin") { model_new.serum_albumin = x.result; }
                if (x.title == "lft") { model_new.lft = x.result; }
                if (x.title == "skin_biopsy") { model_new.skin_biopsy = x.result; }
                if (x.title == "treatment") { model_new.treatment = x.result; }
            }

            return Ok(model_new);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }

    }
}
