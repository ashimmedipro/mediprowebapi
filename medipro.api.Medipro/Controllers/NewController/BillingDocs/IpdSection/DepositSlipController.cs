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
    public class DepositSlipController : ApiController
    {
        [HttpGet]
        [Route("api/DepositSlip/Select")]
        public IHttpActionResult Select(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositSlip_dt>
                ("sp_DepositSlip", new { inv_no = inv_no }).ToList();
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
    }
}
