using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static medipro.api.Medipro.Models.NewModels.EyeDocs.FearAndPreceptionDetails;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class FearAndPreceptionDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/FearAndPreceptionDetails")]
        public IHttpActionResult Insert(FearAndPreceptionDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_FearAndPreception_details_Insert", model);
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
        [Route("api/FearAndPreceptionDetailsSelect")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<FearAndPreceptionDetailsSelect_dt>
                ("sp_FearAndPreception_detials_Select", new { mrdno = mrdno }).ToList();
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
        [Route("api/FearAndPreceptionDetails/Delete")]
        public IHttpActionResult Delete(FearAndPreceptionDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_FearAndPreception_detials_Delete", model);
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
        [Route("api/FearAndPreception/TempFearAndPreceptionDetailsInsert")]
        public IHttpActionResult Insert(TempFearAndPreceptionDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempFearAndPreception_detailsInsert", model);
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
        [Route("api/FearAndPreception/FearAndPreceptionDetailsBulkInsert")]
        public IHttpActionResult Insert(FearAndPreceptionDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempFearAndPreception_detailsBulkInsert     ", model);
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
        [Route("api/FearAndPreception/TempFearAndPreceptionDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(TempFearAndPreceptionDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempFearAndPreception_details_Delete", model);
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
