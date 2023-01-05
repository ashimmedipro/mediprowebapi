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
    public class IpdRegisterationSlipController : ApiController
    {
        [HttpGet]
        [Route("api/IpdRegistrationSlip/Select")]
        public IHttpActionResult SlipSelect(int ipdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdRegistrationSlip_dt>
                ("sp_IPDRegSlip", new { ipdno = ipdno }).ToList();
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
