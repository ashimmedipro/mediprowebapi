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
    public class DischargeReportEntryController : ApiController
    {
        [HttpGet]
        [Route("api/Billing/IpdSection/DischargeReprotEntry/Select")]
        public IHttpActionResult Search(DateTime init, DateTime final, string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeReportEntry_dt>
                ("sp_InpatientAdministionFormSelectByDate", new { init = init , final = final , search = search }).ToList();
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
        [Route("api/Billing/IpdSection/DischargeReprotEntry/Select")]
        public IHttpActionResult Get(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeReportEntry_dt>
                ("sp_InpatientAdministionFormSelectByDate", new { init = init, final = final, search = "" }).ToList();
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
