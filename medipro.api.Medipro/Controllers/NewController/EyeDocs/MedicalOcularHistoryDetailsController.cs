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
    public class MedicalOcularHistoryDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/MedicalOcularHistoryDetails/Select")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MedicalOcularHistory_details_dt>
                ("sp_MedicalOcularHistory_detailsSelect", new { mrdno = mrdno }).ToList();
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
        [Route("api/MedicalOcularHistoryDetails/Delete")]
        public IHttpActionResult Delete(MedicalOcularHistory_DetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_MedicalOcularHistory_detailsDelete", model);
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
        [Route("api/MedicalOcularHistory/TempMedicalOcularHistoryDetailsInsert")]
        public IHttpActionResult Insert(TempMedicalOcularHistoryDetailsInsert_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_TempMedicalOcularHistory_detailsInsert", model);
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
        [Route("api/MedicalOcularHistory/MedicalOcularHistoryDetailsBulkInsert")]
        public IHttpActionResult Insert(MedicalOcularHistoryDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempMedicalOcularHistory_detailsBulkInsert    ", model);
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
        [Route("api/MedicalOcularHistory/TempMedicalOcularHistoryDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(MedicalOcularHistoryDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempMedicalOcularHistory_detailsDelete", model);
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
