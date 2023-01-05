using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static medipro.api.Medipro.Models.NewModels.EyeDocs.QolSurveyDetails;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class QolSurveyDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/QolSurveyDetails")]
        public IHttpActionResult Update(QolSurveyDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_OqlSurvey_details_Insert", model);
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
        [Route("api/QolSurveyDetailsSelect")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<QolSurveyDetailsSelect_dt>
                ("sp_OqlSurvey_details_Select", new { mrdno = mrdno }).ToList();
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
        [Route("api/QolSurveyDetails/Delete")]
        public IHttpActionResult Delete(QolSurveyDetailsDelete_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_OqlSurvey_details_Delete", model);
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

        //temp

        [HttpPost]
        [Route("api/QolSurveyDetails/TempQolSurveyDetailsInsert")]
        public IHttpActionResult Insert(TempQolSurveyDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOqlSurvey_detailsInsert", model);
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
        [Route("api/QolSurveyDetails/QolSurveyDetailsBulkInsert")]
        public IHttpActionResult Insert(QolSurveyDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOqlSurvey_detailsBulkInsert", model);
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
        [Route("api/QolSurvey/TempQolSurveyDetailsDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(TempQolSurveyDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempOqlSurvey_details_Delete", model);
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
