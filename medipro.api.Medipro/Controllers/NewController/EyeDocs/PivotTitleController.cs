using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs.PivotTitle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class PivotTitleController : ApiController
    {
        [HttpGet]
        [Route("api/VisionandRefractionDetails/Title/Select")]
        public IHttpActionResult Get(DateTime init, DateTime final )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<VisionandRefractionDetailsPivot_dt>
                ("sp_VisionvisionandRefractionDetailsPivotSelect", new { init=init, final=final}).ToList();
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


        [HttpGet]
        [Route("api/OqlSurvey/Title/Select")]
        public IHttpActionResult OqlGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OQLSurvey_dt>
                ("sp_OqlSurveyDetailsPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/MedicalOcularHistory/Title/Select")]
        public IHttpActionResult MedicalOcularHisGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MedicalOcularHistoryPivot_dt>
                ("sp_MedicalOcularHistoryDetailsPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/LabExaminationDetails/Title/Select")]
        public IHttpActionResult LabExaminationDetailsGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<LabExaminationDetailsPivot_dt>
                ("sp_LabExaminationDetailsPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/FearandPreception/Title/Select")]
        public IHttpActionResult FearandPreceptionGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<FearandPreception_dt>
                ("sp_FearAndPreceptionPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/EyeDonation/Title/Select")]
        public IHttpActionResult EyeDonationGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeDonationPivot_dt>
                ("sp_EyeDonationPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/CommonEyeProblem/Title/Select")]
        public IHttpActionResult CommonEyeProblemGet(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CommonEyeProblem_dt>
                ("sp_ChiefComplainPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/SmokingHistoryDetails/Title/Select")]
        public IHttpActionResult SmokingHistoryDetails(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SmokingHistoryDetailsPivot_dt>
                ("sp_SmokingHistoryPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/PastEyeHistory/Title/Select")]
        public IHttpActionResult PastEyeHistory(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PastEyeHistoryPivot_dt>
                ("sp_PastEyeHistoryPivotSelect", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/OcularExaminationDetail/Title/Select")]
        public IHttpActionResult OcularExaminationDetail(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularExaminationDetailPivot_dt>
                ("sp_OcularExaminationPivotSelect", new { init = init, final = final }).ToList();
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


        [HttpGet]
        [Route("api/OcularinvestigationDetail/Title/Select")]
        public IHttpActionResult OcularInvDetail(DateTime init, DateTime final)
        {

            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OcularInvestigationDetailPivot_dt>
                ("sp_OcularInvestigationPivotSelect", new { init = init, final = final }).ToList();
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




    }
}
