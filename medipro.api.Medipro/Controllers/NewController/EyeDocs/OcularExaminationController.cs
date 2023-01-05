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
    public class OcularExaminationController : ApiController
    {
        [HttpPost]
        [Route("api/OcularExaminationAll")]
        public IHttpActionResult Post(OcularExaminationAll_dt model)
        {
            try
            {

            
            OcularExaminationDetailInsert_dt model1 = new OcularExaminationDetailInsert_dt();
            InsertOCularExamination(model, model1);
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
        [Route("api/OcularExaminationAll/Update")]
        public IHttpActionResult UpdateAll(OcularExaminationAll_dt model)
        {
            try
            {

            
            OcularExaminationDetailDelete_dt model_new = new OcularExaminationDetailDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailDelete", model_new);
            OcularExaminationDetailInsert_dt model1 = new OcularExaminationDetailInsert_dt();
            InsertOCularExamination(model, model1);
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

        private static void InsertOCularExamination(OcularExaminationAll_dt model, OcularExaminationDetailInsert_dt model1)
        {
            model1.mrdno = model.mrdno;
            model1.hospid = model.hospid;
            model1.ddate = model.ddate;

            model1.title = "proptosis_od_tick";
            model1.result = "";
            model1.tick_mark = model.proptosis_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "proptosis_os_tick";
            model1.result = "";
            model1.tick_mark = model.proptosis_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "eom_od_tick";
            model1.result = "";
            model1.tick_mark = model.eom_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "eom_os_tick";
            model1.result = "";
            model1.tick_mark = model.eom_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_dermato_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_dermato_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_xanthelasma_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_xanthelasma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_pbt_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_pbt_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_ptosis_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_ptosis_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_entropion_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_entropion_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_ectropion_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_ectropion_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_chalazion_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_chalazion_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_stye_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_stye_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_abscess_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_abscess_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_laceration_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_laceration_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.lid_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_dermato_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_dermato_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_xanthelasma_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_xanthelasma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_pbt_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_pbt_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_ptosis_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_ptosis_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_entropion_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_entropion_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_ectropion_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_ectropion_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_chalazion_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_chalazion_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_stye_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_stye_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_abscess_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_abscess_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_laceration_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_laceration_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lid_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.lid_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_congestion_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_congestion_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_nevus_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_nevus_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_bleb_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_bleb_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_laceration_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_laceration_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_deposteroid_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_deposteroid_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_ptery_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_ptery_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_ping_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_ping_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_congestion_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_congestion_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_nevus_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_nevus_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_bleb_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_bleb_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_laceration_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_laceration_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_deposteroid_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_deposteroid_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_ptery_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_ptery_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_ping_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_ping_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "conjunct_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunct_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_staphy_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_staphy_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_ict_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_ict_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_thinning_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_thinning_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_melting_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_melting_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_lacerat_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_lacerat_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_staphy_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_staphy_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_ict_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_ict_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_thinning_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_thinning_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_melting_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_melting_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_lacerat_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_lacerat_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "sclera_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.sclera_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_staphy_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_staphy_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_ict_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_ict_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_thinning_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_thinning_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_melting_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_melting_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_lacerat_od_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_lacerat_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_staphy_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_staphy_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_ict_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_ict_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_thinning_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_thinning_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_melting_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_melting_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_lacerat_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_lacerat_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cornea_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.cornea_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "anterchamb_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterchamb_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_hetero_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_hetero_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_atrophy_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_atrophy_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_nevus_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_nevus_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_sid_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_sid_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_anirid_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_anirid_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.iris_hetero_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_hetero_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_hetero_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_atrophy_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_atrophy_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_nevus_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_nevus_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_sid_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_sid_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_anirid_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_anirid_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "iris_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.iris_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_corecto_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_corecto_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_polyco_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_polyco_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_ppm_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_ppm_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_ppi_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_ppi_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_dsp_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_dsp_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_corecto_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_corecto_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_polyco_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_polyco_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_ppm_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_ppm_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_ppi_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_ppi_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_dsp_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_dsp_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_rapd_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_rapd_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_slugreact_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_slugreact_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_hippus_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_hippus_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_aap_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_aap_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_apd_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_apd_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_others­_od_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_others­_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_rapd_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_rapd_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_slugreact_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_slugreact_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_hippus_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_hippus_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_aap_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_aap_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_apd_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_apd_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pupil_rti_others­_os_tick";
            model1.result = "";
            model1.tick_mark = model.pupil_rti_others­_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lens_phakic_od_tick";
            model1.result = "";
            model1.tick_mark = model.lens_phakic_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lens_pseuphakic_od_tick";
            model1.result = "";
            model1.tick_mark = model.lens_pseuphakic_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);


            model1.title = "lens_aphakic_od_tick";
            model1.result = "";
            model1.tick_mark = model.lens_aphakic_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lens_phakic_os_tick";
            model1.result = "";
            model1.tick_mark = model.lens_phakic_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "lens_pseuphakic_os_tick";
            model1.result = "";
            model1.tick_mark = model.lens_pseuphakic_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);


            model1.title = "lens_aphakic_os_tick";
            model1.result = "";
            model1.tick_mark = model.lens_aphakic_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_od_tick";
            model1.result = "";
            model1.tick_mark = model.caps_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_pseudo_od_tick";
            model1.result = "";
            model1.tick_mark = model.caps_pseudo_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_pco_od_tick";
            model1.result = "";
            model1.tick_mark = model.caps_pco_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.caps_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_os_tick";
            model1.result = "";
            model1.tick_mark = model.caps_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_pseudo_os_tick";
            model1.result = "";
            model1.tick_mark = model.caps_pseudo_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_pco_os_tick";
            model1.result = "";
            model1.tick_mark = model.caps_pco_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "caps_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.caps_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_phacod_od_tick";
            model1.result = "";
            model1.tick_mark = model.pos_phacod_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_sublux_od_tick";
            model1.result = "";
            model1.tick_mark = model.pos_sublux_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_disloc_od_tick";
            model1.result = "";
            model1.tick_mark = model.pos_disloc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_none_od_tick";
            model1.result = "";
            model1.tick_mark = model.pos_none_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_phacod_os_tick";
            model1.result = "";
            model1.tick_mark = model.pos_phacod_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_sublux_os_tick";
            model1.result = "";
            model1.tick_mark = model.pos_sublux_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_disloc_os_tick";
            model1.result = "";
            model1.tick_mark = model.pos_disloc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "pos_none_os_tick";
            model1.result = "";
            model1.tick_mark = model.pos_none_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cataract_tick";
            model1.result = "";
            model1.tick_mark = model.cataract_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n0_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n0_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n1_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n1_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n2_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n2_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n3_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n3_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n4_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n4_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_notgrade_od_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_notgrade_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n0_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n0_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n1_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n1_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n2_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n2_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n3_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n3_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_n4_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_n4_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "nucopal_notgrade_os_tick";
            model1.result = "";
            model1.tick_mark = model.nucopal_notgrade_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c0_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c0_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_ctr_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_ctr_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c1_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c1_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c2_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c2_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c3_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c3_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c4_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c4_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c5_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c5_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_notgrade_od_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_notgrade_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c0_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c0_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_ctr_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_ctr_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c1_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c1_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c2_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c2_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c3_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c3_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c4_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c4_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_c5_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_c5_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cortical_notgrade_os_tick";
            model1.result = "";
            model1.tick_mark = model.cortical_notgrade_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p0_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p0_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p1_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p1_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p2_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p2_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p3_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p3_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p4_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p4_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_notgrade_od_tick";
            model1.result = "";
            model1.tick_mark = model.psc_notgrade_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p0_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p0_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p1_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p1_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p2_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p2_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p3_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p3_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_p4_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_p4_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "psc_notgrade_os_tick";
            model1.result = "";
            model1.tick_mark = model.psc_notgrade_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "maturecat_od_tick";
            model1.result = "";
            model1.tick_mark = model.maturecat_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "maturecat_os_tick";
            model1.result = "";
            model1.tick_mark = model.maturecat_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "compact_od_tick";
            model1.result = "";
            model1.tick_mark = model.compact_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "compact_os_tick";
            model1.result = "";
            model1.tick_mark = model.compact_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_od_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_pvd_od_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_pvd_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_vh_od_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_vh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_oparities_od_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_oparities_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_os_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_pvd_os_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_pvd_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_vh_os_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_vh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_oparities_os_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_oparities_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vitreous_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.vitreous_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "retina_od_tick";
            model1.result = "";
            model1.tick_mark = model.retina_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "retina_os_tick";
            model1.result = "";
            model1.tick_mark = model.retina_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "disc_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "disc_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cdr_od_tick";
            model1.result = "";
            model1.tick_mark = model.cdr_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "cdr_os_tick";
            model1.result = "";
            model1.tick_mark = model.cdr_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_erm_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_erm_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_hole_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_hole_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_hemorage_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_hemorage_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_edema_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_edema_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.macula_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_erm_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_erm_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_hole_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_hole_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_hemorage_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_hemorage_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_edema_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_edema_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "macula_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.macula_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vessels_od_tick";
            model1.result = "";
            model1.tick_mark = model.vessels_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "vessels_os_tick";
            model1.result = "";
            model1.tick_mark = model.vessels_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "periphery_od_tick";
            model1.result = "";
            model1.tick_mark = model.periphery_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "periphery_os_tick";
            model1.result = "";
            model1.tick_mark = model.periphery_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "tear_film_od_tick";
            model1.result = "";
            model1.tick_mark = model.tear_film_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "tear_flim_os_tick";
            model1.result = "";
            model1.tick_mark = model.tear_flim_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "tbvt_od_tick";
            model1.result = "";
            model1.tick_mark = model.tbvt_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

            model1.title = "tbvt_os_tick";
            model1.result = "";
            model1.tick_mark = model.tbvt_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);

           

            if ((model.eom_od is null ? "" : model.eom_od).Length > 0)
            {
                model1.title = "eom_od";
                model1.result = model.eom_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.eom_os is null ? "" : model.eom_os).Length > 0)
            {
                model1.title = "eom_os";
                model1.result = model.eom_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.lid_others_od is null ? "" : model.lid_others_od).Length > 0)
            {
                model1.title = "lid_others_od";
                model1.result = model.lid_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.lid_others_os is null ? "" : model.lid_others_os).Length > 0)
            {
                model1.title = "lid_others_od";
                model1.result = model.lid_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.conjunct_others_od is null ? "" : model.conjunct_others_od).Length > 0)
            {
                model1.title = "conjunct_others_od";
                model1.result = model.conjunct_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.conjunct_others_os is null ? "" : model.conjunct_others_os).Length > 0)
            {
                model1.title = "conjunct_others_os";
                model1.result = model.conjunct_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.sclera_others_od is null ? "" : model.sclera_others_od).Length > 0)
            {
                model1.title = "sclera_others_od";
                model1.result = model.sclera_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.sclera_others_os is null ? "" : model.sclera_others_os).Length > 0)
            {
                model1.title = "sclera_others_os";
                model1.result = model.sclera_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.cornea_others_od is null ? "" : model.cornea_others_od).Length > 0)
            {
                model1.title = "cornea_others_od";
                model1.result = model.cornea_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.cornea_others_os is null ? "" : model.cornea_others_os).Length > 0)
            {
                model1.title = "cornea_others_os";
                model1.result = model.cornea_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }
            if ((model.anterchamb_others_od is null ? "" : model.anterchamb_others_od).Length > 0)
            {
                model1.title = "anterchamb_others_od";
                model1.result = model.anterchamb_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.anterchamb_others_os is null ? "" : model.anterchamb_others_os).Length > 0)
            {
                model1.title = "anterchamb_others_os";
                model1.result = model.anterchamb_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.iris_others_od is null ? "" : model.iris_others_od).Length > 0)
            {
                model1.title = "iris_others_od";
                model1.result = model.iris_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.iris_others_os is null ? "" : model.iris_others_os).Length > 0)
            {
                model1.title = "iris_others_os";
                model1.result = model.iris_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.pupil_others_od is null ? "" : model.pupil_others_od).Length > 0)
            {
                model1.title = "pupil_others_od";
                model1.result = model.pupil_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.pupil_others_os is null ? "" : model.pupil_others_os).Length > 0)
            {
                model1.title = "pupil_others_os";
                model1.result = model.pupil_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.pupil_rti_others_od is null ? "" : model.pupil_rti_others_od).Length > 0)
            {
                model1.title = "pupil_rti_others_od";
                model1.result = model.pupil_rti_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.pupil_rti_others_os is null ? "" : model.pupil_rti_others_os).Length > 0)
            {
                model1.title = "pupil_rti_others_os";
                model1.result = model.pupil_rti_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.caps_others_od is null ? "" : model.caps_others_od).Length > 0)
            {
                model1.title = "caps_others_od";
                model1.result = model.caps_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.caps_others_os is null ? "" : model.caps_others_os).Length > 0)
            {
                model1.title = "caps_others_os";
                model1.result = model.caps_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vitreous_other_od is null ? "" : model.vitreous_other_od).Length > 0)
            {
                model1.title = "vitreous_other_od";
                model1.result = model.vitreous_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vitreous_other_os is null ? "" : model.vitreous_other_os).Length > 0)
            {
                model1.title = "vitreous_other_os";
                model1.result = model.vitreous_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vitreous_remarks_od is null ? "" : model.vitreous_remarks_od).Length > 0)
            {
                model1.title = "vitreous_remarks_od";
                model1.result = model.vitreous_remarks_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vitreous_remarks_os is null ? "" : model.vitreous_remarks_os).Length > 0)
            {
                model1.title = "vitreous_remarks_os";
                model1.result = model.vitreous_remarks_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.retina_od is null ? "" : model.retina_od).Length > 0)
            {
                model1.title = "retina_od";
                model1.result = model.retina_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.retina_os is null ? "" : model.retina_os).Length > 0)
            {
                model1.title = "retina_os";
                model1.result = model.retina_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.disc_od is null ? "" : model.disc_od).Length > 0)
            {
                model1.title = "disc_od";
                model1.result = model.disc_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.disc_os is null ? "" : model.disc_os).Length > 0)
            {
                model1.title = "disc_os";
                model1.result = model.disc_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.cdr_od is null ? "" : model.cdr_od).Length > 0)
            {
                model1.title = "cdr_od";
                model1.result = model.cdr_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.cdr_os is null ? "" : model.cdr_os).Length > 0)
            {
                model1.title = "cdr_os";
                model1.result = model.cdr_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.macula_other_od is null ? "" : model.macula_other_od).Length > 0)
            {
                model1.title = "macula_other_od";
                model1.result = model.macula_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.macula_other_os is null ? "" : model.macula_other_os).Length > 0)
            {
                model1.title = "macula_other_os";
                model1.result = model.macula_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vessels_od is null ? "" : model.vessels_od).Length > 0)
            {
                model1.title = "vessels_od";
                model1.result = model.vessels_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.vessels_os is null ? "" : model.vessels_os).Length > 0)
            {
                model1.title = "vessels_os";
                model1.result = model.vessels_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.periphery_od is null ? "" : model.periphery_od).Length > 0)
            {
                model1.title = "periphery_od";
                model1.result = model.periphery_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.periphery_os is null ? "" : model.periphery_os).Length > 0)
            {
                model1.title = "periphery_os";
                model1.result = model.periphery_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.tear_flim_od is null ? "" : model.tear_flim_od).Length > 0)
            {
                model1.title = "tear_flim_od";
                model1.result = model.tear_flim_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.tear_flim_os is null ? "" : model.tear_flim_os).Length > 0)
            {
                model1.title = "tear_flim_os";
                model1.result = model.tear_flim_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.tbvt_od is null ? "" : model.tbvt_od).Length > 0)
            {
                model1.title = "tbvt_od";
                model1.result = model.tbvt_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

            if ((model.tbvt_os is null ? "" : model.tbvt_os).Length > 0)
            {
                model1.title = "tbvt_os";
                model1.result = model.tbvt_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Ocular_Examination_detailsInsert", model1);
            }

        }

        [HttpPost]
        [Route("api/OcularExamination")]
        public IHttpActionResult Post(OcularExaminationInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_ExaminationInsert", model);
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
        [Route("api/OcularExamination/Update")]
        public IHttpActionResult Update(OcularExaminationUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_ExaminationUpdate", model);
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
        [Route("api/OcularExamination")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularExaminationSelect_dt>
                ("sp_Ocular_ExaminationSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/OcularExamination/delete")]
        public IHttpActionResult Delete(OcularExaminationDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Ocular_ExaminationDelete", model);
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
        [Route("api/OcularExaminationAll")]
        public IHttpActionResult SelectAll(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularExaminationDetailSelect_dt>
            ("Ocular_Examination_detailsSelect", new { mrdno = mrdno }).ToList();
            OcularExaminationAll_dt model_new = new OcularExaminationAll_dt();
            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;
                model_new.ddate = x.ddate;

                if (x.title == "proptosis_od_tick")
                {
                    model_new.proptosis_od_tick = x.tick_mark;
                }

                if (x.title == "proptosis_os_tick")
                {
                    model_new.proptosis_os_tick = x.tick_mark;
                }

                if (x.title == "eom_od_tick")
                {
                    model_new.eom_od_tick = x.tick_mark;
                }

                if (x.title == "eom_od")
                {
                    model_new.eom_od = x.result;
                }

                if (x.title == "eom_os_tick")
                {
                    model_new.eom_os_tick = x.tick_mark;
                }

                if (x.title == "eom_os")
                {
                    model_new.eom_os = x.result;
                }

                if (x.title == "lid_od_tick")
                {
                    model_new.lid_od_tick = x.tick_mark;
                }

                if (x.title == "lid_dermato_od_tick")
                {
                    model_new.lid_dermato_od_tick = x.tick_mark;
                }

                if (x.title == "lid_xanthelasma_od_tick")
                {
                    model_new.lid_xanthelasma_od_tick = x.tick_mark;
                }

                if (x.title == "lid_pbt_od_tick")
                {
                    model_new.lid_pbt_od_tick = x.tick_mark;
                }

                if (x.title == "lid_ptosis_od_tick")
                {
                    model_new.lid_ptosis_od_tick = x.tick_mark;
                }

                if (x.title == "lid_entropion_od_tick")
                {
                    model_new.lid_entropion_od_tick = x.tick_mark;
                }

                if (x.title == "lid_ectropion_od_tick")
                {
                    model_new.lid_ectropion_od_tick = x.tick_mark;
                }

                if (x.title == "lid_chalazion_od_tick")
                {
                    model_new.lid_chalazion_od_tick = x.tick_mark;
                }

                if (x.title == "lid_stye_od_tick")
                {
                    model_new.lid_stye_od_tick = x.tick_mark;
                }

                if (x.title == "lid_abscess_od_tick")
                {
                    model_new.lid_abscess_od_tick = x.tick_mark;
                }

                if (x.title == "lid_laceration_od_tick")
                {
                    model_new.lid_laceration_od_tick = x.tick_mark;
                }

                if (x.title == "lid_others_od_tick")
                {
                    model_new.lid_others_od_tick = x.tick_mark;
                }

                if (x.title == "lid_others_od")
                {
                    model_new.lid_others_od = x.result;
                }

                if (x.title == "lid_os_tick")
                {
                    model_new.lid_os_tick = x.tick_mark;
                }

                if (x.title == "lid_dermato_os_tick")
                {
                    model_new.lid_dermato_os_tick = x.tick_mark;
                }

                if (x.title == "lid_xanthelasma_os_tick")
                {
                    model_new.lid_xanthelasma_os_tick = x.tick_mark;
                }

                if (x.title == "lid_pbt_os_tick")
                {
                    model_new.lid_pbt_os_tick = x.tick_mark;
                }

                if (x.title == "lid_ptosis_os_tick")
                {
                    model_new.lid_ptosis_os_tick = x.tick_mark;
                }

                if (x.title == "lid_entropion_os_tick")
                {
                    model_new.lid_entropion_os_tick = x.tick_mark;
                }

                if (x.title == "lid_ectropion_os_tick")
                {
                    model_new.lid_ectropion_os_tick = x.tick_mark;
                }

                if (x.title == "lid_chalazion_os_tick")
                {
                    model_new.lid_chalazion_os_tick = x.tick_mark;
                }

                if (x.title == "lid_stye_os_tick")
                {
                    model_new.lid_stye_os_tick = x.tick_mark;
                }

                if (x.title == "lid_abscess_os_tick")
                {
                    model_new.lid_abscess_os_tick = x.tick_mark;
                }

                if (x.title == "lid_laceration_os_tick")
                {
                    model_new.lid_laceration_os_tick = x.tick_mark;
                }

                if (x.title == "lid_others_os_tick")
                {
                    model_new.lid_others_os_tick = x.tick_mark;
                }

                if (x.title == "lid_others_os")
                {
                    model_new.lid_others_os = x.result;
                }

                if (x.title == "conjunct_od_tick")
                {
                    model_new.conjunct_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_congestion_od_tick")
                {
                    model_new.conjunct_congestion_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_nevus_od_tick")
                {
                    model_new.conjunct_nevus_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_bleb_od_tick")
                {
                    model_new.conjunct_bleb_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_laceration_od_tick")
                {
                    model_new.conjunct_laceration_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_deposteroid_od_tick")
                {
                    model_new.conjunct_deposteroid_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_ptery_od_tick")
                {
                    model_new.conjunct_ptery_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_ping_od_tick")
                {
                    model_new.conjunct_ping_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_others_od_tick")
                {
                    model_new.conjunct_others_od_tick = x.tick_mark;
                }

                if (x.title == "conjunct_others_od")
                {
                    model_new.conjunct_others_od = x.result;
                }

                if (x.title == "conjunct_os_tick")
                {
                    model_new.conjunct_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_congestion_os_tick")
                {
                    model_new.conjunct_congestion_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_nevus_os_tick")
                {
                    model_new.conjunct_nevus_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_bleb_os_tick")
                {
                    model_new.conjunct_bleb_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_laceration_os_tick")
                {
                    model_new.conjunct_laceration_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_deposteroid_os_tick")
                {
                    model_new.conjunct_deposteroid_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_ptery_os_tick")
                {
                    model_new.conjunct_ptery_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_ping_os_tick")
                {
                    model_new.conjunct_ping_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_others_os_tick")
                {
                    model_new.conjunct_others_os_tick = x.tick_mark;
                }

                if (x.title == "conjunct_others_os")
                {
                    model_new.conjunct_others_os = x.result;
                }

                if (x.title == "sclera_od_tick")
                {
                    model_new.sclera_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_staphy_od_tick")
                {
                    model_new.sclera_staphy_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_ict_od_tick")
                {
                    model_new.sclera_ict_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_thinning_od_tick")
                {
                    model_new.sclera_thinning_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_melting_od_tick")
                {
                    model_new.sclera_melting_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_lacerat_od_tick")
                {
                    model_new.sclera_lacerat_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_others_od_tick")
                {
                    model_new.sclera_others_od_tick = x.tick_mark;
                }

                if (x.title == "sclera_others_od")
                {
                    model_new.sclera_others_od = x.result;
                }

                if (x.title == "sclera_os_tick")
                {
                    model_new.sclera_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_staphy_os_tick")
                {
                    model_new.sclera_staphy_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_ict_os_tick")
                {
                    model_new.sclera_ict_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_thinning_os_tick")
                {
                    model_new.sclera_thinning_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_melting_os_tick")
                {
                    model_new.sclera_melting_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_lacerat_os_tick")
                {
                    model_new.sclera_lacerat_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_others_os_tick")
                {
                    model_new.sclera_others_os_tick = x.tick_mark;
                }

                if (x.title == "sclera_others_os")
                {
                    model_new.sclera_others_os = x.result;
                }

                if (x.title == "cornea_od_tick")
                {
                    model_new.cornea_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_staphy_od_tick")
                {
                    model_new.cornea_staphy_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_ict_od_tick")
                {
                    model_new.cornea_ict_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_thinning_od_tick")
                {
                    model_new.cornea_thinning_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_melting_od_tick")
                {
                    model_new.cornea_melting_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_lacerat_od_tick")
                {
                    model_new.cornea_lacerat_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_others_od_tick")
                {
                    model_new.cornea_others_od_tick = x.tick_mark;
                }

                if (x.title == "cornea_others_od")
                {
                    model_new.cornea_others_od = x.result;
                }

                if (x.title == "cornea_os_tick")
                {
                    model_new.cornea_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_staphy_os_tick")
                {
                    model_new.cornea_staphy_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_ict_os_tick")
                {
                    model_new.cornea_ict_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_thinning_os_tick")
                {
                    model_new.cornea_thinning_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_melting_os_tick")
                {
                    model_new.cornea_melting_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_lacerat_os_tick")
                {
                    model_new.cornea_lacerat_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_others_os_tick")
                {
                    model_new.cornea_others_os_tick = x.tick_mark;
                }

                if (x.title == "cornea_others_os")
                {
                    model_new.cornea_others_os = x.result;
                }

                if (x.title == "anterchamb_od_tick")
                {
                    model_new.anterchamb_od_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_mh_od_tick")
                {
                    model_new.anterchamb_mh_od_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_pc_od_tick")
                {
                    model_new.anterchamb_pc_od_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_nf_od_tick")
                {
                    model_new.anterchamb_nf_od_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_others_od_tick")
                {
                    model_new.anterchamb_others_od_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_others_od")
                {
                    model_new.anterchamb_others_od = x.result;
                }

                if (x.title == "anterchamb_os_tick")
                {
                    model_new.anterchamb_os_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_mh_os_tick")
                {
                    model_new.anterchamb_mh_os_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_pc_os_tick")
                {
                    model_new.anterchamb_pc_os_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_nf_os_tick")
                {
                    model_new.anterchamb_nf_os_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_others_os_tick")
                {
                    model_new.anterchamb_others_os_tick = x.tick_mark;
                }

                if (x.title == "anterchamb_others_os")
                {
                    model_new.anterchamb_others_os = x.result;
                }

                if (x.title == "iris_od_tick")
                {
                    model_new.iris_od_tick = x.tick_mark;
                }

                if (x.title == "iris_hetero_od_tick")
                {
                    model_new.iris_hetero_od_tick = x.tick_mark;
                }

                if (x.title == "iris_atrophy_od_tick")
                {
                    model_new.iris_atrophy_od_tick = x.tick_mark;
                }

                if (x.title == "iris_nevus_od_tick")
                {
                    model_new.iris_nevus_od_tick = x.tick_mark;
                }

                if (x.title == "iris_sid_od_tick")
                {
                    model_new.iris_sid_od_tick = x.tick_mark;
                }

                if (x.title == "iris_anirid_od_tick")
                {
                    model_new.iris_anirid_od_tick = x.tick_mark;
                }

                if (x.title == "iris_others_od_tick")
                {
                    model_new.iris_others_od_tick = x.tick_mark;
                }

                if (x.title == "iris_others_od")
                {
                    model_new.iris_others_od = x.result;
                }

                if (x.title == "iris_os_tick")
                {
                    model_new.iris_os_tick = x.tick_mark;
                }

                if (x.title == "iris_hetero_os_tick")
                {
                    model_new.iris_hetero_os_tick = x.tick_mark;
                }

                if (x.title == "iris_atrophy_os_tick")
                {
                    model_new.iris_atrophy_os_tick = x.tick_mark;
                }

                if (x.title == "iris_nevus_os_tick")
                {
                    model_new.iris_nevus_os_tick = x.tick_mark;
                }

                if (x.title == "iris_sid_os_tick")
                {
                    model_new.iris_sid_os_tick = x.tick_mark;
                }

                if (x.title == "iris_anirid_os_tick")
                {
                    model_new.iris_anirid_os_tick = x.tick_mark;
                }

                if (x.title == "iris_others_os_tick")
                {
                    model_new.iris_others_os_tick = x.tick_mark;
                }

                if (x.title == "iris_others_os")
                {
                    model_new.iris_others_os = x.result;
                }

                if (x.title == "pupil_od_tick")
                {
                    model_new.pupil_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_corecto_od_tick")
                {
                    model_new.pupil_corecto_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_polyco_od_tick")
                {
                    model_new.pupil_polyco_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_ppm_od_tick")
                {
                    model_new.pupil_ppm_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_ppi_od_tick")
                {
                    model_new.pupil_ppi_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_dsp_od_tick")
                {
                    model_new.pupil_dsp_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_others_od_tick")
                {
                    model_new.pupil_others_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_others_od")
                {
                    model_new.pupil_others_od = x.result;
                }

                if (x.title == "pupil_os_tick")
                {
                    model_new.pupil_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_corecto_os_tick")
                {
                    model_new.pupil_corecto_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_polyco_os_tick")
                {
                    model_new.pupil_polyco_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_ppm_os_tick")
                {
                    model_new.pupil_ppm_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_ppi_os_tick")
                {
                    model_new.pupil_ppi_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_dsp_os_tick")
                {
                    model_new.pupil_dsp_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_others_os_tick")
                {
                    model_new.pupil_others_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_others_os")
                {
                    model_new.pupil_others_os = x.result;
                }

                if (x.title == "pupil_rti_od_tick")
                {
                    model_new.pupil_rti_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_rapd_od_tick")
                {
                    model_new.pupil_rti_rapd_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_slugreact_od_tick")
                {
                    model_new.pupil_rti_slugreact_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_hippus_od_tick")
                {
                    model_new.pupil_rti_hippus_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_aap_od_tick")
                {
                    model_new.pupil_rti_aap_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_apd_od_tick")
                {
                    model_new.pupil_rti_apd_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_others_od_tick")
                {
                    model_new.pupil_rti_others_od_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_others_od")
                {
                    model_new.pupil_rti_others_od = x.result;
                }

                if (x.title == "pupil_rti_os_tick")
                {
                    model_new.pupil_rti_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_rapd_os_tick")
                {
                    model_new.pupil_rti_rapd_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_slugreact_os_tick")
                {
                    model_new.pupil_rti_slugreact_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_hippus_os_tick")
                {
                    model_new.pupil_rti_hippus_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_aap_os_tick")
                {
                    model_new.pupil_rti_aap_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_apd_os_tick")
                {
                    model_new.pupil_rti_apd_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_others_os_tick")
                {
                    model_new.pupil_rti_others_os_tick = x.tick_mark;
                }

                if (x.title == "pupil_rti_others_os")
                {
                    model_new.pupil_rti_others_os = x.result;
                }

                if (x.title == "lens_phakic_od_tick")
                {
                    model_new.lens_phakic_od_tick = x.tick_mark;
                }

                if (x.title == "lens_pseuphakic_od_tick")
                {
                    model_new.lens_pseuphakic_od_tick = x.tick_mark;
                }

                if (x.title == "lens_aphakic_od_tick")
                {
                    model_new.lens_aphakic_od_tick = x.tick_mark;
                }

                if (x.title == "lens_phakic_os_tick")
                {
                    model_new.lens_phakic_os_tick = x.tick_mark;
                }

                if (x.title == "lens_pseuphakic_os_tick")
                {
                    model_new.lens_pseuphakic_os_tick = x.tick_mark;
                }

                if (x.title == "lens_aphakic_os_tick")
                {
                    model_new.lens_aphakic_os_tick = x.tick_mark;
                }

                if (x.title == "caps_od_tick")
                {
                    model_new.caps_od_tick = x.tick_mark;
                }

                if (x.title == "caps_pseudo_od_tick")
                {
                    model_new.caps_pseudo_od_tick = x.tick_mark;
                }

                if (x.title == "caps_pco_od_tick")
                {
                    model_new.caps_pco_od_tick = x.tick_mark;
                }

                if (x.title == "caps_others_od_tick")
                {
                    model_new.caps_others_od_tick = x.tick_mark;
                }

                if (x.title == "caps_others_od")
                {
                    model_new.caps_others_od = x.result;
                }

                if (x.title == "caps_os_tick")
                {
                    model_new.caps_os_tick = x.tick_mark;
                }

                if (x.title == "caps_pseudo_os_tick")
                {
                    model_new.caps_pseudo_os_tick = x.tick_mark;
                }

                if (x.title == "caps_pco_os_tick")
                {
                    model_new.caps_pco_os_tick = x.tick_mark;
                }

                if (x.title == "caps_others_os_tick")
                {
                    model_new.caps_others_os_tick = x.tick_mark;
                }

                if (x.title == "caps_others_os")
                {
                    model_new.caps_others_os = x.result;
                }

                if (x.title == "pos_phacod_od_tick")
                {
                    model_new.pos_phacod_od_tick = x.tick_mark;
                }

                if (x.title == "pos_sublux_od_tick")
                {
                    model_new.pos_sublux_od_tick = x.tick_mark;
                }

                if (x.title == "pos_disloc_od_tick")
                {
                    model_new.pos_disloc_od_tick = x.tick_mark;
                }

                if (x.title == "pos_none_od_tick")
                {
                    model_new.pos_none_od_tick = x.tick_mark;
                }

                if (x.title == "pos_phacod_os_tick")
                {
                    model_new.pos_phacod_os_tick = x.tick_mark;
                }

                if (x.title == "pos_sublux_os_tick")
                {
                    model_new.pos_sublux_os_tick = x.tick_mark;
                }

                if (x.title == "pos_disloc_os_tick")
                {
                    model_new.pos_disloc_os_tick = x.tick_mark;
                }

                if (x.title == "pos_none_os_tick")
                {
                    model_new.pos_none_os_tick = x.tick_mark;
                }

                if (x.title == "cataract_tick")
                {
                    model_new.cataract_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n0_od_tick")
                {
                    model_new.nucopal_n0_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n1_od_tick")
                {
                    model_new.nucopal_n1_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n2_od_tick")
                {
                    model_new.nucopal_n2_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n3_od_tick")
                {
                    model_new.nucopal_n3_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n4_od_tick")
                {
                    model_new.nucopal_n4_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_notgrade_od_tick")
                {
                    model_new.nucopal_notgrade_od_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n0_os_tick")
                {
                    model_new.nucopal_n0_os_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n1_os_tick")
                {
                    model_new.nucopal_n1_os_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n2_os_tick")
                {
                    model_new.nucopal_n2_os_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n3_os_tick")
                {
                    model_new.nucopal_n3_os_tick = x.tick_mark;
                }

                if (x.title == "nucopal_n4_os_tick")
                {
                    model_new.nucopal_n4_os_tick = x.tick_mark;
                }

                if (x.title == "nucopal_notgrade_os_tick")
                {
                    model_new.nucopal_notgrade_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c0_od_tick")
                {
                    model_new.cortical_c0_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_ctr_od_tick")
                {
                    model_new.cortical_ctr_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c1_od_tick")
                {
                    model_new.cortical_c1_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c2_od_tick")
                {
                    model_new.cortical_c2_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c3_od_tick")
                {
                    model_new.cortical_c3_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c4_od_tick")
                {
                    model_new.cortical_c4_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c5_od_tick")
                {
                    model_new.cortical_c5_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_notgrade_od_tick")
                {
                    model_new.cortical_notgrade_od_tick = x.tick_mark;
                }

                if (x.title == "cortical_c0_os_tick")
                {
                    model_new.cortical_c0_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_ctr_os_tick")
                {
                    model_new.cortical_ctr_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c1_os_tick")
                {
                    model_new.cortical_c1_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c2_os_tick")
                {
                    model_new.cortical_c2_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c3_os_tick")
                {
                    model_new.cortical_c3_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c4_os_tick")
                {
                    model_new.cortical_c4_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_c5_os_tick")
                {
                    model_new.cortical_c5_os_tick = x.tick_mark;
                }

                if (x.title == "cortical_notgrade_os_tick")
                {
                    model_new.cortical_notgrade_os_tick = x.tick_mark;
                }

                if (x.title == "psc_p0_od_tick")
                {
                    model_new.psc_p0_od_tick = x.tick_mark;
                }

                if (x.title == "psc_p1_od_tick")
                {
                    model_new.psc_p1_od_tick = x.tick_mark;
                }

                if (x.title == "psc_p2_od_tick")
                {
                    model_new.psc_p2_od_tick = x.tick_mark;
                }

                if (x.title == "psc_p3_od_tick")
                {
                    model_new.psc_p3_od_tick = x.tick_mark;
                }

                if (x.title == "psc_p4_od_tick")
                {
                    model_new.psc_p4_od_tick = x.tick_mark;
                }

                if (x.title == "psc_notgrade_od_tick")
                {
                    model_new.psc_notgrade_od_tick = x.tick_mark;
                }

                if (x.title == "psc_p0_os_tick")
                {
                    model_new.psc_p0_os_tick = x.tick_mark;
                }

                if (x.title == "psc_p1_os_tick")
                {
                    model_new.psc_p1_os_tick = x.tick_mark;
                }

                if (x.title == "psc_p2_os_tick")
                {
                    model_new.psc_p2_os_tick = x.tick_mark;
                }

                if (x.title == "psc_p3_os_tick")
                {
                    model_new.psc_p3_os_tick = x.tick_mark;
                }

                if (x.title == "psc_p4_os_tick")
                {
                    model_new.psc_p4_os_tick = x.tick_mark;
                }

                if (x.title == "psc_notgrade_os_tick")
                {
                    model_new.psc_notgrade_os_tick = x.tick_mark;
                }

                if (x.title == "maturecat_od_tick")
                {
                    model_new.maturecat_od_tick = x.tick_mark;
                }

                if (x.title == "maturecat_os_tick")
                {
                    model_new.maturecat_os_tick = x.tick_mark;
                }

                if (x.title == "compact_od_tick")
                {
                    model_new.compact_od_tick = x.tick_mark;
                }

                if (x.title == "compact_os_tick")
                {
                    model_new.compact_os_tick = x.tick_mark;
                }
                if (x.title == "vitreous_od_tick") { model_new.vitreous_od_tick = x.tick_mark; }
                if (x.title == "vitreous_pvd_od_tick") { model_new.vitreous_pvd_od_tick = x.tick_mark; }
                if (x.title == "vitreous_vh_od_tick") { model_new.vitreous_vh_od_tick = x.tick_mark; }
                if (x.title == "vitreous_oparities_od_tick") { model_new.vitreous_oparities_od_tick = x.tick_mark; }
                if (x.title == "vitreous_other_od_tick") { model_new.vitreous_other_od_tick = x.tick_mark; }
                if (x.title == "vitreous_other_od") { model_new.vitreous_other_od = x.result; }
                if (x.title == "vitreous_os_tick") { model_new.vitreous_os_tick = x.tick_mark; }
                if (x.title == "vitreous_pvd_os_tick") { model_new.vitreous_pvd_os_tick = x.tick_mark; }
                if (x.title == "vitreous_vh_os_tick") { model_new.vitreous_vh_os_tick = x.tick_mark; }
                if (x.title == "vitreous_oparities_os_tick") { model_new.vitreous_oparities_os_tick = x.tick_mark; }
                if (x.title == "vitreous_other_os_tick") { model_new.vitreous_other_os_tick = x.tick_mark; }
                if (x.title == "vitreous_other_os") { model_new.vitreous_other_os = x.result; }
                if (x.title == "vitreous_remarks_od") { model_new.vitreous_remarks_od = x.result; }
                if (x.title == "vitreous_remarks_os") { model_new.vitreous_remarks_os = x.result; }
                if (x.title == "retina_od_tick") { model_new.retina_od_tick = x.tick_mark; }
                if (x.title == "retina_os_tick") { model_new.retina_os_tick = x.tick_mark; }
                if (x.title == "retina_od") { model_new.retina_od = x.result; }
                if (x.title == "retina_os") { model_new.retina_os = x.result; }
                if (x.title == "disc_od_tick") { model_new.disc_od_tick = x.tick_mark; }
                if (x.title == "disc_os_tick") { model_new.disc_os_tick = x.tick_mark; }
                if (x.title == "disc_od") { model_new.disc_od = x.result; }
                if (x.title == "disc_os") { model_new.disc_os = x.result; }
                if (x.title == "cdr_od_tick") { model_new.cdr_od_tick = x.tick_mark; }
                if (x.title == "cdr_od") { model_new.cdr_od = x.result; }
                if (x.title == "cdr_os_tick") { model_new.cdr_os_tick = x.tick_mark; }
                if (x.title == "cdr_os") { model_new.cdr_os = x.result; }
                if (x.title == "macula_od_tick") { model_new.macula_od_tick = x.tick_mark; }
                if (x.title == "macula_erm_od_tick") { model_new.macula_erm_od_tick = x.tick_mark; }
                if (x.title == "macula_hole_od_tick") { model_new.macula_hole_od_tick = x.tick_mark; }
                if (x.title == "macula_hemorage_od_tick") { model_new.macula_hemorage_od_tick = x.tick_mark; }
                if (x.title == "macula_edema_od_tick") { model_new.macula_edema_od_tick = x.tick_mark; }
                if (x.title == "macula_other_od_tick") { model_new.macula_other_od_tick = x.tick_mark; }
                if (x.title == "macula_other_od") { model_new.macula_other_od = x.result; }
                if (x.title == "macula_os_tick") { model_new.macula_os_tick = x.tick_mark; }
                if (x.title == "macula_erm_os_tick") { model_new.macula_erm_os_tick = x.tick_mark; }
                if (x.title == "macula_hole_os_tick") { model_new.macula_hole_os_tick = x.tick_mark; }
                if (x.title == "macula_hemorage_os_tick") { model_new.macula_hemorage_os_tick = x.tick_mark; }
                if (x.title == "macula_edema_os_tick") { model_new.macula_edema_os_tick = x.tick_mark; }
                if (x.title == "macula_other_os_tick") { model_new.macula_other_os_tick = x.tick_mark; }
                if (x.title == "macula_other_os") { model_new.macula_other_os = x.result; }
                if (x.title == "vessels_od_tick") { model_new.vessels_od_tick = x.tick_mark; }
                if (x.title == "vessels_od") { model_new.vessels_od = x.result; }
                if (x.title == "vessels_os_tick") { model_new.vessels_os_tick = x.tick_mark; }
                if (x.title == "vessels_os") { model_new.vessels_os = x.result; }
                if (x.title == "periphery_od_tick") { model_new.periphery_od_tick = x.tick_mark; }
                if (x.title == "periphery_od") { model_new.periphery_od = x.result; }
                if (x.title == "periphery_os_tick") { model_new.periphery_os_tick = x.tick_mark; }
                if (x.title == "periphery_os") { model_new.periphery_os = x.result; }
                if (x.title == "tear_film_od_tick") { model_new.tear_film_od_tick = x.tick_mark; }
                if (x.title == "tear_flim_od") { model_new.tear_flim_od = x.result; }
                if (x.title == "tear_flim_os_tick") { model_new.tear_flim_os_tick = x.tick_mark; }
                if (x.title == "tear_flim_os") { model_new.tear_flim_os = x.result; }
                if (x.title == "tbvt_od_tick") { model_new.tbvt_od_tick = x.tick_mark; }
                if (x.title == "tbvt_od") { model_new.tbvt_od = x.result; }
                if (x.title == "tbvt_os_tick") { model_new.tbvt_os_tick = x.tick_mark; }
                if (x.title == "tbvt_os") { model_new.tbvt_os = x.result; }
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
