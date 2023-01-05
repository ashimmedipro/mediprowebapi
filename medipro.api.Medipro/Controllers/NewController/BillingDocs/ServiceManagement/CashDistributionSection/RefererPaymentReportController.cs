using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.ServiceManagement.CashDistributionSection
{
    public class RefererPaymentReportController : ApiController
    {
        [HttpGet]
        [Route("api/ServiceManagement/CashDistributionSection/RefererPaymentReprot")]
        public IHttpActionResult Select(DateTime init, DateTime final, string search, int refid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererPaymentMethod_dt>
                ("sp_RefererVoucherPaidReport", new { init=init, final=final, search=search, refid=refid}).ToList();
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
