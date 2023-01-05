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
    public class OcularInvestigationController : ApiController
    {
        [HttpPost]
        [Route("api/OcularInvestigationAll")]
        public IHttpActionResult Post(OcularInvestigationInsertAll_dt model)
        {
            try {
            
            OcularInvestigationDetailInsert_dt model1 = new OcularInvestigationDetailInsert_dt();
            InsertOcular(model, model1);
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
        [Route("api/OcularInvestigationAll/Update")]
        public IHttpActionResult UpdateAll(OcularInvestigationInsertAll_dt model)
        {
            try
            {

            
            OcularInvestigationDetailDelete_dt model_new = new OcularInvestigationDetailDelete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailDelete", model_new);
            OcularInvestigationDetailInsert_dt model1 = new OcularInvestigationDetailInsert_dt();
            InsertOcular(model, model1);
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

        private static void InsertOcular(OcularInvestigationInsertAll_dt model, OcularInvestigationDetailInsert_dt model1)
        {

            model1.mrdno = model.mrdno;
            model1.hospid = model.hospid;
            model1.ddate = model.ddate;

            model1.title = "at_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.at_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "at_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.at_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_od_open_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_od_open_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_od_close_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_od_close_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_od_occludable_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_od_occludable_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_od_nonoccludable_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_od_nonoccludable_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_os_open_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_os_open_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_os_close_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_os_close_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_os_occludable_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_os_occludable_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_os_nonoccludable_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_os_nonoccludable_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "gonioscopy_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.gonioscopy_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "normal_od_tick";
            model1.result = "";
            model1.tick_mark = model.normal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "refractive_error_od_tick";
            model1.result = "";
            model1.tick_mark = model.refractive_error_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "presbyopia_od_tick";
            model1.result = "";
            model1.tick_mark = model.presbyopia_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "cataract_untreated_od_tick";
            model1.result = "";
            model1.tick_mark = model.cataract_untreated_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

           

            model1.title = "phthisis_od_tick";
            model1.result = "";
            model1.tick_mark = model.phthisis_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

           

            model1.title = "glaucoma_od_tick";
            model1.result = "";
            model1.tick_mark = model.glaucoma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "diabetic_od_tick";
            model1.result = "";
            model1.tick_mark = model.diabetic_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

           

            model1.title = "other_posterior_od_tick";
            model1.result = "";
            model1.tick_mark = model.other_posterior_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "others_od_tick";
            model1.result = "";
            model1.tick_mark = model.others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "normal_os_tick";
            model1.result = "";
            model1.tick_mark = model.normal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "refractive_error_os_tick";
            model1.result = "";
            model1.tick_mark = model.refractive_error_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "presbyopia_os_tick";
            model1.result = "";
            model1.tick_mark = model.presbyopia_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "cataract_untreated_os_tick";
            model1.result = "";
            model1.tick_mark = model.cataract_untreated_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

           

            model1.title = "phthisis_os_tick";
            model1.result = "";
            model1.tick_mark = model.phthisis_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

           

            model1.title = "glaucoma_os_tick";
            model1.result = "";
            model1.tick_mark = model.glaucoma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "diabetic_os_tick";
            model1.result = "";
            model1.tick_mark = model.diabetic_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            

            model1.title = "other_posterior_os_tick";
            model1.result = "";
            model1.tick_mark = model.other_posterior_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "others_os_tick";
            model1.result = "";
            model1.tick_mark = model.others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "medical_treatment_od_tick";
            model1.result = "";
            model1.tick_mark = model.medical_treatment_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "surgrical_treatment_od_tick";
            model1.result = "";
            model1.tick_mark = model.surgrical_treatment_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "medical_treatment_os_tick";
            model1.result = "";
            model1.tick_mark = model.medical_treatment_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "surgrical_treatment_os_tick";
            model1.result = "";
            model1.tick_mark = model.surgrical_treatment_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "followup_od_tick";
            model1.result = "";
            model1.tick_mark = model.followup_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "followup_os_tick";
            model1.result = "";
            model1.tick_mark = model.followup_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            /* model1.title = "bscan_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_nf_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_nf_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_mh_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_mh_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_pc_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_pc_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_mh_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_mh_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_pc_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_pc_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_nf_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_nf_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_other_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_other_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_other_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_other_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_interpretation_od_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_interpretation_od_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

             model1.title = "bscan_interpretation_os_tick";
             model1.result = "";
             model1.tick_mark = model.bscan_interpretation_os_tick;
             DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);*/

            model1.title = "fundus_od_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_os_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fundus_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.fundus_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "funudus_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.funudus_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "funudus_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.funudus_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.disc_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "disc_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.disc_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.post_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "post_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.post_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "fdp_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.fdp_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterior_segment_tick";
            model1.result = "";
            model1.tick_mark = model.anterior_segment_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.ct_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ct_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.ct_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "ascan_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.ascan_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_mh_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_mh_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_mh_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_mh_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_pc_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_pc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_pc_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_pc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_nf_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_nf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_nf_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_nf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_other_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_other_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_other_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_other_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_erpretation_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_erpretation_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterioroct_erpretation_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterioroct_erpretation_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            /*  model1.title = "posterior_segment_tick";
            model1.result = "";
            model1.tick_mark = model.posterior_segment_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);*/         

            model1.title = "laser_treatment_od_tick";
            model1.result = "";
            model1.tick_mark = model.laser_treatment_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "laser_treatment_os_tick";
            model1.result = "";
            model1.tick_mark = model.laser_treatment_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_referal_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_referal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_referal_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_referal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspec_corena_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspec_corena_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_retina_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_retina_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_glaucoma_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_glaucoma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_opal_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_opal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_referr_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_referr_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_squint_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_squint_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_uvea_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_uvea_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_neuropthalmo_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_neuropthalmo_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_none_od_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_none_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspec_corena_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspec_corena_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_retina_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_retina_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_glaucoma_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_glaucoma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_opal_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_opal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_referr_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_referr_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_squint_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_squint_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_uvea_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_uvea_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_neuropthalmo_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_neuropthalmo_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "subspeciality_none_os_tick";
            model1.result = "";
            model1.tick_mark = model.subspeciality_none_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "visual_field_od_tick";
            model1.result = "";
            model1.tick_mark = model.visual_field_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "visual_field_interpret_od_tick";
            model1.result = "";
            model1.tick_mark = model.visual_field_interpret_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "visual_field_os_tick";
            model1.result = "";
            model1.tick_mark = model.visual_field_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "visual_field_interpret_os_tick";
            model1.result = "";
            model1.tick_mark = model.visual_field_interpret_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "treatment_od_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "treatment_os_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "schirmer_od_tick";
            model1.result = "";
            model1.tick_mark = model.schirmer_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "schirmer_os_tick";
            model1.result = "";
            model1.tick_mark = model.schirmer_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "conjunc_od_tick";
            model1.result = "";
            model1.tick_mark = model.conjunc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "conjunc_os_tick";
            model1.result = "";
            model1.tick_mark = model.conjunc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "hpt_od_tick";
            model1.result = "";
            model1.tick_mark = model.hpt_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "hpt_os_tick";
            model1.result = "";
            model1.tick_mark = model.hpt_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterior_od_tick";
            model1.result = "";
            model1.tick_mark = model.anterior_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anterior_os_tick";
            model1.result = "";
            model1.tick_mark = model.anterior_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "uveal_od_tick";
            model1.result = "";
            model1.tick_mark = model.uveal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "uveal_os_tick";
            model1.result = "";
            model1.tick_mark = model.uveal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anteriorint_od_tick";
            model1.result = "";
            model1.tick_mark = model.anteriorint_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);

            model1.title = "anteriorint_os_tick";
            model1.result = "";
            model1.tick_mark = model.anteriorint_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);



            if ((model.at_od is null ? "" : model.at_od).Length > 0)
            {
                model1.title = "at_od";
                model1.result = model.at_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.at_os is null ? "" : model.at_os).Length > 0)
            {
                model1.title = "at_os";
                model1.result = model.at_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.at_other_od is null ? "" : model.at_other_od).Length > 0)
            {
                model1.title = "at_other_od";
                model1.result = model.at_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }


            if ((model.at_other_os is null ? "" : model.at_other_os).Length > 0)
            {
                model1.title = "at_other_os";
                model1.result = model.at_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.at_erpretation_od is null ? "" : model.at_erpretation_od).Length > 0)
            {
                model1.title = "at_erpretation_od";
                model1.result = model.at_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.at_erpretation_os is null ? "" : model.at_erpretation_os).Length > 0)
            {
                model1.title = "at_erpretation_os";
                model1.result = model.at_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.gonioscopy_other_od is null ? "" : model.gonioscopy_other_od).Length > 0)
            {
                model1.title = "gonioscopy_other_od";
                model1.result = model.gonioscopy_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.gonioscopy_other_os is null ? "" : model.gonioscopy_other_os).Length > 0)
            {
                model1.title = "gonioscopy_other_os";
                model1.result = model.gonioscopy_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.gonioscopy_erpretation_od is null ? "" : model.gonioscopy_erpretation_od).Length > 0)
            {
                model1.title = "gonioscopy_erpretation_od";
                model1.result = model.gonioscopy_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.gonioscopy_erpretation_os is null ? "" : model.gonioscopy_erpretation_os).Length > 0)
            {
                model1.title = "gonioscopy_erpretation_os";
                model1.result = model.gonioscopy_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

        

            if ((model.others_od is null ? "" : model.others_od).Length > 0)
            {
                model1.title = "others_od";
                model1.result = model.others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

          

            if ((model.others_os is null ? "" : model.others_os).Length > 0)
            {
                model1.title = "others_os";
                model1.result = model.others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }


            if ((model.medical_treatment_od is null ? "" : model.medical_treatment_od).Length > 0)
            {
                model1.title = "medical_treatment_od";
                model1.result = model.medical_treatment_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }


            if ((model.surgrical_treatment_od is null ? "" : model.surgrical_treatment_od).Length > 0)
            {
                model1.title = "surgrical_treatment_od";
                model1.result = model.surgrical_treatment_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.medical_treatment_os is null ? "" : model.medical_treatment_os).Length > 0)
            {
                model1.title = "medical_treatment_os";
                model1.result = model.medical_treatment_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.surgrical_treatment_os is null ? "" : model.surgrical_treatment_os).Length > 0)
            {
                model1.title = "surgrical_treatment_os";
                model1.result = model.surgrical_treatment_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.followup_od is null ? "" : model.followup_od).Length > 0)
            {
                model1.title = "followup_od";
                model1.result = model.followup_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.followup_os is null ? "" : model.followup_os).Length > 0)
            {
                model1.title = "followup_os";
                model1.result = model.followup_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            /* if ((model.bscan_acp_od is null ? "" : model.bscan_acp_od).Length > 0)
             {
                 model1.title = "bscan_acp_od";
                 model1.result = model.bscan_acp_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_al_od is null ? "" : model.bscan_al_od).Length > 0)
             {
                 model1.title = "bscan_al_od";
                 model1.result = model.bscan_al_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_iolpower_od is null ? "" : model.bscan_iolpower_od).Length > 0)
             {
                 model1.title = "bscan_iolpower_od";
                 model1.result = model.bscan_iolpower_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_lt_od is null ? "" : model.bscan_lt_od).Length > 0)
             {
                 model1.title = "bscan_lt_od";
                 model1.result = model.bscan_lt_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_acp_os is null ? "" : model.bscan_acp_os).Length > 0)
             {
                 model1.title = "bscan_acp_os";
                 model1.result = model.bscan_acp_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_al_os is null ? "" : model.bscan_al_os).Length > 0)
             {
                 model1.title = "bscan_al_os";
                 model1.result = model.bscan_al_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_iolpower_os is null ? "" : model.bscan_iolpower_os).Length > 0)
             {
                 model1.title = "bscan_iolpower_os";
                 model1.result = model.bscan_iolpower_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_lt_os is null ? "" : model.bscan_lt_os).Length > 0)
             {
                 model1.title = "bscan_lt_os";
                 model1.result = model.bscan_lt_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_other_od is null ? "" : model.bscan_other_od).Length > 0)
             {
                 model1.title = "bscan_other_od";
                 model1.result = model.bscan_other_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_other_os is null ? "" : model.bscan_other_os).Length > 0)
             {
                 model1.title = "bscan_other_os";
                 model1.result = model.bscan_other_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_interpretation_od is null ? "" : model.bscan_interpretation_od).Length > 0)
             {
                 model1.title = "bscan_interpretation_od";
                 model1.result = model.bscan_interpretation_od;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }

             if ((model.bscan_interpretation_os is null ? "" : model.bscan_interpretation_os).Length > 0)
             {
                 model1.title = "bscan_interpretation_os";
                 model1.result = model.bscan_interpretation_os;
                 model1.tick_mark = false;
                 DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
             }*/
            if ((model.fundus_others_od is null ? "" : model.fundus_others_od).Length > 0)
            {
                model1.title = "fundus_others_od";
                model1.result = model.fundus_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.fundus_others_os is null ? "" : model.fundus_others_os).Length > 0)
            {
                model1.title = "fundus_others_os";
                model1.result = model.fundus_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.funudus_erpretation_od is null ? "" : model.funudus_erpretation_od).Length > 0)
            {
                model1.title = "funudus_erpretation_od";
                model1.result = model.funudus_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.funudus_erpretation_os is null ? "" : model.funudus_erpretation_os).Length > 0)
            {
                model1.title = "funudus_erpretation_os";
                model1.result = model.funudus_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.disc_others_od is null ? "" : model.disc_others_od).Length > 0)
            {
                model1.title = "disc_others_od";
                model1.result = model.disc_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.disc_others_os is null ? "" : model.disc_others_os).Length > 0)
            {
                model1.title = "disc_others_os";
                model1.result = model.disc_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.disc_erpretation_od is null ? "" : model.disc_erpretation_od).Length > 0)
            {
                model1.title = "disc_erpretation_od";
                model1.result = model.disc_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.disc_erpretation_os is null ? "" : model.disc_erpretation_os).Length > 0)
            {
                model1.title = "disc_erpretation_os";
                model1.result = model.disc_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_sga_od is null ? "" : model.post_sga_od).Length > 0)
            {
                model1.title = "post_sga_od";
                model1.result = model.post_sga_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_it1_od is null ? "" : model.post_it1_od).Length > 0)
            {
                model1.title = "post_it1_od";
                model1.result = model.post_it1_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_it2_od is null ? "" : model.post_it2_od).Length > 0)
            {
                model1.title = "post_it2_od";
                model1.result = model.post_it2_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_ac_od is null ? "" : model.post_ac_od).Length > 0)
            {
                model1.title = "post_ac_od";
                model1.result = model.post_ac_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_acw_od is null ? "" : model.post_acw_od).Length > 0)
            {
                model1.title = "post_acw_od";
                model1.result = model.post_acw_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_lv_od is null ? "" : model.post_lv_od).Length > 0)
            {
                model1.title = "post_lv_od";
                model1.result = model.post_lv_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_ara_od is null ? "" : model.post_ara_od).Length > 0)
            {
                model1.title = "post_ara_od";
                model1.result = model.post_ara_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_aod500_od is null ? "" : model.post_aod500_od).Length > 0)
            {
                model1.title = "post_aod500_od";
                model1.result = model.post_aod500_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_aod7500_od is null ? "" : model.post_aod7500_od).Length > 0)
            {
                model1.title = "post_aod7500_od";
                model1.result = model.post_aod7500_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_tisa_od is null ? "" : model.post_tisa_od).Length > 0)
            {
                model1.title = "post_tisa_od";
                model1.result = model.post_tisa_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_tia_od is null ? "" : model.post_tia_od).Length > 0)
            {
                model1.title = "post_tia_od";
                model1.result = model.post_tia_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_sga_os is null ? "" : model.post_sga_os).Length > 0)
            {
                model1.title = "post_sga_os";
                model1.result = model.post_sga_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_it1_os is null ? "" : model.post_it1_os).Length > 0)
            {
                model1.title = "post_it1_os";
                model1.result = model.post_it1_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_it2_os is null ? "" : model.post_it2_os).Length > 0)
            {
                model1.title = "post_it2_os";
                model1.result = model.post_it2_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_ac_os is null ? "" : model.post_ac_os).Length > 0)
            {
                model1.title = "post_ac_os";
                model1.result = model.post_ac_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_acw_os is null ? "" : model.post_acw_os).Length > 0)
            {
                model1.title = "post_acw_os";
                model1.result = model.post_acw_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_lv_os is null ? "" : model.post_lv_os).Length > 0)
            {
                model1.title = "post_lv_os";
                model1.result = model.post_lv_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_ara_os is null ? "" : model.post_ara_os).Length > 0)
            {
                model1.title = "post_ara_os";
                model1.result = model.post_ara_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_aod500_os is null ? "" : model.post_aod500_os).Length > 0)
            {
                model1.title = "post_aod500_os";
                model1.result = model.post_aod500_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_aod7500_os is null ? "" : model.post_aod7500_os).Length > 0)
            {
                model1.title = "post_aod7500_os";
                model1.result = model.post_aod7500_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_tisa_os is null ? "" : model.post_tisa_os).Length > 0)
            {
                model1.title = "post_tisa_os";
                model1.result = model.post_tisa_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_tia_os is null ? "" : model.post_tia_os).Length > 0)
            {
                model1.title = "post_tia_os";
                model1.result = model.post_tia_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_others_od is null ? "" : model.post_others_od).Length > 0)
            {
                model1.title = "post_others_od";
                model1.result = model.post_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_others_os is null ? "" : model.post_others_os).Length > 0)
            {
                model1.title = "post_others_os";
                model1.result = model.post_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_erpretation_od is null ? "" : model.post_erpretation_od).Length > 0)
            {
                model1.title = "post_erpretation_od";
                model1.result = model.post_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            if ((model.post_erpretation_os is null ? "" : model.post_erpretation_os).Length > 0)
            {
                model1.title = "post_erpretation_os";
                model1.result = model.post_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.fdp_others_od is null ? "" : model.fdp_others_od).Length > 0)
            {
                model1.title = "fdp_others_od";
                model1.result = model.fdp_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.fdp_others_os is null ? "" : model.fdp_others_os).Length > 0)
            {
                model1.title = "fdp_others_os";
                model1.result = model.fdp_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.fdp_erpretation_od is null ? "" : model.fdp_erpretation_od).Length > 0)
            {
                model1.title = "fdp_erpretation_od";
                model1.result = model.fdp_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.fdp_erpretation_os is null ? "" : model.fdp_erpretation_os).Length > 0)
            {
                model1.title = "fdp_erpretation_os";
                model1.result = model.fdp_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
            

            if ((model.cct_od is null ? "" : model.cct_od).Length > 0)
            {
                model1.title = "cct_od";
                model1.result = model.cct_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.k1_od is null ? "" : model.k1_od).Length > 0)
            {
                model1.title = "k1_od";
                model1.result = model.k1_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.k2_od is null ? "" : model.k2_od).Length > 0)
            {
                model1.title = "k2_od";
                model1.result = model.k2_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.cct_os is null ? "" : model.cct_os).Length > 0)
            {
                model1.title = "cct_os";
                model1.result = model.cct_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.k1_os is null ? "" : model.k1_os).Length > 0)
            {
                model1.title = "k1_os";
                model1.result = model.k1_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.k2_os is null ? "" : model.k2_os).Length > 0)
            {
                model1.title = "k2_os";
                model1.result = model.k2_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ct_other_od is null ? "" : model.ct_other_od).Length > 0)
            {
                model1.title = "ct_other_od";
                model1.result = model.ct_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ct_other_os is null ? "" : model.ct_other_os).Length > 0)
            {
                model1.title = "ct_other_os";
                model1.result = model.ct_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ct_erpretation_od is null ? "" : model.ct_erpretation_od).Length > 0)
            {
                model1.title = "ct_erpretation_od";
                model1.result = model.ct_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ct_erpretation_os is null ? "" : model.ct_erpretation_os).Length > 0)
            {
                model1.title = "ct_erpretation_os";
                model1.result = model.ct_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_acp_od is null ? "" : model.ascan_acp_od).Length > 0)
            {
                model1.title = "ascan_acp_od";
                model1.result = model.ascan_acp_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_al_od is null ? "" : model.ascan_al_od).Length > 0)
            {
                model1.title = "ascan_al_od";
                model1.result = model.ascan_al_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_iolpower_od is null ? "" : model.ascan_iolpower_od).Length > 0)
            {
                model1.title = "ascan_iolpower_od";
                model1.result = model.ascan_iolpower_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_lt_od is null ? "" : model.ascan_lt_od).Length > 0)
            {
                model1.title = "ascan_lt_od";
                model1.result = model.ascan_lt_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_acp_os is null ? "" : model.ascan_acp_os).Length > 0)
            {
                model1.title = "ascan_acp_os";
                model1.result = model.ascan_acp_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_al_os is null ? "" : model.ascan_al_os).Length > 0)
            {
                model1.title = "ascan_al_os";
                model1.result = model.ascan_al_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_iolpower_os is null ? "" : model.ascan_iolpower_os).Length > 0)
            {
                model1.title = "ascan_iolpower_os";
                model1.result = model.ascan_iolpower_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_lt_os is null ? "" : model.ascan_lt_os).Length > 0)
            {
                model1.title = "ascan_lt_os";
                model1.result = model.ascan_lt_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_other_od is null ? "" : model.ascan_other_od).Length > 0)
            {
                model1.title = "ascan_other_od";
                model1.result = model.ascan_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_other_os is null ? "" : model.ascan_other_os).Length > 0)
            {
                model1.title = "ascan_other_os";
                model1.result = model.ascan_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_erpretation_od is null ? "" : model.ascan_erpretation_od).Length > 0)
            {
                model1.title = "ascan_erpretation_od";
                model1.result = model.ascan_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.ascan_erpretation_os is null ? "" : model.ascan_erpretation_os).Length > 0)
            {
                model1.title = "ascan_erpretation_os";
                model1.result = model.ascan_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorsga_od is null ? "" : model.anteriorsga_od).Length > 0)
            {
                model1.title = "anteriorsga_od";
                model1.result = model.anteriorsga_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorit1_od is null ? "" : model.anteriorit1_od).Length > 0)
            {
                model1.title = "anteriorit1_od";
                model1.result = model.anteriorit1_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorit2_od is null ? "" : model.anteriorit2_od).Length > 0)
            {
                model1.title = "anteriorit2_od";
                model1.result = model.anteriorit2_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioracdepth_od is null ? "" : model.anterioracdepth_od).Length > 0)
            {
                model1.title = "anterioracdepth_od";
                model1.result = model.anterioracdepth_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioracwidth_od is null ? "" : model.anterioracwidth_od).Length > 0)
            {
                model1.title = "anterioracwidth_od";
                model1.result = model.anterioracwidth_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorlv_od is null ? "" : model.anteriorlv_od).Length > 0)
            {
                model1.title = "anteriorlv_od";
                model1.result = model.anteriorlv_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorara_od is null ? "" : model.anteriorara_od).Length > 0)
            {
                model1.title = "anteriorara_od";
                model1.result = model.anteriorara_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioraod500_od is null ? "" : model.anterioraod500_od).Length > 0)
            {
                model1.title = "anterioraod500_od";
                model1.result = model.anterioraod500_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioraod750_od is null ? "" : model.anterioraod750_od).Length > 0)
            {
                model1.title = "anterioraod750_od";
                model1.result = model.anterioraod750_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriortisa_od is null ? "" : model.anteriortisa_od).Length > 0)
            {
                model1.title = "anteriortisa_od";
                model1.result = model.anteriortisa_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriortia_od is null ? "" : model.anteriortia_od).Length > 0)
            {
                model1.title = "anteriortia_od";
                model1.result = model.anteriortia_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorsga_os is null ? "" : model.anteriorsga_os).Length > 0)
            {
                model1.title = "anteriorsga_os";
                model1.result = model.anteriorsga_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorit1_os is null ? "" : model.anteriorit1_os).Length > 0)
            {
                model1.title = "anteriorit1_os";
                model1.result = model.anteriorit1_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorit2_os is null ? "" : model.anteriorit2_os).Length > 0)
            {
                model1.title = "anteriorit2_os";
                model1.result = model.anteriorit2_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioracdepth_os is null ? "" : model.anterioracdepth_os).Length > 0)
            {
                model1.title = "anterioracdepth_os";
                model1.result = model.anterioracdepth_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioracwidth_os is null ? "" : model.anterioracwidth_os).Length > 0)
            {
                model1.title = "anterioracwidth_os";
                model1.result = model.anterioracwidth_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorlv_os is null ? "" : model.anteriorlv_os).Length > 0)
            {
                model1.title = "anteriorlv_os";
                model1.result = model.anteriorlv_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriorara_os is null ? "" : model.anteriorara_os).Length > 0)
            {
                model1.title = "anteriorara_os";
                model1.result = model.anteriorara_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioraod500_os is null ? "" : model.anterioraod500_os).Length > 0)
            {
                model1.title = "anterioraod500_os";
                model1.result = model.anterioraod500_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioraod750_os is null ? "" : model.anterioraod750_os).Length > 0)
            {
                model1.title = "anterioraod750_os";
                model1.result = model.anterioraod750_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anteriortisa_os is null ? "" : model.anteriortisa_os).Length > 0)
            {
                model1.title = "anteriortisa_os";
                model1.result = model.anteriortisa_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterior_tia_os is null ? "" : model.anterior_tia_os).Length > 0)
            {
                model1.title = "anterior_tia_os";
                model1.result = model.anterior_tia_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioroct_other_od is null ? "" : model.anterioroct_other_od).Length > 0)
            {
                model1.title = "anterioroct_other_od";
                model1.result = model.anterioroct_other_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioroct_other_os is null ? "" : model.anterioroct_other_os).Length > 0)
            {
                model1.title = "anterioroct_other_os";
                model1.result = model.anterioroct_other_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }


            if ((model.anterioroct_erpretation_od is null ? "" : model.anterioroct_erpretation_od).Length > 0)
            {
                model1.title = "anterioroct_erpretation_od";
                model1.result = model.anterioroct_erpretation_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterioroct_erpretation_os is null ? "" : model.anterioroct_erpretation_os).Length > 0)
            {
                model1.title = "anterioroct_erpretation_os";
                model1.result = model.anterioroct_erpretation_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.laser_treatment_od is null ? "" : model.laser_treatment_od).Length > 0)
            {
                model1.title = "laser_treatment_od";
                model1.result = model.laser_treatment_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.laser_treatment_os is null ? "" : model.laser_treatment_os).Length > 0)
            {
                model1.title = "laser_treatment_os";
                model1.result = model.laser_treatment_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.visual_field_interpret_od is null ? "" : model.visual_field_interpret_od).Length > 0)
            {
                model1.title = "visual_field_interpret_od";
                model1.result = model.visual_field_interpret_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.visual_field_interpret_os is null ? "" : model.visual_field_interpret_os).Length > 0)
            {
                model1.title = "visual_field_interpret_os";
                model1.result = model.visual_field_interpret_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.schirmer_od is null ? "" : model.schirmer_od).Length > 0)
            {
                model1.title = "schirmer_od";
                model1.result = model.schirmer_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.schirmer_os is null ? "" : model.schirmer_os).Length > 0)
            {
                model1.title = "schirmer_os";
                model1.result = model.schirmer_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.tx_plan is null ? "" : model.tx_plan).Length > 0)
            {
                model1.title = "tx_plan";
                model1.result = model.tx_plan;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.visual_field_interpret_od is null ? "" : model.visual_field_interpret_od).Length > 0)
            {
                model1.title = "visual_field_interpret_od";
                model1.result = model.visual_field_interpret_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.conjunc_od is null ? "" : model.conjunc_od).Length > 0)
            {
                model1.title = "conjunc_od";
                model1.result = model.conjunc_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.conjunc_os is null ? "" : model.conjunc_os).Length > 0)
            {
                model1.title = "conjunc_os";
                model1.result = model.conjunc_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.glaucoma_od is null ? "" : model.glaucoma_od).Length > 0)
            {
                model1.title = "glaucoma_od";
                model1.result = model.glaucoma_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.glaucoma_os is null ? "" : model.glaucoma_os).Length > 0)
            {
                model1.title = "glaucoma_os";
                model1.result = model.glaucoma_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.catar_od is null ? "" : model.catar_od).Length > 0)
            {
                model1.title = "catar_od";
                model1.result = model.catar_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.catar_os is null ? "" : model.catar_os).Length > 0)
            {
                model1.title = "catar_os";
                model1.result = model.catar_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.diabe_ret_od is null ? "" : model.diabe_ret_od).Length > 0)
            {
                model1.title = "diabe_ret_od";
                model1.result = model.diabe_ret_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.DIabete_ret_os is null ? "" : model.DIabete_ret_os).Length > 0)
            {
                model1.title = "DIabete_ret_os";
                model1.result = model.DIabete_ret_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.hpt_od is null ? "" : model.hpt_od).Length > 0)
            {
                model1.title = "hpt_od";
                model1.result = model.hpt_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.hpt_os is null ? "" : model.hpt_os).Length > 0)
            {
                model1.title = "hpt_os";
                model1.result = model.hpt_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.poster_od is null ? "" : model.poster_od).Length > 0)
            {
                model1.title = "poster_od";
                model1.result = model.poster_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.poster_os is null ? "" : model.poster_os).Length > 0)
            {
                model1.title = "poster_os";
                model1.result = model.poster_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.uveal_od is null ? "" : model.uveal_od).Length > 0)
            {
                model1.title = "uveal_od";
                model1.result = model.uveal_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.uveal_os is null ? "" : model.uveal_os).Length > 0)
            {
                model1.title = "uveal_os";
                model1.result = model.uveal_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.pthisis_od is null ? "" : model.pthisis_od).Length > 0)
            {
                model1.title = "pthisis_od";
                model1.result = model.pthisis_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.pthsis_os is null ? "" : model.pthsis_os).Length > 0)
            {
                model1.title = "pthsis_os";
                model1.result = model.pthsis_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterior_od_text is null ? "" : model.anterior_od_text).Length > 0)
            {
                model1.title = "anterior_od_text";
                model1.result = model.anterior_od_text;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.anterior_os_text is null ? "" : model.anterior_os_text).Length > 0)
            {
                model1.title = "anterior_os_text";
                model1.result = model.anterior_os_text;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.referror_od is null ? "" : model.referror_od).Length > 0)
            {
                model1.title = "referror_od";
                model1.result = model.referror_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }

            if ((model.referror_os is null ? "" : model.referror_os).Length > 0)
            {
                model1.title = "referror_os";
                model1.result = model.referror_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model1);
            }
        }

        [HttpPost]
        [Route("api/OcularInvestigation")]
        public IHttpActionResult Post(OcularInvestigationInsert_dt model)
        {
            try{
            
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigationInsert", model);
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
        [Route("api/OcularInvestigation/Update")]
        public IHttpActionResult Update(OcularInvestigationUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigationUpdate", model);
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
        [Route("api/OcularInvestigation")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularInvestigationSelect_dt>
                ("sp_ocular_investigationSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/OcularInvestigation/delete")]
        public IHttpActionResult Delete(OcularInvestigationDelete_dt model)
        {
            try
            {

            
        
            DapperHelper.ExecuteStoredProcedure("sp_ocular_investigationDelete", model);
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
        [Route("api/OcularInvestigationAll")]
        public IHttpActionResult SelectAll(string mrdno)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailSelect_dt>
            ("sp_ocular_investigation_DetailSelect", new { mrdno = mrdno }).ToList();
            OcularInvestigationInsertAll_dt model_new = new OcularInvestigationInsertAll_dt();
            foreach (var x in list)
            {
                model_new.mrdno = x.mrdno;
                //  model_new.hospid = x.hospid;
                model_new.ddate = x.ddate;

                if (x.title == "at_od_tick")
                {
                    model_new.at_od_tick = x.tick_mark;
                }

                if (x.title == "at_os_tick")
                {
                    model_new.at_os_tick = x.tick_mark;
                }

                if (x.title == "at_od")
                {
                    model_new.at_od = x.result;
                }

                if (x.title == "at_os")
                {
                    model_new.at_os = x.result;
                }

                if (x.title == "at_mh_od_tick")
                {
                    model_new.at_mh_od_tick = x.tick_mark;
                }

                if (x.title == "at_mh_os_tick")
                {
                    model_new.at_mh_os_tick = x.tick_mark;
                }

                if (x.title == "at_pc_od_tick")
                {
                    model_new.at_pc_od_tick = x.tick_mark;
                }

                if (x.title == "at_pc_os_tick")
                {
                    model_new.at_pc_os_tick = x.tick_mark;
                }

                if (x.title == "at_nf_od_tick")
                {
                    model_new.at_nf_od_tick = x.tick_mark;
                }

                if (x.title == "at_nf_os_tick")
                {
                    model_new.at_nf_os_tick = x.tick_mark;
                }

                if (x.title == "at_other_od_tick")
                {
                    model_new.at_other_od_tick = x.tick_mark;
                }

                if (x.title == "at_other_os_tick")
                {
                    model_new.at_other_os_tick = x.tick_mark;
                }

                if (x.title == "at_other_od")
                {
                    model_new.at_other_od = x.result;
                }

                if (x.title == "at_other_os")
                {
                    model_new.at_other_os = x.result;
                }

                if (x.title == "at_erpretation_od_tick")
                {
                    model_new.at_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "at_erpretation_os_tick")
                {
                    model_new.at_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "at_erpretation_od")
                {
                    model_new.at_erpretation_od = x.result;
                }

                if (x.title == "at_erpretation_os")
                {
                    model_new.at_erpretation_os = x.result;
                }

                if (x.title == "gonioscopy_od_tick")
                {
                    model_new.gonioscopy_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_os_tick")
                {
                    model_new.gonioscopy_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_od_open_tick")
                {
                    model_new.gonioscopy_od_open_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_od_close_tick")
                {
                    model_new.gonioscopy_od_close_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_od_occludable_tick")
                {
                    model_new.gonioscopy_od_occludable_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_od_nonoccludable_tick")
                {
                    model_new.gonioscopy_od_nonoccludable_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_os_open_tick")
                {
                    model_new.gonioscopy_os_open_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_os_close_tick")
                {
                    model_new.gonioscopy_os_close_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_os_occludable_tick")
                {
                    model_new.gonioscopy_os_occludable_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_os_nonoccludable_tick")
                {
                    model_new.gonioscopy_os_nonoccludable_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_mh_od_tick")
                {
                    model_new.gonioscopy_mh_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_mh_os_tick")
                {
                    model_new.gonioscopy_mh_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_pc_od_tick")
                {
                    model_new.gonioscopy_pc_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_pc_os_tick")
                {
                    model_new.gonioscopy_pc_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_nf_od_tick")
                {
                    model_new.gonioscopy_nf_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_nf_os_tick")
                {
                    model_new.gonioscopy_nf_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_other_od_tick")
                {
                    model_new.gonioscopy_other_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_other_os_tick")
                {
                    model_new.gonioscopy_other_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_other_od")
                {
                    model_new.gonioscopy_other_od = x.result;
                }

                if (x.title == "gonioscopy_other_os")
                {
                    model_new.gonioscopy_other_os = x.result;
                }

                if (x.title == "gonioscopy_erpretation_od_tick")
                {
                    model_new.gonioscopy_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_erpretation_os_tick")
                {
                    model_new.gonioscopy_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "gonioscopy_erpretation_od")
                {
                    model_new.gonioscopy_erpretation_od = x.result;
                }

                if (x.title == "gonioscopy_erpretation_os")
                {
                    model_new.gonioscopy_erpretation_os = x.result;
                }

                if (x.title == "normal_od_tick")
                {
                    model_new.normal_od_tick = x.tick_mark;
                }

                if (x.title == "refractive_error_od_tick")
                {
                    // model_new.refractive_error_od_tick = x.result;
                    model_new.refractive_error_od_tick = x.tick_mark;

                }

                if (x.title == "presbyopia_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.presbyopia_od_tick = x.tick_mark;

                }

                if (x.title == "cataract_untreated_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.cataract_untreated_od_tick = x.tick_mark;

                }

              

                if (x.title == "phthisis_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.phthisis_od_tick = x.tick_mark;

                }
            

                if (x.title == "glaucoma_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.glaucoma_od_tick = x.tick_mark;

                }

                if (x.title == "diabetic_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.diabetic_od_tick = x.tick_mark;

                }

               
                if (x.title == "other_posterior_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.other_posterior_od_tick = x.tick_mark;

                }
                
                if (x.title == "others_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.others_od_tick = x.tick_mark;

                }
                if (x.title == "others_od")
                {
                    model_new.others_od = x.result;
                    // model_new.diabetic_od_tick = x.others_od;
                    //return Ok(model_new);
                }
                if (x.title == "normal_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.normal_os_tick = x.tick_mark;
                    //return Ok(model_new);
                }
                if (x.title == "refractive_error_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.refractive_error_os_tick = x.tick_mark;

                }
                if (x.title == "presbyopia_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.presbyopia_os_tick = x.tick_mark;

                }
                if (x.title == "cataract_untreated_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.cataract_untreated_os_tick = x.tick_mark;

                }
               

                if (x.title == "phthisis_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.phthisis_os_tick = x.tick_mark;

                }

                

                if (x.title == "glaucoma_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.glaucoma_os_tick = x.tick_mark;

                }

                if (x.title == "diabetic_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.diabetic_os_tick = x.tick_mark;
                }

              

                if (x.title == "other_posterior_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.other_posterior_os_tick = x.tick_mark;
                }

                
                if (x.title == "others_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.others_os_tick = x.tick_mark;
                }

                if (x.title == "others_os")
                {
                    model_new.others_os = x.result;
                    // model_new.others_os_tick = x.tick_mark;
                }

                if (x.title == "medical_treatment_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.medical_treatment_od_tick = x.tick_mark;
                    //  return Ok(model_new);
                }

                if (x.title == "medical_treatment_od")
                {
                    model_new.medical_treatment_od = x.result;
                    //  model_new.medical_treatment_od = x.tick_mark;
                    //return Ok(model_new);
                }

                if (x.title == "surgrical_treatment_od_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.surgrical_treatment_od_tick = x.tick_mark;
                    //return Ok(model_new);
                }

                if (x.title == "surgrical_treatment_od")
                {
                    model_new.surgrical_treatment_od = x.result;
                    //   model_new.surgrical_treatment_od = x.tick_mark;
                    //  return Ok(model_new);
                }

                if (x.title == "medical_treatment_os_tick")
                {
                    //model_new.medical_treatment_os_tick = x.result;
                    model_new.medical_treatment_os_tick = x.tick_mark;
                    // return Ok(model_new);
                }

                if (x.title == "medical_treatment_os")
                {
                    model_new.medical_treatment_os = x.result;
                    // model_new.medical_treatment_os = x.tick_mark;
                }

                if (x.title == "surgrical_treatment_os_tick")
                {
                    //model_new.anterioracdepth_od = x.result;
                    model_new.surgrical_treatment_os_tick = x.tick_mark;
                }

                if (x.title == "surgrical_treatment_os")
                {
                    model_new.surgrical_treatment_os = x.result;
                    // model_new.surgrical_treatment_os = x.tick_mark;

                }

                if (x.title == "followup_od")
                {
                    model_new.anterioracdepth_od = x.result;
                }

                if (x.title == "followup_os")
                {
                    model_new.followup_os = x.result;

                }

                if (x.title == "followup_od_tick")
                {
                    model_new.followup_od_tick = x.tick_mark;
                }

                if (x.title == "followup_os_tick")
                {
                    model_new.followup_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_od_tick")
                {
                    model_new.fundus_od_tick = x.tick_mark;
                }

                if (x.title == "fundus_mh_od_tick")
                {
                    model_new.fundus_mh_od_tick = x.tick_mark;
                }

                if (x.title == "fundus_pc_od_tick")
                {
                    model_new.fundus_pc_od_tick = x.tick_mark;
                }

                if (x.title == "fundus_nf_od_tick")
                {
                    model_new.fundus_nf_od_tick = x.tick_mark;
                }

                if (x.title == "fundus_others_od_tick")
                {
                    model_new.fundus_others_od_tick = x.tick_mark;
                }

                if (x.title == "fundus_others_od")
                {
                    model_new.fundus_others_od = x.result;
                }

                if (x.title == "fundus_os_tick")
                {
                    model_new.fundus_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_mh_os_tick")
                {
                    model_new.fundus_mh_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_pc_os_tick")
                {
                    model_new.fundus_pc_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_nf_os_tick")
                {
                    model_new.fundus_nf_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_others_os_tick")
                {
                    model_new.fundus_others_os_tick = x.tick_mark;
                }

                if (x.title == "fundus_others_os")
                {
                    model_new.fundus_others_os = x.result;
                }

                if (x.title == "funudus_erpretation_od_tick")
                {
                    model_new.funudus_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "funudus_erpretation_od")
                {
                    model_new.funudus_erpretation_od = x.result;
                }

                if (x.title == "funudus_erpretation_os_tick")
                {
                    model_new.funudus_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "funudus_erpretation_os")
                {
                    model_new.funudus_erpretation_os = x.result;
                }

                if (x.title == "disc_od_tick")
                {
                    model_new.disc_od_tick = x.tick_mark;
                }

                if (x.title == "disc_mh_od_tick")
                {
                    model_new.disc_mh_od_tick = x.tick_mark;
                }

                if (x.title == "disc_pc_od_tick")
                {
                    model_new.disc_pc_od_tick = x.tick_mark;
                }

                if (x.title == "disc_nf_od_tick")
                {
                    model_new.disc_nf_od_tick = x.tick_mark;
                }

                if (x.title == "disc_others_od_tick")
                {
                    model_new.disc_others_od_tick = x.tick_mark;
                }

                if (x.title == "disc_others_od")
                {
                    model_new.disc_others_od = x.result;
                }

                if (x.title == "disc_os_tick")
                {
                    model_new.disc_os_tick = x.tick_mark;
                }

                if (x.title == "disc_mh_os_tick")
                {
                    model_new.disc_mh_os_tick = x.tick_mark;
                }

                if (x.title == "disc_pc_os_tick")
                {
                    model_new.disc_pc_os_tick = x.tick_mark;
                }

                if (x.title == "disc_nf_os_tick")
                {
                    model_new.disc_nf_os_tick = x.tick_mark;
                }

                if (x.title == "disc_others_os_tick")
                {
                    model_new.disc_others_os_tick = x.tick_mark;
                }

                if (x.title == "disc_others_os")
                {
                    model_new.disc_others_os = x.result;
                }

                if (x.title == "disc_erpretation_od_tick")
                {
                    model_new.disc_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "disc_erpretation_od")
                {
                    model_new.disc_erpretation_od = x.result;
                }

                if (x.title == "disc_erpretation_os_tick")
                {
                    model_new.disc_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "disc_erpretation_os")
                {
                    model_new.disc_erpretation_os = x.result;
                }

                if (x.title == "post_od_tick")
                {
                    model_new.post_od_tick = x.tick_mark;
                }

                if (x.title == "post_sga_od")
                {
                    model_new.post_sga_od = x.result;
                }

                if (x.title == "post_it1_od")
                {
                    model_new.post_it1_od = x.result;
                }

                if (x.title == "post_it2_od")
                {
                    model_new.post_it2_od = x.result;
                }

                if (x.title == "post_ac_od")
                {
                    model_new.post_ac_od = x.result;
                }

                if (x.title == "post_acw_od")
                {
                    model_new.post_acw_od = x.result;
                }

                if (x.title == "post_lv_od")
                {
                    model_new.post_lv_od = x.result;
                }

                if (x.title == "post_ara_od")
                {
                    model_new.post_ara_od = x.result;
                }

                if (x.title == "post_aod500_od")
                {
                    model_new.post_aod500_od = x.result;
                }

                if (x.title == "post_aod7500_od")
                {
                    model_new.post_aod7500_od = x.result;
                }

                if (x.title == "post_tisa_od")
                {
                    model_new.post_tisa_od = x.result;
                }

                if (x.title == "post_tia_od")
                {
                    model_new.post_tia_od = x.result;
                }

                if (x.title == "post_os_tick")
                {
                    model_new.post_os_tick = x.tick_mark;
                }

                if (x.title == "post_sga_os")
                {
                    model_new.post_sga_os = x.result;
                }

                if (x.title == "post_it1_os")
                {
                    model_new.post_it1_os = x.result;
                }

                if (x.title == "post_it2_os")
                {
                    model_new.post_it2_os = x.result;
                }

                if (x.title == "post_ac_os")
                {
                    model_new.post_ac_os = x.result;
                }

                if (x.title == "post_acw_os")
                {
                    model_new.post_acw_os = x.result;
                }

                if (x.title == "post_lv_os")
                {
                    model_new.post_lv_os = x.result;
                }

                if (x.title == "post_ara_os")
                {
                    model_new.post_ara_os = x.result;
                }

                if (x.title == "post_aod500_os")
                {
                    model_new.post_aod500_os = x.result;
                }

                if (x.title == "post_aod7500_os")
                {
                    model_new.post_aod7500_os = x.result;
                }

                if (x.title == "post_tisa_os")
                {
                    model_new.post_tisa_os = x.result;
                }


                if (x.title == "post_tia_os")
                {
                    model_new.post_tia_os = x.result;
                }

                if (x.title == "post_mh_od_tick")
                {
                    model_new.post_mh_od_tick = x.tick_mark;
                }

                if (x.title == "post_pc_od_tick")
                {
                    model_new.post_pc_od_tick = x.tick_mark;
                }

                if (x.title == "post_nf_od_tick")
                {
                    model_new.post_nf_od_tick = x.tick_mark;
                }

                if (x.title == "post_others_od_tick")
                {
                    model_new.post_others_od_tick = x.tick_mark;
                }

                if (x.title == "post_others_od")
                {
                    model_new.post_others_od = x.result;
                }

                if (x.title == "post_mh_os_tick")
                {
                    model_new.post_mh_os_tick = x.tick_mark;
                }

                if (x.title == "post_pc_os_tick")
                {
                    model_new.post_pc_os_tick = x.tick_mark;
                }

                if (x.title == "post_nf_os_tick")
                {
                    model_new.post_nf_os_tick = x.tick_mark;
                }

                if (x.title == "post_others_os_tick")
                {
                    model_new.post_others_os_tick = x.tick_mark;
                }

                if (x.title == "post_others_os")
                {
                    model_new.post_others_os = x.result;
                }

                if (x.title == "post_erpretation_od_tick")
                {
                    model_new.post_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "post_erpretation_od")
                {
                    model_new.post_erpretation_od = x.result;
                }

                if (x.title == "post_erpretation_os_tick")
                {
                    model_new.post_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "post_erpretation_os")
                {
                    model_new.post_erpretation_os = x.result;
                }

                if (x.title == "fdp_od_tick")
                {
                    model_new.fdp_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_mh_od_tick")
                {
                    model_new.fdp_mh_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_pc_od_tick")
                {
                    model_new.fdp_pc_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_nf_od_tick")
                {
                    model_new.fdp_nf_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_others_od_tick")
                {
                    model_new.fdp_others_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_others_od")
                {
                    model_new.fdp_others_od = x.result;
                }

                if (x.title == "fdp_os_tick")
                {
                    model_new.fdp_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_mh_os_tick")
                {
                    model_new.fdp_mh_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_pc_os_tick")
                {
                    model_new.fdp_pc_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_nf_os_tick")
                {
                    model_new.fdp_nf_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_others_os_tick")
                {
                    model_new.fdp_others_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_others_os")
                {
                    model_new.fdp_others_os = x.result;
                }

                if (x.title == "fdp_erpretation_od_tick")
                {
                    model_new.fdp_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "fdp_erpretation_od")
                {
                    model_new.fdp_erpretation_od = x.result;
                }

                if (x.title == "fdp_erpretation_os_tick")
                {
                    model_new.fdp_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "fdp_erpretation_os")
                {
                    model_new.fdp_erpretation_os = x.result;
                }

                if (x.title == "anterior_segment_tick")
                {
                    model_new.anterior_segment_tick = x.tick_mark;
                }

                if (x.title == "ct_od_tick")
                {
                    model_new.ct_od_tick = x.tick_mark;
                }

                if (x.title == "ct_os_tick")
                {
                    model_new.ct_os_tick = x.tick_mark;
                }

                if (x.title == "cct_od")
                {
                    model_new.cct_od = x.result;
                }

                if (x.title == "k1_od")
                {
                    model_new.k1_od = x.result;
                }

                if (x.title == "k2_od")
                {
                    model_new.k2_od = x.result;
                }

                if (x.title == "cct_os")
                {
                    model_new.cct_os = x.result;
                }

                if (x.title == "k1_os")
                {
                    model_new.k1_os = x.result;
                }

                if (x.title == "k2_os")
                {
                    model_new.k2_os = x.result;
                }

                if (x.title == "ct_mh_od_tick")
                {
                    model_new.ct_mh_od_tick = x.tick_mark;
                }

                if (x.title == "ct_mh_os_tick")
                {
                    model_new.ct_mh_os_tick = x.tick_mark;
                }

                if (x.title == "ct_pc_od_tick")
                {
                    model_new.ct_pc_od_tick = x.tick_mark;
                }
                if (x.title == "ct_pc_os_tick")
                {
                    model_new.ct_pc_os_tick = x.tick_mark;
                }

                if (x.title == "ct_nf_od_tick")
                {
                    model_new.ct_nf_od_tick = x.tick_mark;
                }

                if (x.title == "ct_nf_os_tick")
                {
                    model_new.ct_nf_os_tick = x.tick_mark;
                }

                if (x.title == "ct_other_od_tick")
                {
                    model_new.ct_other_od_tick = x.tick_mark;
                }

                if (x.title == "ct_other_os_tick")
                {
                    model_new.ct_other_os_tick = x.tick_mark;
                }

                if (x.title == "ct_other_od")
                {
                    model_new.ct_other_od = x.result;
                }
                if (x.title == "ct_other_os")
                {
                    model_new.ct_other_os = x.result;
                }

                if (x.title == "ct_erpretation_od_tick")
                {
                    model_new.ct_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "ct_erpretation_os_tick")
                {
                    model_new.ct_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "ct_erpretation_od")
                {
                    model_new.ct_erpretation_od = x.result;
                }

                if (x.title == "ct_erpretation_os")
                {
                    model_new.ct_erpretation_os = x.result;
                }

                if (x.title == "ascan_od_tick")
                {
                    model_new.ascan_od_tick = x.tick_mark;
                }
                if (x.title == "ascan_os_tick")
                {
                    model_new.ascan_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_acp_od")
                {
                    model_new.ascan_acp_od = x.result;
                }

                if (x.title == "ascan_al_od")
                {
                    model_new.ascan_al_od = x.result;
                }

                if (x.title == "ascan_iolpower_od")
                {
                    model_new.ascan_iolpower_od = x.result;
                }

                if (x.title == "ascan_lt_od")
                {
                    model_new.ascan_lt_od = x.result;
                }

                if (x.title == "ascan_acp_os")
                {
                    model_new.ascan_acp_os = x.result;
                }
                if (x.title == "ascan_al_os")
                {
                    model_new.ascan_al_os = x.result;
                }

                if (x.title == "ascan_iolpower_os")
                {
                    model_new.ascan_iolpower_os = x.result;
                }

                if (x.title == "ascan_lt_os")
                {
                    model_new.ascan_lt_os = x.result;
                }

                if (x.title == "ascan_mh_od_tick")
                {
                    model_new.ascan_mh_od_tick = x.tick_mark;
                }

                if (x.title == "ascan_mh_os_tick")
                {
                    model_new.ascan_mh_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_pc_od_tick")
                {
                    model_new.ascan_pc_od_tick = x.tick_mark;
                }

                if (x.title == "ascan_pc_os_tick")
                {
                    model_new.ascan_pc_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_nf_od_tick")
                {
                    model_new.ascan_nf_od_tick = x.tick_mark;
                }

                if (x.title == "ascan_nf_os_tick")
                {
                    model_new.ascan_nf_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_other_od_tick")
                {
                    model_new.ascan_other_od_tick = x.tick_mark;
                }

                if (x.title == "ascan_other_os_tick")
                {
                    model_new.ascan_other_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_other_od")
                {
                    model_new.ascan_other_od = x.result;
                }

                if (x.title == "ascan_other_os")
                {
                    model_new.ascan_other_os = x.result;
                }

                if (x.title == "ascan_erpretation_od_tick")
                {
                    model_new.ascan_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "ascan_erpretation_os_tick")
                {
                    model_new.ascan_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "ascan_erpretation_od")
                {
                    model_new.ascan_erpretation_od = x.result;
                }

                if (x.title == "ascan_erpretation_os")
                {
                    model_new.ascan_erpretation_os = x.result;
                }

                if (x.title == "anterioroct_od_tick")
                {
                    model_new.anterioroct_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_os_tick")
                {
                    model_new.anterioroct_os_tick = x.tick_mark;
                }

                if (x.title == "anteriorsga_od")
                {
                    model_new.anteriorsga_od = x.result;
                }

                if (x.title == "anteriorit1_od")
                {
                    model_new.anteriorit1_od = x.result;
                }

                if (x.title == "anteriorit2_od")
                {
                    model_new.anteriorit2_od = x.result;
                }

                if (x.title == "anterioracdepth_od")
                {
                    model_new.anterioracdepth_od = x.result;
                }

                if (x.title == "anterioracwidth_od")
                {
                    model_new.anterioracwidth_od = x.result;
                }

                if (x.title == "anteriorlv_od")
                {
                    model_new.anteriorlv_od = x.result;
                }

                if (x.title == "anteriorara_od")
                {
                    model_new.anteriorara_od = x.result;
                }

                if (x.title == "anterioraod500_od")
                {
                    model_new.anterioraod500_od = x.result;
                }

                if (x.title == "anterioraod750_od")
                {
                    model_new.anterioraod750_od = x.result;
                }

                if (x.title == "anteriortisa_od")
                {
                    model_new.anteriortisa_od = x.result;
                }

                if (x.title == "anteriortia_od")
                {
                    model_new.anteriortia_od = x.result;
                }

                if (x.title == "anteriorsga_os")
                {
                    model_new.anteriorsga_os = x.result;
                }

                if (x.title == "anteriorit1_os")
                {
                    model_new.anteriorit1_os = x.result;
                }

                if (x.title == "anteriorit2_os")
                {
                    model_new.anteriorit2_os = x.result;
                }

                if (x.title == "anterioracdepth_os")
                {
                    model_new.anterioracdepth_os = x.result;
                }

                if (x.title == "anterioracwidth_os")
                {
                    model_new.anterioracwidth_os = x.result;
                }

                if (x.title == "anteriorlv_os")
                {
                    model_new.anteriorlv_os = x.result;
                }

                if (x.title == "anteriorara_os")
                {
                    model_new.anteriorara_os = x.result;
                }

                if (x.title == "anterioraod500_os")
                {
                    model_new.anterioraod500_os = x.result;
                }

                if (x.title == "anterioraod750_os")
                {
                    model_new.anterioraod750_os = x.result;
                }

                if (x.title == "anteriortisa_os")
                {
                    model_new.anteriortisa_os = x.result;
                }

                if (x.title == "anterior_tia_os")
                {
                    model_new.anterior_tia_os = x.result;
                }

                if (x.title == "anterioroct_mh_od_tick")
                {
                    model_new.anterioroct_mh_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_mh_os_tick")
                {
                    model_new.anterioroct_mh_os_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_pc_od_tick")
                {
                    model_new.anterioroct_pc_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_pc_os_tick")
                {
                    model_new.anterioroct_pc_os_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_nf_od_tick")
                {
                    model_new.anterioroct_nf_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_nf_os_tick")
                {
                    model_new.anterioroct_nf_os_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_other_od_tick")
                {
                    model_new.anterioroct_other_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_other_os_tick")
                {
                    model_new.anterioroct_other_os_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_other_od")
                {
                    model_new.anterioroct_other_od = x.result;
                }

                if (x.title == "anterioroct_other_os")
                {
                    model_new.anterioroct_other_os = x.result;
                }

                if (x.title == "anterioroct_erpretation_od_tick")
                {
                    model_new.anterioroct_erpretation_od_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_erpretation_os_tick")
                {
                    model_new.anterioroct_erpretation_os_tick = x.tick_mark;
                }

                if (x.title == "anterioroct_erpretation_od")
                {
                    model_new.anterioroct_erpretation_od = x.result;
                }

                if (x.title == "anterioroct_erpretation_os")
                {
                    model_new.anterioroct_erpretation_os = x.result;
                }

                /* if (x.title == "posterior_segment_tick")
                 {
                     model_new.posterior_segment_tick = x.tick_mark;
                 }*/                  

                if (x.title == "laser_treatment_od_tick")
                {
                    model_new.laser_treatment_od_tick = x.tick_mark;
                }

                if (x.title == "laser_treatment_od")
                {
                    model_new.laser_treatment_od = x.result;
                }

                if (x.title == "laser_treatment_os_tick")
                {
                    model_new.laser_treatment_os_tick = x.tick_mark;
                }

                if (x.title == "laser_treatment_os")
                {
                    model_new.laser_treatment_os = x.result;
                }

                if (x.title == "subspeciality_referal_od_tick")
                {
                    model_new.subspeciality_referal_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_referal_os_tick")
                {
                    model_new.subspeciality_referal_os_tick = x.tick_mark;
                }

                if (x.title == "subspec_corena_od_tick")
                {
                    model_new.subspec_corena_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_retina_od_tick")
                {
                    model_new.subspeciality_retina_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_glaucoma_od_tick")
                {
                    model_new.subspeciality_glaucoma_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_opal_od_tick")
                {
                    model_new.subspeciality_opal_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_referr_od_tick")
                {
                    model_new.subspeciality_referr_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_squint_od_tick")
                {
                    model_new.subspeciality_squint_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_uvea_od_tick")
                {
                    model_new.subspeciality_uvea_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_neuropthalmo_od_tick")
                {
                    model_new.subspeciality_neuropthalmo_od_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_none_od_tick")
                {
                    model_new.subspeciality_none_od_tick = x.tick_mark;
                }

                if (x.title == "subspec_corena_os_tick")
                {
                    model_new.subspec_corena_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_retina_os_tick")
                {
                    model_new.subspeciality_retina_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_glaucoma_os_tick")
                {
                    model_new.subspeciality_glaucoma_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_opal_os_tick")
                {
                    model_new.subspeciality_opal_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_referr_os_tick")
                {
                    model_new.subspeciality_referr_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_squint_os_tick")
                {
                    model_new.subspeciality_squint_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_uvea_os_tick")
                {
                    model_new.subspeciality_uvea_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_neuropthalmo_os_tick")
                {
                    model_new.subspeciality_neuropthalmo_os_tick = x.tick_mark;
                }

                if (x.title == "subspeciality_none_os_tick")
                {
                    model_new.subspeciality_none_os_tick = x.tick_mark;
                }

                if (x.title == "visual_field_od_tick")
                {
                    model_new.visual_field_od_tick = x.tick_mark;
                }

                if (x.title == "visual_field_interpret_od_tick")
                {
                    model_new.visual_field_interpret_od_tick = x.tick_mark;
                }

                if (x.title == "visual_field_interpret_od")
                {
                    model_new.visual_field_interpret_od = x.result;
                }

                if (x.title == "visual_field_os_tick")
                {
                    model_new.visual_field_os_tick = x.tick_mark;
                }

                if (x.title == "visual_field_interpret_os_tick")
                {
                    model_new.visual_field_interpret_os_tick = x.tick_mark;
                }

                if (x.title == "visual_field_interpret_os")
                {
                    model_new.visual_field_interpret_os = x.result;
                }

                if (x.title == "treatment_od_tick")
                {
                    model_new.treatment_od_tick = x.tick_mark;
                }

                if (x.title == "treatment_os_tick")
                {
                    model_new.treatment_os_tick = x.tick_mark;
                }

                if (x.title == "schirmer_od_tick")
                {
                    model_new.schirmer_od_tick = x.tick_mark;
                }

                if (x.title == "schirmer_od")
                {
                    model_new.schirmer_od = x.result;
                }

                if (x.title == "schirmer_os_tick")
                {
                    model_new.schirmer_os_tick = x.tick_mark;
                }

                if (x.title == "schirmer_os")
                {
                    model_new.schirmer_os = x.result;
                }

                if (x.title == "tx_plan")
                {
                    model_new.tx_plan = x.result;
                }

                if (x.title == "conjunc_od_tick")
                {
                    model_new.conjunc_od_tick = x.tick_mark;
                }

                if (x.title == "conjunc_od")
                {
                    model_new.conjunc_od = x.result;
                }

                if (x.title == "conjunc_os_tick")
                {
                    model_new.conjunc_os_tick = x.tick_mark;
                }

                if (x.title == "conjunc_os")
                {
                    model_new.conjunc_os = x.result;
                }

                if (x.title == "glaucoma_od")
                {
                    model_new.glaucoma_od = x.result;
                }

                if (x.title == "glaucoma_os")
                {
                    model_new.glaucoma_os = x.result;
                }

                if (x.title == "catar_od")
                {
                    model_new.catar_od = x.result;
                }

                if (x.title == "catar_os")
                {
                    model_new.catar_os = x.result;
                }

                if (x.title == "diabe_ret_od")
                {
                    model_new.diabe_ret_od = x.result;
                }

                if (x.title == "DIabete_ret_os")
                {
                    model_new.DIabete_ret_os = x.result;
                }

                if (x.title == "hpt_od_tick")
                {
                    model_new.hpt_od_tick = x.tick_mark;
                }

                if (x.title == "hpt_od")
                {
                    model_new.hpt_od = x.result;
                }

                if (x.title == "hpt_os_tick")
                {
                    model_new.hpt_os_tick = x.tick_mark;
                }

                if (x.title == "hpt_os")
                {
                    model_new.hpt_os = x.result;
                }

                if (x.title == "poster_od")
                {
                    model_new.poster_od = x.result;
                }

                if (x.title == "poster_os")
                {
                    model_new.poster_os = x.result;
                }

                if (x.title == "uveal_od")
                {
                    model_new.uveal_od = x.result;
                }

                if (x.title == "uveal_os")
                {
                    model_new.uveal_os = x.result;
                }

                if (x.title == "pthisis_od")
                {
                    model_new.pthisis_od = x.result;
                }

                if (x.title == "pthsis_os")
                {
                    model_new.pthsis_os = x.result;
                }

                if (x.title == "anterior_od_tick")
                {
                    model_new.anterior_od_tick = x.tick_mark;
                }

                if (x.title == "anterior_os_tick")
                {
                    model_new.anterior_os_tick = x.tick_mark;
                }

                if (x.title == "anterior_od_text")
                {
                    model_new.anterior_od_text = x.result;
                }

                if (x.title == "anterior_os_text")
                {
                    model_new.anterior_os_text = x.result;
                }

                if (x.title == "referror_od")
                {
                    model_new.referror_od = x.result;
                }

                if (x.title == "referror_os")
                {
                    model_new.referror_os = x.result;
                }

                if (x.title == "uveal_od_tick")
                {
                    model_new.uveal_od_tick = x.tick_mark;
                }

                if (x.title == "uveal_os_tick")
                {
                    model_new.uveal_os_tick = x.tick_mark;
                }

                if (x.title == "anteriorint_od_tick")
                {
                    model_new.anteriorint_od_tick = x.tick_mark;
                }

                if (x.title == "anteriorint_os_tick")
                {
                    model_new.anteriorint_os_tick = x.tick_mark;
                }


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


