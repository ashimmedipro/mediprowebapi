using medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection;
using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class DeathCertificateReportController : ApiController
    {
        [HttpGet]
        [Route("api/IpdSection/DeathCertificateReport")]
        public IHttpActionResult Get(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DeathCertificateReport_dt>
                ("sp_DeathCertificateReportByDateRange", new { init=init,final=final, firm=firm }).ToList();
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
