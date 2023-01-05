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
    public class PatientwiseCashDistributionController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/PatientwiseCashDistribution/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PatientwiseCashDistribution_dt>
                ("sp_PatientwaiseCashDistReportSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/PatientwiseCashDistribution/Patient/Search")]
        public IHttpActionResult Search(DateTime init, DateTime final, int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<PatientwiseCashDistribution_dt>
                    ("sp_PatientwaiseCashDistReportPatientSearch", new { init = init, final = final, firm = firm }).ToList();
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
