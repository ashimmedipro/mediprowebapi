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
    public class RevertDischargePostController : ApiController
    {
        [HttpPost]
        [Route("api/IpdSection/RevertDischargePost")]
        public IHttpActionResult Post(RevertDischargePost_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_RevertDischargePost", model);
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
