using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection
{
    public class BedBookingController : ApiController
    {
        [HttpGet]
        [Route("api/BedBooking/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedBookingSelectInpatient_dt>
                ("sp_InpatientSelect").ToList();
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
        [Route("api/BedBooking/SelectBedRack")]
        public IHttpActionResult SelectBedRack()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedBookingSelectInpatient_dt>
                ("sp_BedrackSelect").ToList();
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
        [Route("api/BedBooking/BedRecInsert")]
        public IHttpActionResult Insert(BedBookingBedRecInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_BedBookInsert", model);
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
