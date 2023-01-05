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
    public class OcularInvestigationDetailController : ApiController
    {
        
            /*[HttpPost]
            [Route("api/OcularInvestigationDetail")]
            public IHttpActionResult Post(OcularInvestigationDetailInsert_dt model)
            {
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailInsert", model);
                return Ok();
            }

            [HttpPost]
            [Route("api/OcularInvestigationDetail/Update")]
            public IHttpActionResult Update(OcularInvestigationDetailUpdate_dt model)
            {
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailUpdate", model);
                return Ok();
            }*/

            [HttpGet]
            [Route("api/OcularInvestigationDetail")]
            public IHttpActionResult Get(string mrdno)
            {
            try
            {

            
                var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailSelect_dt>
                    ("sp_ocular_investigation_DetailSelect", new { mrdno = mrdno }).ToList();
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
            [Route("api/OcularInvestigationDetail/delete")]
            public IHttpActionResult Delete(OcularInvestigationDetailDelete_dt model)
            {
            try
            {

            
                DapperHelper.ExecuteStoredProcedure("sp_ocular_investigation_DetailDelete", model);
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
            [Route("api/OcularInvestigationSummary")]
            public IHttpActionResult GetAll(string mrdno)
            {
            try
            {

            
                var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailSelect_dt>
                    ("sp_ocular_investigation_DetailSelect", new { mrdno = mrdno }).ToList();

                OcularInvestigationSummary_dt model_new = new OcularInvestigationSummary_dt();
                foreach (var x in list)
                {
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

                    if (x.title == "aphakia_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.aphakia_od_tick = x.tick_mark;

                    }

                    if (x.title == "cataract_surg_complications_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.cataract_surg_complications_od_tick = x.tick_mark;

                    }

                    if (x.title == "tco_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.tco_od_tick = x.tick_mark;

                    }

                    if (x.title == "phthisis_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.phthisis_od_tick = x.tick_mark;

                    }

                    if (x.title == "onchcercia_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.onchcercia_od_tick = x.tick_mark;

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

                    if (x.title == "armd_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.armd_od_tick = x.tick_mark;

                    }
                    if (x.title == "other_posterior_od_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.other_posterior_od_tick = x.tick_mark;

                    }
                    if (x.title == "cns_od")
                    {
                        model_new.cns_od = x.result;
                        // model_new.cns_od = x.tick_mark;

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
                    if (x.title == "aphakia_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.aphakia_os_tick = x.tick_mark;

                    }

                    if (x.title == "cataract_surg_complications_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.cataract_surg_complications_os_tick = x.tick_mark;

                    }

                    if (x.title == "tco_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.tco_os_tick = x.tick_mark;
                    }

                    if (x.title == "phthisis_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.phthisis_os_tick = x.tick_mark;

                    }

                    if (x.title == "onchcercia_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.onchcercia_os_tick = x.tick_mark;

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

                    if (x.title == "armd_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.armd_os_tick = x.tick_mark;
                    }

                    if (x.title == "other_posterior_os_tick")
                    {
                        //model_new.anterioracdepth_od = x.result;
                        model_new.other_posterior_os_tick = x.tick_mark;
                    }

                    if (x.title == "cns_os")
                    {
                        model_new.cns_os = x.result;
                        // model_new.aphakia_os_tick = x.tick_mark;
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
                        model_new.followup_od = x.result;
                        // model_new.followup_od = x.tick_mark;

                    }

                    if (x.title == "followup_os")
                    {
                        model_new.followup_os = x.result;
                        //  model_new.followup_os = x.tick_mark;
                    }

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

                    if (x.title == "followup_od_tick")
                    {
                        model_new.followup_od_tick = x.tick_mark;
                    }

                    if (x.title == "followup_os_tick")
                    {
                        model_new.followup_os_tick = x.tick_mark;
                    }
                }
                return Ok(model_new);

                // return  Ok( new { list = model_new });
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

        /* [HttpGet]
         [Route("api/OcularInvestigationaAll")]
         public IHttpActionResult GetAl(int mrdno)
         {
             //var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailSelect_dt>
                 //("sp_ocular_investigation_DetailSelect", new { mrdno = mrdno }).ToList();

             List<OcularInvestigationDetailSelect_dt> model1 = new List<OcularInvestigationDetailSelect_dt>();
             var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailSelect_dt>
                ("sp_ocular_investigation_DetailSelect", new { mrdno = mrdno }).ToList();

             foreach (var item in list)
             {
                 if (item.tick_mark)
                 {
                     model1.Add(item);
                 }

                 if((item.result is null?"":item.result).Length>0)
                 {
                     model1.Add(item);
                 }
             }
             return Ok(model1);
         }*/


        [HttpPost]
        [Route("api/OcularInvestigationDetails/TempOcularInvestigationDetailsInsert")]
        public IHttpActionResult Insert(TempOcularInvestigationDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Investigation_DetailInsert", model);
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
        [Route("api/OcularInvestigationDetails/OcularInvestigationDetailsBulkInsert")]
        public IHttpActionResult Insert(OcularInvestigationDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Investigation_DetailBulkInsert     ", model);
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
        [Route("api/OcularInvestigationDetails/TempOcularInvestigationDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(TempOcularInvestigationDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOcular_Investigation_DetailDelete", model);
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


    }     

    }
