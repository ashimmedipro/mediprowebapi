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
    public class DischargeReportController : ApiController
    {
        [HttpGet]
        [Route("api/DischargeReport/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final, int firm, string discharge_type =""  )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeReport_dt>
                ("sp_DischargeReportSelectByDateRange", new { init = init, final = final, firm = firm , discharge_type= discharge_type}).ToList();
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
        [Route("api/DischargeReport/Count")]
        public IHttpActionResult CountSearch(DateTime init, DateTime final, int firm , string discharge_type)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeReportCount_dt>
                ("sp_DischargeReportCountByDateRange", new { init = init, final = final, firm = firm,
                    discharge_type = discharge_type }).ToList();
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


        //without discharge type

        [HttpGet]
        [Route("api/DischargeReport/Count")]
        public IHttpActionResult Count(DateTime init, DateTime final, int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeReportCount_dt>
                    ("sp_DischargeReportCountByDateRange", new
                    {
                        init = init,
                        final = final,
                        firm = firm,
                        discharge_type = ""
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
