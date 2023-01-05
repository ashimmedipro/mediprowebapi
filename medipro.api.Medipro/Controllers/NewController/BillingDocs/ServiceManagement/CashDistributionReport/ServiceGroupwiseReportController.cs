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
    public class ServiceGroupwiseReportController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/ServiceGroupwiseReport/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceGroupwiseReport_dt>
                ("sp_ServiceGrpwiseReportSelect", new { init = init, final = final, firm = firm }).ToList();
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
