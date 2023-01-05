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
    public class DepositReportController : ApiController
    {
        [HttpGet]
        [Route("api/DepositReport/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositReportSelect_dt>
                ("sp_DepositReportSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/DepositReport/SelectTotal")]
        public IHttpActionResult Total(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositReportGetTotal_dt>
                ("sp_DepositReportSelectTotal", new { init = init, final = final, firm = firm }).ToList();
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
