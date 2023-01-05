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
    public class DepositRefundPostLedgerController : ApiController
    {
        [HttpGet]
        [Route("api/Deposit/RefundPostLedger")]
        public IHttpActionResult Select(DateTime ddate, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositRefundPostLedger_dt>
                ("sp_DepositRefundPostLedgerSelect", new { ddate = ddate, firm=firm }).ToList();
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
