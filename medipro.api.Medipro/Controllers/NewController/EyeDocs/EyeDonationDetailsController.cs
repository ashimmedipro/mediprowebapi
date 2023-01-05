using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static medipro.api.Medipro.Models.NewModels.EyeDocs.EyeDonationDetails;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class EyeDonationDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/EyeDonationDetails")]
        public IHttpActionResult Update(EyeDonationDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_EyeDonation_details_Insert", model);
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
        [Route("api/EyeDonationDetailsSelect")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeDonationDetailsSelect_dt>
                ("sp_EyeDonation_details_Select", new { mrdno = mrdno }).ToList();
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
        [Route("api/EyeDonationDetails/Delete")]
        public IHttpActionResult Delete(EyeDonationDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_EyeDonation_details_Delete", model);
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
        [Route("api/EyeDonationDetails/TempEyeDonationDetailsInsert")]
        public IHttpActionResult Insert(TempEyeDonationDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempEyeDonation_detailsInsert", model);
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
        [Route("api/EyeDonationDetails/EyeDonationDetailsBulkInsert")]
        public IHttpActionResult Insert(EyeDonationDetailsBulkInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempEyeDonation_detailsBulkInsert ", model);
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
        [Route("api/QolSurvey/TempEyeDonationDetails/Delete")]
        public IHttpActionResult TempCommonEyeProblemDetailsDelete(TempEyeDonationDetailsDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_TempEyeDonation_details_Delete", model);
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
