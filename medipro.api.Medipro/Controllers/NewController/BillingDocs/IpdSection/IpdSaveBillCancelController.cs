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
    public class IpdSaveBillCancelController : ApiController
    {
        [HttpPost]
        [Route("api/IpdSection/IpdSaveBillCancel")]
        public IHttpActionResult Update(IpdSaveBillCancel_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_IpdSaveBillCancel", model);
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
