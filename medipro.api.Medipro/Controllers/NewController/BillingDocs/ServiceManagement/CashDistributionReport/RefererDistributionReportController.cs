using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.ServiceManagement.CashDistributionReport
{
    public class RefererDistributionReportController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/RefererDistributionReport/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererDistributionReportSelect_dt>
                ("sp_RefererDistReportByDateRange", new { init = init, final = final }).ToList();
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

        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/RefererDistributionReport/Total")]
        public IHttpActionResult Total(DateTime init, DateTime final)
        {
            try { 
            var list = DapperHelper.QueryStoredProcedure<RefererDistributionReportTotal_dt>
                ("sp_RefererDistReportTotal", new { init = init, final = final }).ToList();
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
