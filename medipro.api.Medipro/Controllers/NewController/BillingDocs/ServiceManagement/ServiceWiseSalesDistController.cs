using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class ServiceWiseSalesDistController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/ServicewiseCashDistribution/Select")]
        public IHttpActionResult DateSelect(DateTime initdate, DateTime finaldate, int firm, int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DeptWiseServiceDistribution_dt>
                ("sp_DeptwiseSalesSelectByDaterange", new { initdate = initdate, finaldate = finaldate, firm=firm, grpid=grpid}).ToList();
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
