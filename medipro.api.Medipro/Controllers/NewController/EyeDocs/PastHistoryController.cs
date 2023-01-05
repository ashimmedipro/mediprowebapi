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
    public class PastHistoryController : ApiController
    {
        [HttpPost]
        [Route("api/PastEyeHistoryAll")]
        public IHttpActionResult PostAll(Past_Eye_HistoryAll_dt model)
        {
            try
            {

            
            PastHistoryDetails_Insert_dt model1 = new PastHistoryDetails_Insert_dt();
            InsertPastEye(model, model1);

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
        [Route("api/PastEyeHistoryAll/Update")]
        public IHttpActionResult Update(Past_Eye_HistoryAll_dt model)
        {
            try
            {

            
            PastHistoryDetails_Delete_dt model_new = new PastHistoryDetails_Delete_dt();
            model_new.mrdno = model.mrdno;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsDelete", model_new);
            PastHistoryDetails_Insert_dt model1 = new PastHistoryDetails_Insert_dt();
            InsertPastEye(model, model1);
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

        private static void InsertPastEye(Past_Eye_HistoryAll_dt model, PastHistoryDetails_Insert_dt model1)
        {
            model1.mrdno = model.mrdno;
            model1.hospid = model.hospid;
            model1.ddate = model.ddate;
            model1.title = "eyeproblem_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_glaucoma_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_glaucoma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_cataract_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_cataract_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_retina_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_retina_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_squint_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_squint_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_corneal_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_corneal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_opalrelated_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_opalrelated_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_uveal_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_uveal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_neuro_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_neuro_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_glaucoma_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_glaucoma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_cataract_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_cataract_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_retina_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_retina_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_squint_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_squint_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_corneal_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_corneal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_opalrelated_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_opalrelated_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_uveal_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_uveal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_neuro_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_neuro_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "eyeproblem_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.eyeproblem_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_od_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_blunt_od_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_blunt_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_penetrating_od_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_penetrating_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_os_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_blunt_os_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_blunt_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_penetrating_os_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_penetrating_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "trauma_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.trauma_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_od_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_medical_od_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_medical_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_surgical_od_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_surgical_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_donotknow_od_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_donotknow_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_os_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_medical_os_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_medical_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_surgical_os_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_surgical_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "treatment_donotknow_os_tick";
            model1.result = "";
            model1.tick_mark = model.treatment_donotknow_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_glaucoma_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_glaucoma_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_cataract_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_cataract_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_retina_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_retina_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_squint_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_squint_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_corneal_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_corneal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_opalrela_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_opalrela_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_uveal_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_uveal_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_neuroopthamalic_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_neuroopthamalic_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.surg_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_glaucoma_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_glaucoma_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_cataract_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_cataract_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_retina_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_retina_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_squint_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_squint_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_corneal_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_corneal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_opalrela_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_opalrela_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_uveal_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_uveal_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_neuroopthamalic_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_neuroopthamalic_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "surg_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.surg_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_hyper_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_hyper_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_diab_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_diab_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_astha_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_astha_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_cardc_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_cardc_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_thy_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_thy_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_cereb_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_cereb_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_hyperlipi_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_hyperlipi_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_kidney_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_kidney_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_anemia_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_anemia_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_eyeprob_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_eyeprob_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_rheu_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_rheu_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_inf_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_inf_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.systill_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_hyper_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_hyper_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_diab_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_diab_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_astha_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_astha_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_cardc_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_cardc_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_thy_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_thy_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_cereb_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_cereb_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_hyperlipi_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_hyperlipi_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_kidney_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_kidney_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_anemia_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_anemia_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_eyeprob_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_eyeprob_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_rheu_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_rheu_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_inf_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_inf_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "systill_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.systill_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_oral_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_oral_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_injectsys_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_injectsys_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_injectperi_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_injectperi_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_eyedrop_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_eyedrop_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_skincr_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_skincr_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_others_od_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_others_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_oral_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_oral_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_injectsys_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_injectsys_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_injectperi_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_injectperi_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_eyedrop_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_eyedrop_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_skincr_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_skincr_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "hisofstre_others_os_tick";
            model1.result = "";
            model1.tick_mark = model.hisofstre_others_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            if (model.famhis_od_tick == 0)
            {
                model1.title = "famhis_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_od_tick == 1)
            {
                model1.title = "famhis_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            if (model.famhis_glaucoma_od_tick == 0)
            {
                model1.title = "famhis_glaucoma_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_glaucoma_od_tick == 1)
            {
                model1.title = "famhis_glaucoma_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_glaucoma_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_cataract_od_tick == 0)
            {
                model1.title = "famhis_cataract_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_cataract_od_tick == 1)
            {
                model1.title = "famhis_cataract_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_cataract_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_retina_od_tick == 0)
            {
                model1.title = "famhis_retina_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_retina_od_tick == 1)
            {
                model1.title = "famhis_retina_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_retina_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_squint_od_tick == 0)
            {
                model1.title = "famhis_squint_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_squint_od_tick == 1)
            {
                model1.title = "famhis_squint_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_squint_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_corneal_od_tick == 0)
            {
                model1.title = "famhis_corneal_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_corneal_od_tick == 1)
            {
                model1.title = "famhis_corneal_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_corneal_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_opalrela_od_tick == 0)
            {
                model1.title = "famhis_opalrela_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_opalrela_od_tick == 1)
            {
                model1.title = "famhis_opalrela_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_opalrela_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_uveal_od_tick == 0)
            {
                model1.title = "famhis_uveal_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_uveal_od_tick == 1)
            {
                model1.title = "famhis_uveal_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_uveal_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_neuro_od_tick == 0)
            {
                model1.title = "famhis_neuro_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_neuro_od_tick == 1)
            {
                model1.title = "famhis_neuro_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_neuro_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_others_od_tick == 0)
            {
                model1.title = "famhis_others_od_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_others_od_tick == 1)
            {
                model1.title = "famhis_others_od_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_others_od_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_os_tick == 0)
            {
                model1.title = "famhis_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_os_tick == 1)
            {
                model1.title = "famhis_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            if (model.famhis_glaucoma_os_tick == 0)
            {
                model1.title = "famhis_glaucoma_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_glaucoma_os_tick == 1)
            {
                model1.title = "famhis_glaucoma_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_glaucoma_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_cataract_os_tick == 0)
            {
                model1.title = "famhis_cataract_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_cataract_os_tick == 1)
            {
                model1.title = "famhis_cataract_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_cataract_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_retina_os_tick == 0)
            {
                model1.title = "famhis_retina_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_retina_os_tick == 1)
            {
                model1.title = "famhis_retina_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_retina_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_squint_os_tick == 0)
            {
                model1.title = "famhis_squint_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_squint_os_tick == 1)
            {
                model1.title = "famhis_squint_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_squint_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_corneal_os_tick == 0)
            {
                model1.title = "famhis_corneal_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_corneal_os_tick == 1)
            {
                model1.title = "famhis_corneal_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_corneal_os_tick  ";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_opalrela_os_tick == 0)
            {
                model1.title = "famhis_opalrela_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_opalrela_os_tick == 1)
            {
                model1.title = "famhis_opalrela_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_opalrela_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_uveal_os_tick == 0)
            {
                model1.title = "famhis_uveal_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_uveal_os_tick == 1)
            {
                model1.title = "famhis_uveal_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_uveal_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_neuro_os_tick == 0)
            {
                model1.title = "famhis_neuro_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_neuro_os_tick == 1)
            {
                model1.title = "famhis_neuro_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_neuro_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if (model.famhis_others_os_tick == 0)
            {
                model1.title = "famhis_others_os_tick";
                model1.result = "No";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else if (model.famhis_others_os_tick == 1)
            {
                model1.title = "famhis_others_os_tick";
                model1.result = "Yes";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            else
            {
                model1.title = "famhis_others_os_tick";
                model1.result = "Donot Know";
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }


            model1.title = "famhisofeye_od_tick";
            model1.result = "";
            model1.tick_mark = model.famhisofeye_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "famhisofeye_os_tick";
            model1.result = "";
            model1.tick_mark = model.famhisofeye_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "allerg_od_tick";
            model1.result = "";
            model1.tick_mark = model.allerg_od_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            model1.title = "allerg_os_tick";
            model1.result = "";
            model1.tick_mark = model.allerg_os_tick;
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);

            if ((model.eyeproblem_glaucoma_od is null ? "" : model.eyeproblem_glaucoma_od).Length > 0)
            {
                model1.title = "eyeproblem_glaucoma_od";
                model1.result = model.eyeproblem_glaucoma_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_cataract_od is null ? "" : model.eyeproblem_cataract_od).Length > 0)
            {
                model1.title = "eyeproblem_cataract_od";
                model1.result = model.eyeproblem_cataract_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_retina_od is null ? "" : model.eyeproblem_retina_od).Length > 0)
            {
                model1.title = "eyeproblem_retina_od";
                model1.result = model.eyeproblem_retina_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_squint_od is null ? "" : model.eyeproblem_squint_od).Length > 0)
            {
                model1.title = "eyeproblem_squint_od";
                model1.result = model.eyeproblem_squint_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_corneal_od is null ? "" : model.eyeproblem_corneal_od).Length > 0)
            {
                model1.title = "eyeproblem_corneal_od";
                model1.result = model.eyeproblem_corneal_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_opalrelated_od is null ? "" : model.eyeproblem_opalrelated_od).Length > 0)
            {
                model1.title = "eyeproblem_opalrelated_od";
                model1.result = model.eyeproblem_opalrelated_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_uveal_od is null ? "" : model.eyeproblem_uveal_od).Length > 0)
            {
                model1.title = "eyeproblem_uveal_od";
                model1.result = model.eyeproblem_uveal_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_neuro_od is null ? "" : model.eyeproblem_neuro_od).Length > 0)
            {
                model1.title = "eyeproblem_neuro_od";
                model1.result = model.eyeproblem_neuro_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_others_od is null ? "" : model.eyeproblem_others_od).Length > 0)
            {
                model1.title = "eyeproblem_others_od";
                model1.result = model.eyeproblem_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_glaucoma_os is null ? "" : model.eyeproblem_glaucoma_os).Length > 0)
            {
                model1.title = "eyeproblem_glaucoma_os";
                model1.result = model.eyeproblem_glaucoma_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_cataract_os is null ? "" : model.eyeproblem_cataract_os).Length > 0)
            {
                model1.title = "eyeproblem_cataract_os";
                model1.result = model.eyeproblem_cataract_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_retina_os is null ? "" : model.eyeproblem_retina_os).Length > 0)
            {
                model1.title = "eyeproblem_retina_os";
                model1.result = model.eyeproblem_retina_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_squint_os is null ? "" : model.eyeproblem_squint_os).Length > 0)
            {
                model1.title = "eyeproblem_squint_os";
                model1.result = model.eyeproblem_squint_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_corneal_os is null ? "" : model.eyeproblem_corneal_os).Length > 0)
            {
                model1.title = "eyeproblem_corneal_os";
                model1.result = model.eyeproblem_corneal_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_opalrelated_os is null ? "" : model.eyeproblem_opalrelated_os).Length > 0)
            {
                model1.title = "eyeproblem_opalrelated_os";
                model1.result = model.eyeproblem_opalrelated_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_uveal_os is null ? "" : model.eyeproblem_uveal_os).Length > 0)
            {
                model1.title = "eyeproblem_uveal_os";
                model1.result = model.eyeproblem_uveal_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_neuro_os is null ? "" : model.eyeproblem_neuro_os).Length > 0)
            {
                model1.title = "eyeproblem_neuro_os";
                model1.result = model.eyeproblem_neuro_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeproblem_others_os is null ? "" : model.eyeproblem_others_os).Length > 0)
            {
                model1.title = "eyeproblem_others_os";
                model1.result = model.eyeproblem_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeprob_remarks_od is null ? "" : model.eyeprob_remarks_od).Length > 0)
            {
                model1.title = "eyeprob_remarks_od";
                model1.result = model.eyeprob_remarks_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.eyeprob_remarks_os is null ? "" : model.eyeprob_remarks_os).Length > 0)
            {
                model1.title = "eyeprob_remarks_os";
                model1.result = model.eyeprob_remarks_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.trauma_blunt_od is null ? "" : model.trauma_blunt_od).Length > 0)
            {
                model1.title = "trauma_blunt_od";
                model1.result = model.trauma_blunt_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.trauma_penetrating_od is null ? "" : model.trauma_penetrating_od).Length > 0)
            {
                model1.title = "trauma_penetrating_od";
                model1.result = model.trauma_penetrating_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.trauma_others_od is null ? "" : model.trauma_others_od).Length > 0)
            {
                model1.title = "trauma_others_od";
                model1.result = model.trauma_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
            if ((model.trauma_blunt_os is null ? "" : model.trauma_blunt_os).Length > 0)
            {
                model1.title = "trauma_blunt_os";
                model1.result = model.trauma_blunt_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.trauma_penetrating_os is null ? "" : model.trauma_penetrating_os).Length > 0)
            {
                model1.title = "trauma_penetrating_os";
                model1.result = model.trauma_penetrating_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.trauma_others_os is null ? "" : model.trauma_others_os).Length > 0)
            {
                model1.title = "trauma_others_os";
                model1.result = model.trauma_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_medical_od is null ? "" : model.treatment_medical_od).Length > 0)
            {
                model1.title = "treatment_medical_od";
                model1.result = model.treatment_medical_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_surgical_od is null ? "" : model.treatment_surgical_od).Length > 0)
            {
                model1.title = "treatment_surgical_od";
                model1.result = model.treatment_surgical_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_donotknow_od is null ? "" : model.treatment_donotknow_od).Length > 0)
            {
                model1.title = "treatment_donotknow_od";
                model1.result = model.treatment_donotknow_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_medical_os is null ? "" : model.treatment_medical_os).Length > 0)
            {
                model1.title = "treatment_medical_os";
                model1.result = model.treatment_medical_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_surgical_os is null ? "" : model.treatment_surgical_os).Length > 0)
            {
                model1.title = "treatment_surgical_os";
                model1.result = model.treatment_surgical_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_donotknow_os is null ? "" : model.treatment_donotknow_os).Length > 0)
            {
                model1.title = "treatment_donotknow_os";
                model1.result = model.treatment_donotknow_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_remarks_od is null ? "" : model.treatment_remarks_od).Length > 0)
            {
                model1.title = "treatment_remarks_od";
                model1.result = model.treatment_remarks_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.treatment_remarks_os is null ? "" : model.treatment_remarks_os).Length > 0)
            {
                model1.title = "treatment_remarks_os";
                model1.result = model.treatment_remarks_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_glaucoma_od_no is null ? "" : model.surg_glaucoma_od_no).Length > 0)
            {
                model1.title = "surg_glaucoma_od_no";
                model1.result = model.surg_glaucoma_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_glaucoma_od_time is null ? "" : model.surg_glaucoma_od_time).Length > 0)
            {
                model1.title = "surg_glaucoma_od_time";
                model1.result = model.surg_glaucoma_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_cataract_od_no is null ? "" : model.surg_cataract_od_no).Length > 0)
            {
                model1.title = "surg_cataract_od_no";
                model1.result = model.surg_cataract_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_cataract_od_time is null ? "" : model.surg_cataract_od_time).Length > 0)
            {
                model1.title = "surg_cataract_od_time";
                model1.result = model.surg_cataract_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_retina_od_no is null ? "" : model.surg_retina_od_no).Length > 0)
            {
                model1.title = "surg_retina_od_no";
                model1.result = model.surg_retina_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_retina_od_time is null ? "" : model.surg_retina_od_time).Length > 0)
            {
                model1.title = "surg_retina_od_time";
                model1.result = model.surg_retina_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_squint_od_no is null ? "" : model.surg_squint_od_no).Length > 0)
            {
                model1.title = "surg_squint_od_no";
                model1.result = model.surg_squint_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_squint_od_time is null ? "" : model.surg_squint_od_time).Length > 0)
            {
                model1.title = "surg_squint_od_time";
                model1.result = model.surg_squint_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_corneal_od_no is null ? "" : model.surg_corneal_od_no).Length > 0)
            {
                model1.title = "surg_corneal_od_no";
                model1.result = model.surg_corneal_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_corneal_od_time is null ? "" : model.surg_corneal_od_time).Length > 0)
            {
                model1.title = "surg_corneal_od_time";
                model1.result = model.surg_corneal_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_opalrela_od_no is null ? "" : model.surg_opalrela_od_no).Length > 0)
            {
                model1.title = "surg_opalrela_od_no";
                model1.result = model.surg_opalrela_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_opalrela_od_time is null ? "" : model.surg_opalrela_od_time).Length > 0)
            {
                model1.title = "surg_opalrela_od_time";
                model1.result = model.surg_opalrela_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_uveal_od_no is null ? "" : model.surg_uveal_od_no).Length > 0)
            {
                model1.title = "surg_uveal_od_no";
                model1.result = model.surg_uveal_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_uveal_od_time is null ? "" : model.surg_uveal_od_time).Length > 0)
            {
                model1.title = "surg_uveal_od_time";
                model1.result = model.surg_uveal_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_neuroopthamalic_od_no is null ? "" : model.surg_neuroopthamalic_od_no).Length > 0)
            {
                model1.title = "surg_neuroopthamalic_od_no";
                model1.result = model.surg_neuroopthamalic_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_neuroopthamalic_od_time is null ? "" : model.surg_neuroopthamalic_od_time).Length > 0)
            {
                model1.title = "surg_neuroopthamalic_od_time";
                model1.result = model.surg_neuroopthamalic_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_others_od_no is null ? "" : model.surg_others_od_no).Length > 0)
            {
                model1.title = "surg_others_od_no";
                model1.result = model.surg_others_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_others_od_time is null ? "" : model.surg_others_od_time).Length > 0)
            {
                model1.title = "surg_others_od_time";
                model1.result = model.surg_others_od_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_glaucoma_os_no is null ? "" : model.surg_glaucoma_os_no).Length > 0)
            {
                model1.title = "surg_glaucoma_os_no";
                model1.result = model.surg_glaucoma_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_glaucoma_os_time is null ? "" : model.surg_glaucoma_os_time).Length > 0)
            {
                model1.title = "surg_glaucoma_os_time";
                model1.result = model.surg_glaucoma_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_cataract_os_no is null ? "" : model.surg_cataract_os_no).Length > 0)
            {
                model1.title = "surg_cataract_os_no";
                model1.result = model.surg_cataract_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_cataract_os_time is null ? "" : model.surg_cataract_os_time).Length > 0)
            {
                model1.title = "surg_cataract_os_time";
                model1.result = model.surg_cataract_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_retina_os_no is null ? "" : model.surg_retina_os_no).Length > 0)
            {
                model1.title = "surg_retina_os_no";
                model1.result = model.surg_retina_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_retina_os_time is null ? "" : model.surg_retina_os_time).Length > 0)
            {
                model1.title = "surg_retina_os_time";
                model1.result = model.surg_retina_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_squint_os_no is null ? "" : model.surg_squint_os_no).Length > 0)
            {
                model1.title = "surg_squint_os_no";
                model1.result = model.surg_squint_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_squint_os_time is null ? "" : model.surg_squint_os_time).Length > 0)
            {
                model1.title = "surg_squint_os_time";
                model1.result = model.surg_squint_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_corneal_os_no is null ? "" : model.surg_corneal_os_no).Length > 0)
            {
                model1.title = "surg_corneal_os_no";
                model1.result = model.surg_corneal_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_corneal_os_time is null ? "" : model.surg_corneal_os_time).Length > 0)
            {
                model1.title = "surg_corneal_os_time";
                model1.result = model.surg_corneal_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_opalrela_os_no is null ? "" : model.surg_opalrela_os_no).Length > 0)
            {
                model1.title = "surg_opalrela_os_no";
                model1.result = model.surg_opalrela_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_opalrela_os_time is null ? "" : model.surg_opalrela_os_time).Length > 0)
            {
                model1.title = "surg_opalrela_os_time";
                model1.result = model.surg_opalrela_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_uveal_od_no is null ? "" : model.surg_uveal_od_no).Length > 0)
            {
                model1.title = "surg_uveal_od_no";
                model1.result = model.surg_uveal_od_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_uveal_os_time is null ? "" : model.surg_uveal_os_time).Length > 0)
            {
                model1.title = "surg_uveal_os_time";
                model1.result = model.surg_uveal_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_neuroopthamalic_os_no is null ? "" : model.surg_neuroopthamalic_os_no).Length > 0)
            {
                model1.title = "surg_neuroopthamalic_os_no";
                model1.result = model.surg_neuroopthamalic_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_neuroopthamalic_os_time is null ? "" : model.surg_neuroopthamalic_os_time).Length > 0)
            {
                model1.title = "surg_neuroopthamalic_os_time";
                model1.result = model.surg_neuroopthamalic_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_others_os_no is null ? "" : model.surg_others_os_no).Length > 0)
            {
                model1.title = "surg_others_os_no";
                model1.result = model.surg_others_os_no;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_others_os_time is null ? "" : model.surg_others_os_time).Length > 0)
            {
                model1.title = "surg_others_os_time";
                model1.result = model.surg_others_os_time;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_remarks_od is null ? "" : model.surg_remarks_od).Length > 0)
            {
                model1.title = "surg_remarks_od";
                model1.result = model.surg_remarks_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.surg_remarks_os is null ? "" : model.surg_remarks_os).Length > 0)
            {
                model1.title = "surg_remarks_os";
                model1.result = model.surg_remarks_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_hyper_od is null ? "" : model.systill_hyper_od).Length > 0)
            {
                model1.title = "systill_hyper_od";
                model1.result = model.systill_hyper_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_diab_od is null ? "" : model.systill_diab_od).Length > 0)
            {
                model1.title = "systill_diab_od";
                model1.result = model.systill_diab_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_astha_od is null ? "" : model.systill_astha_od).Length > 0)
            {
                model1.title = "systill_astha_od";
                model1.result = model.systill_astha_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_cardc_od is null ? "" : model.systill_cardc_od).Length > 0)
            {
                model1.title = "systill_cardc_od";
                model1.result = model.systill_cardc_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_thy_od is null ? "" : model.systill_thy_od).Length > 0)
            {
                model1.title = "systill_thy_od";
                model1.result = model.systill_thy_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_cereb_od is null ? "" : model.systill_cereb_od).Length > 0)
            {
                model1.title = "systill_cereb_od";
                model1.result = model.systill_cereb_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_hyperlipi_od is null ? "" : model.systill_hyperlipi_od).Length > 0)
            {
                model1.title = "systill_hyperlipi_od";
                model1.result = model.systill_hyperlipi_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_kidney_od is null ? "" : model.systill_kidney_od).Length > 0)
            {
                model1.title = "systill_kidney_od";
                model1.result = model.systill_kidney_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_anemia_od is null ? "" : model.systill_anemia_od).Length > 0)
            {
                model1.title = "systill_anemia_od";
                model1.result = model.systill_anemia_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_eyeprob_od is null ? "" : model.systill_eyeprob_od).Length > 0)
            {
                model1.title = "systill_eyeprob_od";
                model1.result = model.systill_eyeprob_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_rheu_od is null ? "" : model.systill_rheu_od).Length > 0)
            {
                model1.title = "systill_rheu_od";
                model1.result = model.systill_rheu_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_inf_od is null ? "" : model.systill_inf_od).Length > 0)
            {
                model1.title = "systill_inf_od";
                model1.result = model.systill_inf_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_others_od is null ? "" : model.systill_others_od).Length > 0)
            {
                model1.title = "systill_others_od";
                model1.result = model.systill_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_hyper_os is null ? "" : model.systill_hyper_os).Length > 0)
            {
                model1.title = "systill_hyper_os";
                model1.result = model.systill_hyper_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_diab_os is null ? "" : model.systill_diab_os).Length > 0)
            {
                model1.title = "systill_diab_os";
                model1.result = model.systill_diab_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_astha_os is null ? "" : model.systill_astha_os).Length > 0)
            {
                model1.title = "systill_astha_os";
                model1.result = model.systill_astha_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_cardc_os is null ? "" : model.systill_cardc_os).Length > 0)
            {
                model1.title = "systill_cardc_os";
                model1.result = model.systill_cardc_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_thy_os is null ? "" : model.systill_thy_os).Length > 0)
            {
                model1.title = "systill_thy_os";
                model1.result = model.systill_thy_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_cereb_os is null ? "" : model.systill_cereb_os).Length > 0)
            {
                model1.title = "systill_cereb_os";
                model1.result = model.systill_cereb_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_hyperlipi_os is null ? "" : model.systill_hyperlipi_os).Length > 0)
            {
                model1.title = "systill_hyperlipi_os";
                model1.result = model.systill_hyperlipi_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_kidney_os is null ? "" : model.systill_kidney_os).Length > 0)
            {
                model1.title = "systill_kidney_os";
                model1.result = model.systill_kidney_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_anemia_os is null ? "" : model.systill_anemia_os).Length > 0)
            {
                model1.title = "systill_anemia_os";
                model1.result = model.systill_anemia_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_eyeprob_os is null ? "" : model.systill_eyeprob_os).Length > 0)
            {
                model1.title = "systill_eyeprob_os";
                model1.result = model.systill_eyeprob_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_rheu_os is null ? "" : model.systill_rheu_os).Length > 0)
            {
                model1.title = "systill_rheu_os";
                model1.result = model.systill_rheu_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_inf_os is null ? "" : model.systill_inf_os).Length > 0)
            {
                model1.title = "systill_inf_os";
                model1.result = model.systill_inf_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_others_os is null ? "" : model.systill_others_os).Length > 0)
            {
                model1.title = "systill_others_os";
                model1.result = model.systill_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_medi_od is null ? "" : model.systill_medi_od).Length > 0)
            {
                model1.title = "systill_medi_od";
                model1.result = model.systill_medi_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_medi_os is null ? "" : model.systill_medi_os).Length > 0)
            {
                model1.title = "systill_medi_os";
                model1.result = model.systill_medi_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_remarks_od is null ? "" : model.systill_remarks_od).Length > 0)
            {
                model1.title = "systill_remarks_od";
                model1.result = model.systill_remarks_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.systill_remarks_os is null ? "" : model.systill_remarks_os).Length > 0)
            {
                model1.title = "systill_remarks_os";
                model1.result = model.systill_remarks_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_oral_od is null ? "" : model.hisofstre_oral_od).Length > 0)
            {
                model1.title = "hisofstre_oral_od";
                model1.result = model.hisofstre_oral_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_injectsys_od is null ? "" : model.hisofstre_injectsys_od).Length > 0)
            {
                model1.title = "hisofstre_injectsys_od";
                model1.result = model.hisofstre_injectsys_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_injectperi_od is null ? "" : model.hisofstre_injectperi_od).Length > 0)
            {
                model1.title = "hisofstre_injectperi_od";
                model1.result = model.hisofstre_injectperi_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_eyedrop_od is null ? "" : model.hisofstre_eyedrop_od).Length > 0)
            {
                model1.title = "hisofstre_eyedrop_od";
                model1.result = model.hisofstre_eyedrop_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_skincr_od is null ? "" : model.hisofstre_skincr_od).Length > 0)
            {
                model1.title = "hisofstre_skincr_od";
                model1.result = model.hisofstre_skincr_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_others_od is null ? "" : model.hisofstre_others_od).Length > 0)
            {
                model1.title = "hisofstre_others_od";
                model1.result = model.hisofstre_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_oral_os is null ? "" : model.hisofstre_oral_os).Length > 0)
            {
                model1.title = "hisofstre_oral_os";
                model1.result = model.hisofstre_oral_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_injectsys_os is null ? "" : model.hisofstre_injectsys_os).Length > 0)
            {
                model1.title = "hisofstre_injectsys_os";
                model1.result = model.hisofstre_injectsys_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_injectperi_os is null ? "" : model.hisofstre_injectperi_os).Length > 0)
            {
                model1.title = "hisofstre_injectperi_os";
                model1.result = model.hisofstre_injectperi_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_eyedrop_os is null ? "" : model.hisofstre_eyedrop_os).Length > 0)
            {
                model1.title = "hisofstre_eyedrop_os";
                model1.result = model.hisofstre_eyedrop_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_skincr_os is null ? "" : model.hisofstre_skincr_os).Length > 0)
            {
                model1.title = "hisofstre_skincr_os";
                model1.result = model.hisofstre_skincr_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.hisofstre_others_os is null ? "" : model.hisofstre_others_os).Length > 0)
            {
                model1.title = "hisofstre_others_os";
                model1.result = model.hisofstre_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_glaucoma_od is null ? "" : model.famhis_glaucoma_od).Length > 0)
            {
                model1.title = "famhis_glaucoma_od";
                model1.result = model.famhis_glaucoma_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_cataract_od is null ? "" : model.famhis_cataract_od).Length > 0)
            {
                model1.title = "famhis_cataract_od";
                model1.result = model.famhis_cataract_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_retina_od is null ? "" : model.famhis_retina_od).Length > 0)
            {
                model1.title = "famhis_retina_od";
                model1.result = model.famhis_retina_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_squint_od is null ? "" : model.famhis_squint_od).Length > 0)
            {
                model1.title = "famhis_squint_od";
                model1.result = model.famhis_squint_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_corneal_od is null ? "" : model.famhis_corneal_od).Length > 0)
            {
                model1.title = "famhis_corneal_od";
                model1.result = model.famhis_corneal_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_opalrela_od is null ? "" : model.famhis_opalrela_od).Length > 0)
            {
                model1.title = "famhis_opalrela_od";
                model1.result = model.famhis_opalrela_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_uveal_od is null ? "" : model.famhis_uveal_od).Length > 0)
            {
                model1.title = "famhis_uveal_od";
                model1.result = model.famhis_uveal_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_neuro_od is null ? "" : model.famhis_neuro_od).Length > 0)
            {
                model1.title = "famhis_neuro_od";
                model1.result = model.famhis_neuro_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_others_od is null ? "" : model.famhis_others_od).Length > 0)
            {
                model1.title = "famhis_others_od";
                model1.result = model.famhis_others_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }


            if ((model.famhis_glaucoma_os is null ? "" : model.famhis_glaucoma_os).Length > 0)
            {
                model1.title = "famhis_glaucoma_os";
                model1.result = model.famhis_glaucoma_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_cataract_os is null ? "" : model.famhis_cataract_os).Length > 0)
            {
                model1.title = "famhis_cataract_os";
                model1.result = model.famhis_cataract_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_retina_os is null ? "" : model.famhis_retina_os).Length > 0)
            {
                model1.title = "famhis_retina_os";
                model1.result = model.famhis_retina_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_squint_os is null ? "" : model.famhis_squint_os).Length > 0)
            {
                model1.title = "famhis_squint_os";
                model1.result = model.famhis_squint_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_corneal_os is null ? "" : model.famhis_corneal_os).Length > 0)
            {
                model1.title = "famhis_corneal_os";
                model1.result = model.famhis_corneal_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_opalrela_os is null ? "" : model.famhis_opalrela_os).Length > 0)
            {
                model1.title = "famhis_opalrela_os";
                model1.result = model.famhis_opalrela_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_uveal_os is null ? "" : model.famhis_uveal_os).Length > 0)
            {
                model1.title = "famhis_uveal_os";
                model1.result = model.famhis_uveal_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_neuro_os is null ? "" : model.famhis_neuro_os).Length > 0)
            {
                model1.title = "famhis_neuro_os";
                model1.result = model.famhis_neuro_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhis_others_os is null ? "" : model.famhis_others_os).Length > 0)
            {
                model1.title = "famhis_others_os";
                model1.result = model.famhis_others_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.fam_reltosub_od is null ? "" : model.fam_reltosub_od).Length > 0)
            {
                model1.title = "fam_reltosub_od";
                model1.result = model.fam_reltosub_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.fam_reltosub_os is null ? "" : model.fam_reltosub_os).Length > 0)
            {
                model1.title = "fam_reltosub_os";
                model1.result = model.fam_reltosub_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhisofeye_od is null ? "" : model.famhisofeye_od).Length > 0)
            {
                model1.title = "famhisofeye_od";
                model1.result = model.famhisofeye_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.famhisofeye_os is null ? "" : model.famhisofeye_os).Length > 0)
            {
                model1.title = "famhisofeye_os";
                model1.result = model.famhisofeye_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.allerg_od is null ? "" : model.allerg_od).Length > 0)
            {
                model1.title = "allerg_od";
                model1.result = model.allerg_od;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }

            if ((model.allerg_os is null ? "" : model.allerg_os).Length > 0)
            {
                model1.title = "allerg_os";
                model1.result = model.allerg_os;
                model1.tick_mark = false;
                DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model1);
            }
        }


        [HttpPost]
        [Route("api/PastEyeHistory")]
        public IHttpActionResult Post(Past_Eye_HistoryInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_HistoryInsert", model);
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
        [Route("api/PastEyeHistory/Update")]
        public IHttpActionResult Update(Past_Eye_HistoryUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_HistoryUpdate", model);
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
        [Route("api/PastEyeHistory")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<Past_Eye_HistorySelect_dt>
                ("sp_Past_Eye_HistorySelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/PastEyeHistory/Delete")]
        public IHttpActionResult Delete(Past_Eye_HistoryDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_HistoryDelete", model);
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
        [Route("api/PastEyeHistoryAll")]
        public IHttpActionResult GetAll(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PastHistoryDetails_Select_dt>
                ("sp_Past_Eye_History_detailsSelect", new { mrdno = mrdno }).ToList();
            Past_Eye_HistorySelectAll_dt model_new = new Past_Eye_HistorySelectAll_dt();
            foreach(var x in list)
            {
                model_new.mrdno = x.mrdno;
               
                if (x.title == "eyeproblem_od_tick")
                {
                    model_new.eyeproblem_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_glaucoma_od_tick")
                {
                    model_new.eyeproblem_glaucoma_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_glaucoma_od")
                {
                    model_new.eyeproblem_glaucoma_od = x.result;
                }

                if (x.title == "eyeproblem_cataract_od_tick")
                {
                    model_new.eyeproblem_cataract_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_cataract_od")
                {
                    model_new.eyeproblem_cataract_od = x.result;
                }

                if (x.title == "eyeproblem_retina_od_tick")
                {
                    model_new.eyeproblem_retina_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_retina_od")
                {
                    model_new.eyeproblem_retina_od = x.result;
                }

                if (x.title == "eyeproblem_squint_od_tick")
                {
                    model_new.eyeproblem_squint_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_squint_od")
                {
                    model_new.eyeproblem_squint_od = x.result;
                }

                if (x.title == "eyeproblem_corneal_od_tick")
                {
                    model_new.eyeproblem_corneal_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_corneal_od")
                {
                    model_new.eyeproblem_corneal_od = x.result;
                }

                if (x.title == "eyeproblem_opalrelated_od_tick")
                {
                    model_new.eyeproblem_opalrelated_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_opalrelated_od")
                {
                    model_new.eyeproblem_opalrelated_od = x.result;
                }

                if (x.title == "eyeproblem_uveal_od_tick")
                {
                    model_new.eyeproblem_uveal_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_uveal_od")
                {
                    model_new.eyeproblem_uveal_od = x.result;
                }

                if (x.title == "eyeproblem_neuro_od_tick")
                {
                    model_new.eyeproblem_neuro_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_neuro_od")
                {
                    model_new.eyeproblem_neuro_od = x.result;
                }

                if (x.title == "eyeproblem_others_od_tick")
                {
                    model_new.eyeproblem_others_od_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_others_od")
                {
                    model_new.eyeproblem_others_od = x.result;
                }

                if (x.title == "eyeproblem_os_tick")
                {
                    model_new.eyeproblem_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_glaucoma_os_tick")
                {
                    model_new.eyeproblem_glaucoma_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_glaucoma_os")
                {
                    model_new.eyeproblem_glaucoma_os = x.result;
                }

                if (x.title == "eyeproblem_cataract_os_tick")
                {
                    model_new.eyeproblem_cataract_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_cataract_os")
                {
                    model_new.eyeproblem_cataract_os = x.result;
                }

                if (x.title == "eyeproblem_retina_os_tick")
                {
                    model_new.eyeproblem_retina_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_retina_os")
                {
                    model_new.eyeproblem_retina_os = x.result;
                }

                if (x.title == "eyeproblem_squint_os_tick")
                {
                    model_new.eyeproblem_squint_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_squint_os")
                {
                    model_new.eyeproblem_squint_os = x.result;
                }

                if (x.title == "eyeproblem_corneal_os_tick")
                {
                    model_new.eyeproblem_corneal_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_corneal_os")
                {
                    model_new.eyeproblem_corneal_os = x.result;
                }

                if (x.title == "eyeproblem_opalrelated_os_tick")
                {
                    model_new.eyeproblem_opalrelated_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_opalrelated_os")
                {
                    model_new.eyeproblem_opalrelated_os = x.result;
                }

                if (x.title == "eyeproblem_uveal_os_tick")
                {
                    model_new.eyeproblem_uveal_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_uveal_os")
                {
                    model_new.eyeproblem_uveal_os = x.result;
                }

                if (x.title == "eyeproblem_neuro_os_tick")
                {
                    model_new.eyeproblem_neuro_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_neuro_os")
                {
                    model_new.eyeproblem_neuro_os = x.result;
                }

                if (x.title == "eyeproblem_others_os_tick")
                {
                    model_new.eyeproblem_others_os_tick = x.tick_mark;
                }

                if (x.title == "eyeproblem_others_os")
                {
                    model_new.eyeproblem_others_os = x.result;
                }

                if (x.title == "eyeprob_remarks_od")
                {
                    model_new.eyeprob_remarks_od = x.result;
                }

                if (x.title == "eyeprob_remarks_os")
                {
                    model_new.eyeprob_remarks_os = x.result;
                }

                if (x.title == "trauma_od_tick")
                {
                    model_new.trauma_od_tick = x.tick_mark;
                }

                if (x.title == "trauma_blunt_od_tick")
                {
                    model_new.trauma_blunt_od_tick = x.tick_mark;
                }

                if (x.title == "trauma_blunt_od")
                {
                    model_new.trauma_blunt_od = x.result;
                }

                if (x.title == "trauma_penetrating_od_tick")
                {
                    model_new.trauma_penetrating_od_tick = x.tick_mark;
                }

                if (x.title == "trauma_penetrating_od")
                {
                    model_new.trauma_penetrating_od = x.result;
                }

                if (x.title == "trauma_others_od_tick")
                {
                    model_new.trauma_others_od_tick = x.tick_mark;
                }

                if (x.title == "trauma_others_od")
                {
                    model_new.trauma_others_od = x.result;
                }

                if (x.title == "trauma_os_tick")
                {
                    model_new.trauma_os_tick = x.tick_mark;
                }

                if (x.title == "trauma_blunt_os_tick")
                {
                    model_new.trauma_blunt_os_tick = x.tick_mark;
                }

                if (x.title == "trauma_blunt_os")
                {
                    model_new.trauma_blunt_os = x.result;
                }

                if (x.title == "trauma_penetrating_os_tick")
                {
                    model_new.trauma_penetrating_os_tick = x.tick_mark;
                }

                if (x.title == "trauma_penetrating_os")
                {
                    model_new.trauma_penetrating_os = x.result;
                }

                if (x.title == "trauma_others_os_tick")
                {
                    model_new.trauma_others_os_tick = x.tick_mark;
                }

                if (x.title == "trauma_others_os")
                {
                    model_new.trauma_others_os = x.result;
                }

                if (x.title == "treatment_od_tick")
                {
                    model_new.treatment_od_tick = x.tick_mark;
                }

                if (x.title == "treatment_medical_od_tick")
                {
                    model_new.treatment_medical_od_tick = x.tick_mark;
                }

                if (x.title == "treatment_medical_od")
                {
                    model_new.treatment_medical_od = x.result;
                }

                if (x.title == "treatment_surgical_od_tick")
                {
                    model_new.treatment_surgical_od_tick = x.tick_mark;
                }

                if (x.title == "treatment_surgical_od")
                {
                    model_new.treatment_surgical_od = x.result;
                }

                if (x.title == "treatment_donotknow_od_tick")
                {
                    model_new.treatment_donotknow_od_tick = x.tick_mark;
                }

                if (x.title == "treatment_donotknow_od")
                {
                    model_new.treatment_donotknow_od = x.result;
                }

                if (x.title == "treatment_os_tick")
                {
                    model_new.treatment_os_tick = x.tick_mark;
                }

                if (x.title == "treatment_medical_os_tick")
                {
                    model_new.treatment_medical_os_tick = x.tick_mark;
                }

                if (x.title == "treatment_medical_os")
                {
                    model_new.treatment_medical_os = x.result;
                }

                if (x.title == "treatment_surgical_os_tick")
                {
                    model_new.treatment_surgical_os_tick = x.tick_mark;
                }

                if (x.title == "treatment_surgical_os")
                {
                    model_new.treatment_surgical_os = x.result;
                }

                if (x.title == "treatment_donotknow_os_tick")
                {
                    model_new.treatment_donotknow_os_tick = x.tick_mark;
                }

                if (x.title == "treatment_donotknow_os")
                {
                    model_new.treatment_donotknow_os = x.result;
                }

                if (x.title == "treatment_remarks_od")
                {
                    model_new.treatment_remarks_od = x.result;
                }

                if (x.title == "treatment_remarks_os")
                {
                    model_new.treatment_remarks_os = x.result;
                }

                if (x.title == "surg_od_tick")
                {
                    model_new.surg_od_tick = x.tick_mark;
                }

                if (x.title == "surg_glaucoma_od_tick")
                {
                    model_new.surg_glaucoma_od_tick = x.tick_mark;
                }

                if (x.title == "surg_glaucoma_od_no")
                {
                    model_new.surg_glaucoma_od_no = x.result;
                }

                if (x.title == "surg_glaucoma_od_time")
                {
                    model_new.surg_glaucoma_od_time = x.result;
                }

                if (x.title == "surg_cataract_od_tick")
                {
                    model_new.surg_cataract_od_tick = x.tick_mark;
                }

                if (x.title == "surg_cataract_od_no")
                {
                    model_new.surg_cataract_od_no = x.result;
                }

                if (x.title == "surg_cataract_od_time")
                {
                    model_new.surg_cataract_od_time = x.result;
                }

                if (x.title == "surg_retina_od_tick")
                {
                    model_new.surg_retina_od_tick = x.tick_mark;
                }

                if (x.title == "surg_retina_od_no")
                {
                    model_new.surg_retina_od_no = x.result;
                }

                if (x.title == "surg_retina_od_time")
                {
                    model_new.surg_retina_od_time = x.result;
                }

                if (x.title == "surg_squint_od_tick")
                {
                    model_new.surg_squint_od_tick = x.tick_mark;
                }

                if (x.title == "surg_squint_od_no")
                {
                    model_new.surg_squint_od_no = x.result;
                }

                if (x.title == "surg_squint_od_time")
                {
                    model_new.surg_squint_od_time = x.result;
                }

                if (x.title == "surg_corneal_od_tick")
                {
                    model_new.surg_corneal_od_tick = x.tick_mark;
                }

                if (x.title == "surg_corneal_od_no")
                {
                    model_new.surg_corneal_od_no = x.result;
                }

                if (x.title == "surg_corneal_od_time")
                {
                    model_new.surg_corneal_od_time = x.result;
                }

                if (x.title == "surg_opalrela_od_tick")
                {
                    model_new.surg_opalrela_od_tick = x.tick_mark;
                }

                if (x.title == "surg_opalrela_od_no")
                {
                    model_new.surg_opalrela_od_no = x.result;
                }

                if (x.title == "surg_opalrela_od_time")
                {
                    model_new.surg_opalrela_od_time = x.result;
                }

                if (x.title == "surg_uveal_od_tick")
                {
                    model_new.surg_uveal_od_tick = x.tick_mark;
                }

                if (x.title == "surg_uveal_od_no")
                {
                    model_new.surg_uveal_od_no = x.result;
                }

                if (x.title == "surg_uveal_od_time")
                {
                    model_new.surg_uveal_od_time = x.result;
                }

                if (x.title == "surg_neuroopthamalic_od_tick")
                {
                    model_new.surg_neuroopthamalic_od_tick = x.tick_mark;
                }

                if (x.title == "surg_neuroopthamalic_od_no")
                {
                    model_new.surg_neuroopthamalic_od_no = x.result;
                }

                if (x.title == "surg_neuroopthamalic_od_time")
                {
                    model_new.surg_neuroopthamalic_od_time = x.result;
                }

                if (x.title == "surg_others_od_tick")
                {
                    model_new.surg_others_od_tick = x.tick_mark;
                }

                if (x.title == "surg_others_od_no")
                {
                    model_new.surg_others_od_no = x.result;
                }

                if (x.title == "surg_others_od_time")
                {
                    model_new.surg_others_od_time = x.result;
                }

                if (x.title == "surg_os_tick")
                {
                    model_new.surg_os_tick = x.tick_mark;
                }

                if (x.title == "surg_glaucoma_os_tick")
                {
                    model_new.surg_glaucoma_os_tick = x.tick_mark;
                }

                if (x.title == "surg_glaucoma_os_no")
                {
                    model_new.surg_glaucoma_os_no = x.result;
                }

                if (x.title == "surg_glaucoma_os_time")
                {
                    model_new.surg_glaucoma_os_time = x.result;
                }

                if (x.title == "surg_cataract_os_tick")
                {
                    model_new.surg_cataract_os_tick = x.tick_mark;
                }

                if (x.title == "surg_cataract_os_no")
                {
                    model_new.surg_cataract_os_no = x.result;
                }

                if (x.title == "surg_cataract_os_time")
                {
                    model_new.surg_cataract_os_time = x.result;
                }

                if (x.title == "surg_retina_os_tick")
                {
                    model_new.surg_retina_os_tick = x.tick_mark;
                }

                if (x.title == "surg_retina_os_no")
                {
                    model_new.surg_retina_os_no = x.result;
                }

                if (x.title == "surg_retina_os_time")
                {
                    model_new.surg_retina_os_time = x.result;
                }

                if (x.title == "surg_squint_os_tick")
                {
                    model_new.surg_squint_os_tick = x.tick_mark;
                }

                if (x.title == "surg_squint_os_no")
                {
                    model_new.surg_squint_os_no = x.result;
                }

                if (x.title == "surg_squint_os_time")
                {
                    model_new.surg_squint_os_time = x.result;
                }

                if (x.title == "surg_corneal_os_tick")
                {
                    model_new.surg_corneal_os_tick = x.tick_mark;
                }

                if (x.title == "surg_corneal_os_no")
                {
                    model_new.surg_corneal_os_no = x.result;
                }

                if (x.title == "surg_corneal_os_time")
                {
                    model_new.surg_corneal_os_time = x.result;
                }

                if (x.title == "surg_opalrela_os_tick")
                {
                    model_new.surg_opalrela_os_tick = x.tick_mark;
                }

                if (x.title == "surg_opalrela_os_no")
                {
                    model_new.surg_opalrela_os_no = x.result;
                }

                if (x.title == "surg_opalrela_os_time")
                {
                    model_new.surg_opalrela_os_time = x.result;
                }

                if (x.title == "surg_uveal_os_tick")
                {
                    model_new.surg_uveal_os_tick = x.tick_mark;
                }

                if (x.title == "surg_uveal_os_no")
                {
                    model_new.surg_uveal_os_no = x.result;
                }

                if (x.title == "surg_uveal_os_time")
                {
                    model_new.surg_uveal_os_time = x.result;
                }

                if (x.title == "surg_neuroopthamalic_os_tick")
                {
                    model_new.surg_neuroopthamalic_os_tick = x.tick_mark;
                }

                if (x.title == "surg_neuroopthamalic_os_no")
                {
                    model_new.surg_neuroopthamalic_os_no = x.result;
                }

                if (x.title == "surg_neuroopthamalic_os_time")
                {
                    model_new.surg_neuroopthamalic_os_time = x.result;
                }

                if (x.title == "surg_others_os_tick")
                {
                    model_new.surg_others_os_tick = x.tick_mark;
                }

                if (x.title == "surg_others_os_no")
                {
                    model_new.surg_others_os_no = x.result;
                }

                if (x.title == "surg_others_os_time")
                {
                    model_new.surg_others_os_time = x.result;
                }

                if (x.title == "surg_remarks_od")
                {
                    model_new.surg_remarks_od = x.result;
                }

                if (x.title == "surg_remarks_os")
                {
                    model_new.surg_remarks_os = x.result;
                }

                if (x.title == "systill_od_tick")
                {
                    model_new.systill_od_tick = x.tick_mark;
                }

                if (x.title == "systill_hyper_od_tick")
                {
                    model_new.systill_hyper_od_tick = x.tick_mark;
                }

                if (x.title == "systill_hyper_od")
                {
                    model_new.systill_hyper_od = x.result;
                }

                if (x.title == "systill_diab_od_tick")
                {
                    model_new.systill_diab_od_tick = x.tick_mark;
                }

                if (x.title == "systill_diab_od")
                {
                    model_new.systill_diab_od = x.result;
                }

                if (x.title == "systill_astha_od_tick")
                {
                    model_new.systill_astha_od_tick = x.tick_mark;
                }

                if (x.title == "systill_astha_od")
                {
                    model_new.systill_astha_od = x.result;
                }

                if (x.title == "systill_cardc_od_tick")
                {
                    model_new.systill_cardc_od_tick = x.tick_mark;
                }

                if (x.title == "systill_cardc_od")
                {
                    model_new.systill_cardc_od = x.result;
                }

                if (x.title == "systill_thy_od_tick")
                {
                    model_new.systill_thy_od_tick = x.tick_mark;
                }

                if (x.title == "systill_thy_od")
                {
                    model_new.systill_thy_od = x.result;
                }

                if (x.title == "systill_cereb_od_tick")
                {
                    model_new.systill_cereb_od_tick = x.tick_mark;
                }

                if (x.title == "systill_cereb_od")
                {
                    model_new.systill_cereb_od = x.result;
                }

                if (x.title == "systill_hyperlipi_od_tick")
                {
                    model_new.systill_hyperlipi_od_tick = x.tick_mark;
                }

                if (x.title == "systill_hyperlipi_od")
                {
                    model_new.systill_hyperlipi_od = x.result;
                }

                if (x.title == "systill_kidney_od_tick")
                {
                    model_new.systill_kidney_od_tick = x.tick_mark;
                }

                if (x.title == "systill_kidney_od")
                {
                    model_new.systill_kidney_od = x.result;
                }

                if (x.title == "systill_anemia_od_tick")
                {
                    model_new.systill_anemia_od_tick = x.tick_mark;
                }

                if (x.title == "systill_anemia_od")
                {
                    model_new.systill_anemia_od = x.result;
                }

                if (x.title == "systill_eyeprob_od_tick")
                {
                    model_new.systill_eyeprob_od_tick = x.tick_mark;
                }

                if (x.title == "systill_eyeprob_od")
                {
                    model_new.systill_eyeprob_od = x.result;
                }

                if (x.title == "systill_rheu_od_tick")
                {
                    model_new.systill_rheu_od_tick = x.tick_mark;
                }

                if (x.title == "systill_rheu_od")
                {
                    model_new.systill_rheu_od = x.result;
                }

                if (x.title == "systill_inf_od_tick")
                {
                    model_new.systill_inf_od_tick = x.tick_mark;
                }

                if (x.title == "systill_inf_od")
                {
                    model_new.systill_inf_od = x.result;
                }

                if (x.title == "systill_others_od_tick")
                {
                    model_new.systill_others_od_tick = x.tick_mark;
                }

                if (x.title == "systill_others_od")
                {
                    model_new.systill_others_od = x.result;
                }

                if (x.title == "systill_os_tick")
                {
                    model_new.systill_os_tick = x.tick_mark;
                }

                if (x.title == "systill_hyper_os_tick")
                {
                    model_new.systill_hyper_os_tick = x.tick_mark;
                }

                if (x.title == "systill_hyper_os")
                {
                    model_new.systill_hyper_os = x.result;
                }

                if (x.title == "systill_diab_os_tick")
                {
                    model_new.systill_diab_os_tick = x.tick_mark;
                }

                if (x.title == "systill_diab_os")
                {
                    model_new.systill_diab_os = x.result;
                }

                if (x.title == "systill_astha_os_tick")
                {
                    model_new.systill_astha_os_tick = x.tick_mark;
                }

                if (x.title == "systill_astha_os")
                {
                    model_new.systill_astha_os = x.result;
                }

                if (x.title == "systill_cardc_os_tick")
                {
                    model_new.systill_cardc_os_tick = x.tick_mark;
                }

                if (x.title == "systill_cardc_os")
                {
                    model_new.systill_cardc_os = x.result;
                }

                if (x.title == "systill_thy_os_tick")
                {
                    model_new.systill_thy_os_tick = x.tick_mark;
                }

                if (x.title == "systill_thy_os")
                {
                    model_new.systill_thy_os = x.result;
                }

                if (x.title == "systill_cereb_os_tick")
                {
                    model_new.systill_cereb_os_tick = x.tick_mark;
                }

                if (x.title == "systill_cereb_os")
                {
                    model_new.systill_cereb_os = x.result;
                }

                if (x.title == "systill_hyperlipi_os_tick")
                {
                    model_new.systill_hyperlipi_os_tick = x.tick_mark;
                }

                if (x.title == "systill_hyperlipi_os")
                {
                    model_new.systill_hyperlipi_os = x.result;
                }

                if (x.title == "systill_kidney_os_tick")
                {
                    model_new.systill_kidney_os_tick = x.tick_mark;
                }

                if (x.title == "systill_kidney_os")
                {
                    model_new.systill_kidney_os = x.result;
                }

                if (x.title == "systill_anemia_os_tick")
                {
                    model_new.systill_anemia_os_tick = x.tick_mark;
                }

                if (x.title == "systill_anemia_os")
                {
                    model_new.systill_anemia_os = x.result;
                }

                if (x.title == "systill_eyeprob_os_tick")
                {
                    model_new.systill_eyeprob_os_tick = x.tick_mark;
                }

                if (x.title == "systill_eyeprob_os")
                {
                    model_new.systill_eyeprob_os = x.result;
                }

                if (x.title == "systill_rheu_os_tick")
                {
                    model_new.systill_rheu_os_tick = x.tick_mark;
                }

                if (x.title == "systill_rheu_os")
                {
                    model_new.systill_rheu_os = x.result;
                }

                if (x.title == "systill_inf_os_tick")
                {
                    model_new.systill_inf_os_tick = x.tick_mark;
                }

                if (x.title == "systill_inf_os")
                {
                    model_new.systill_inf_os = x.result;
                }

                if (x.title == "systill_others_os_tick")
                {
                    model_new.systill_others_od_tick = x.tick_mark;
                }

                if (x.title == "systill_others_os")
                {
                    model_new.systill_others_od = x.result;
                }

                if (x.title == "systill_medi_od")
                {
                    model_new.systill_medi_od = x.result;
                }

                if (x.title == "systill_medi_os")
                {
                    model_new.systill_medi_os = x.result;
                }

                if (x.title == "systill_remarks_od")
                {
                    model_new.systill_remarks_od = x.result;
                }

                if (x.title == "systill_remarks_os")
                {
                    model_new.systill_remarks_os = x.result;
                }

                if (x.title == "hisofstre_od_tick")
                {
                    model_new.hisofstre_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_oral_od_tick")
                {
                    model_new.hisofstre_oral_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_oral_od")
                {
                    model_new.hisofstre_oral_od = x.result;
                }

                if (x.title == "hisofstre_injectsys_od_tick")
                {
                    model_new.hisofstre_injectsys_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_injectsys_od")
                {
                    model_new.hisofstre_injectsys_od = x.result;
                }

                if (x.title == "hisofstre_injectperi_od_tick")
                {
                    model_new.hisofstre_injectperi_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_injectperi_od")
                {
                    model_new.hisofstre_injectperi_od = x.result;
                }

                if (x.title == "hisofstre_eyedrop_od_tick")
                {
                    model_new.hisofstre_eyedrop_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_eyedrop_od")
                {
                    model_new.hisofstre_eyedrop_od = x.result;
                }

                if (x.title == "hisofstre_skincr_od_tick")
                {
                    model_new.hisofstre_skincr_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_skincr_od")
                {
                    model_new.hisofstre_skincr_od = x.result;
                }

                if (x.title == "hisofstre_others_od_tick")
                {
                    model_new.hisofstre_others_od_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_others_od")
                {
                    model_new.hisofstre_others_od = x.result;
                }

                if (x.title == "hisofstre_os_tick")
                {
                    model_new.hisofstre_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_oral_os_tick")
                {
                    model_new.hisofstre_oral_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_oral_os")
                {
                    model_new.hisofstre_oral_os = x.result;
                }

                if (x.title == "hisofstre_injectsys_os_tick")
                {
                    model_new.hisofstre_injectsys_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_injectperi_os")
                {
                    model_new.hisofstre_injectperi_os = x.result;
                }

                if (x.title == "hisofstre_eyedrop_os_tick")
                {
                    model_new.hisofstre_eyedrop_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_eyedrop_os")
                {
                    model_new.hisofstre_eyedrop_os = x.result;
                }

                if (x.title == "hisofstre_skincr_os_tick")
                {
                    model_new.hisofstre_skincr_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_skincr_os")
                {
                    model_new.hisofstre_skincr_os = x.result;
                }

                if (x.title == "hisofstre_others_os_tick")
                {
                    model_new.hisofstre_others_os_tick = x.tick_mark;
                }

                if (x.title == "hisofstre_others_os")
                {
                    model_new.hisofstre_others_os = x.result;
                }

                if (x.title == "famhis_od_tick")
                {
                   model_new.famhis_od_tick=  x.result;
                }

                if (x.title == "famhis_glaucoma_od_tick")
                {
                    model_new.famhis_glaucoma_od_tick = x.result;
                }

                if (x.title == "famhis_glaucoma_od")
                {
                    model_new.famhis_glaucoma_od = x.result;
                }

                if (x.title == "famhis_cataract_od_tick")
                {
                    model_new.famhis_cataract_od_tick = x.result;
                }

                if (x.title == "famhis_cataract_od")
                {
                    model_new.famhis_cataract_od = x.result;
                }

                if (x.title == "famhis_retina_od_tick")
                {
                    model_new.famhis_retina_od_tick = x.result;
                }

                if (x.title == "famhis_retina_od")
                {
                    model_new.famhis_retina_od = x.result;
                }

                if (x.title == "famhis_squint_od_tick")
                {
                    model_new.famhis_squint_od_tick = x.result;
                }

                if (x.title == "famhis_squint_od")
                {
                    model_new.famhis_squint_od = x.result;
                }

                if (x.title == "famhis_retina_od_tick")
                {
                    model_new.famhis_retina_od_tick = x.result;
                }

                if (x.title == "famhis_retina_od")
                {
                    model_new.famhis_retina_od = x.result;
                }

                if (x.title == "famhis_squint_od_tick")
                {
                    model_new.famhis_squint_od_tick = x.result;
                }

                if (x.title == "famhis_squint_od")
                {
                    model_new.famhis_squint_od = x.result;
                }

                if (x.title == "famhis_corneal_od_tick")
                {
                    model_new.famhis_corneal_od_tick = x.result;
                }

                if (x.title == "famhis_corneal_od")
                {
                    model_new.famhis_corneal_od = x.result;
                }

                if (x.title == "famhis_opalrela_od_tick")
                {
                   model_new.famhis_opalrela_od_tick = x.result;
                }

                if (x.title == "famhis_opalrela_od")
                {
                    model_new.famhis_opalrela_od = x.result;
                }

                if (x.title == "famhis_uveal_od_tick")
                {
                   model_new.famhis_uveal_od_tick = x.result;
                }

                if (x.title == "famhis_uveal_od")
                {
                    model_new.famhis_uveal_od = x.result;
                }

                if (x.title == "famhis_neuro_od_tick")
                {
                    model_new.famhis_neuro_od_tick = x.result;
                }

                if (x.title == "famhis_neuro_od")
                {
                    model_new.famhis_neuro_od = x.result;
                }

                if (x.title == "famhis_others_od_tick")
                {
                   model_new.famhis_others_od_tick = x.result;
                }

                if (x.title == "famhis_others_od")
                {
                    model_new.famhis_others_od = x.result;
                }

                if (x.title == "famhis_os_tick")
                {
                   model_new.famhis_os_tick = x.result;
                }

                if (x.title == "famhis_glaucoma_os_tick")
                {
                    model_new.famhis_glaucoma_os_tick = x.result;
                }

                if (x.title == "famhis_glaucoma_os")
                {
                    model_new.famhis_glaucoma_os = x.result;
                }

                if (x.title == "famhis_cataract_os_tick")
                {
                   model_new.famhis_cataract_os_tick = x.result;
                }


                if (x.title == "famhis_cataract_os")
                {
                    model_new.famhis_cataract_os = x.result;
                }

                if (x.title == "famhis_retina_os_tick")
                {
                    model_new.famhis_retina_os_tick = x.result;
                }

                if (x.title == "famhis_retina_os")
                {
                    model_new.famhis_retina_os = x.result;
                }

                if (x.title == "famhis_squint_os_tick")
                {
                   model_new.famhis_squint_os_tick = x.result;
                }


                if (x.title == "famhis_squint_os")
                {
                    model_new.famhis_squint_os = x.result;
                }

                if (x.title == "famhis_corneal_os_tick")
                {
                    model_new.famhis_corneal_os_tick = x.result;
                }

                if (x.title == "famhis_corneal_os")
                {
                    model_new.famhis_corneal_os = x.result;
                }

                if (x.title == "famhis_opalrela_os_tick")
                {
                    model_new.famhis_opalrela_os_tick = x.result;
                }


                if (x.title == "famhis_opalrela_os")
                {
                    model_new.famhis_opalrela_os = x.result;
                }

                if (x.title == "famhis_uveal_os_tick")
                {
                    model_new.famhis_uveal_os_tick = x.result;
                }

                if (x.title == "famhis_uveal_os")
                {
                    model_new.famhis_uveal_os = x.result;
                }

                if (x.title == "famhis_neuro_os_tick")
                {
                    model_new.famhis_neuro_os_tick = x.result;
                }


                if (x.title == "famhis_neuro_os")
                {
                    model_new.famhis_neuro_os = x.result;
                }

                if (x.title == "famhis_others_os_tick")
                {
                    model_new.famhis_others_os_tick = x.result;
                }

                if (x.title == "famhis_others_os")
                {
                    model_new.famhis_others_os = x.result;
                }

                if (x.title == "fam_reltosub_od")
                {
                    model_new.fam_reltosub_od = x.result;
                }

                if (x.title == "fam_reltosub_os")
                {
                    model_new.fam_reltosub_os = x.result;
                }

                if (x.title == "famhisofeye_od_tick")
                {
                    model_new.famhisofeye_od_tick = x.tick_mark;
                }


                if (x.title == "famhisofeye_od")
                {
                    model_new.famhisofeye_od = x.result;
                }

                if (x.title == "famhisofeye_os_tick")
                {
                    model_new.famhisofeye_os_tick = x.tick_mark;
                }

                if (x.title == "famhisofeye_os")
                {
                    model_new.famhisofeye_os = x.result;
                }

                if (x.title == "allerg_od_tick")
                {
                    model_new.allerg_od_tick = x.tick_mark;
                }

                if (x.title == "allerg_od")
                {
                    model_new.allerg_od = x.result;
                }

                if (x.title == "allerg_os_tick")
                {
                    model_new.allerg_os_tick = x.tick_mark;
                }

                if (x.title == "allerg_os")
                {
                    model_new.allerg_os = x.result;
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
