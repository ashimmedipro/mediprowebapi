using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.OpdSection
{
    public class ClaimCodeGenerateReportController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/ClaimCodeGenerateReport/Select")]
        public IHttpActionResult SelectBySearch( DateTime init, DateTime final, int start_claim, int end_claim, bool ddate, string search, bool ssf)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ClaimCodeGenerateReport_dt>
                ("sp_InsuranceClaimCodeByDate", new { init = init, final = final, start_claim = start_claim, end_claim= end_claim,
                    ddate = ddate, search= search , ssf = ssf }).ToList();
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
        [Route("api/OpdSection/ClaimCodeGenerateReport/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final, int start_claim, int end_claim, bool ddate, bool ssf)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ClaimCodeGenerateReport_dt>
                    ("sp_InsuranceClaimCodeByDate", new
                    {
                        init = init,
                        final = final,
                        start_claim = start_claim,
                        end_claim = end_claim,
                        ddate = ddate,
                        search = "",
                        ssf = ssf
                    }).ToList();
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
