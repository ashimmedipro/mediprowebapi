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
    public class AdvanceClearReportController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/AdvanceClearReport/Select")]
        public IHttpActionResult Select(DateTime initdate, DateTime finaldate)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<AdvanceClearReport_dt>
                ("sp_AdvClrRptSelectByDateRng", new { initdate = initdate, finaldate = finaldate }).ToList();
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
