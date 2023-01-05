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


    public class SmokingHistoryDetailsController : ApiController
    {

        [HttpPost]
        [Route("api/SmokingHistoryDetails/Insert")]
        public IHttpActionResult Update(SmokingHistoryDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsInsert", model);
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
        [Route("api/SmokingHistoryDetails/Update")]
        public IHttpActionResult Update(SmokingHistoryDetailsUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsUpdate", model);
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
        [Route("api/SmokingHistoryDetails")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SmokingHistoryDetailsSelect_dt>
                ("sp_smoking_history_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/SmokingHistoryDetails/Delete")]
        public IHttpActionResult Delete(SmokingHistoryDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_smoking_history_detailsDelete", model);
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


        //alcohol smoking history kes

        [HttpPost]
        [Route("api/AlcoholSmokingHistory/TempAlcoholSmokingHistoryDetailsInsert")]
        public IHttpActionResult Insert(TempAlcoholSmokingHistoryDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempSmoking_History_detailsInsert", model);
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
        [Route("api/AlcoholSmokingHistory/AlcoholSmokingHistoryDetailsBulkInsert")]
        public IHttpActionResult Insert(AlcoholSmokingHistoryDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempSmoking_History_detailsBulkInsert  ", model);
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
        [Route("api/AlcoholSmokingHistory/TempAlcoholSmokingHistoryDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(AlcoholSmokingHistoryDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempSmoking_History_detailsDelete", model);
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
