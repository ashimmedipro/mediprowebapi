using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.AdvanceandChangeSec
{
    public class AdvanceReceiptPrintController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/AdvanceReceipt/Select")]
        public IHttpActionResult Select(int sn)
        {
            try
            {

            
        
            var list = DapperHelper.QueryStoredProcedure<AdvanceReceiptPrint_dt>
                ("sp_AdvanceReceiptPrintGetBySn", new { sn=sn}).ToList();
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
