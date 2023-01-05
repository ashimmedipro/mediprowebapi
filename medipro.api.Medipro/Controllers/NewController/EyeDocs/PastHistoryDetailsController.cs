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
    public class PastHistoryDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/PastEyeHistoryDetails")]
        public IHttpActionResult Post(PastHistoryDetails_Insert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsInsert", model);
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
        [Route("api/PastEyeHistoryDetails/Update")]
        public IHttpActionResult Update(PastHistoryDetails_Update_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsUpdate", model);
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
        [Route("api/PastEyeHistoryDetails/select")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PastHistoryDetails_Select_dt>
                ("sp_Past_Eye_History_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/PastEyeHistoryDetails/Delete")]
        public IHttpActionResult Delete(PastHistoryDetails_Delete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Past_Eye_History_detailsDelete", model);
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
        [Route("api/PastHistoryDetails/TempPastHistoryDetailsInsert")]
        public IHttpActionResult Insert(TempPastHistoryDetailsInsert_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_TempPast_Eye_History_detailsInsert", model);
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
        [Route("api/PastHistoryDetails/PastHistoryDetailsInsert")]
        public IHttpActionResult Insert(PastHistoryDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempPast_Eye_History_detailsBulkInsert", model);
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
        [Route("api/PastHistoryDetails/TempPastHistoryDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(PastHistoryDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempPast_Eye_History_detailsDelete", model);
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
