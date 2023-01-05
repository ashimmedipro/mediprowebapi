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
    public class BedBookedClearController : ApiController
    {
        [HttpGet]
        [Route("api/BedBookedClear/Select")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedBookedClear_dt>
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
        [Route("api/BedBookedClear/Insert")]
        public IHttpActionResult Insert(BookClearBedRecInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_BedBookClear_Insert", model);
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
