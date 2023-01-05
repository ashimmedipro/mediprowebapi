using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.DueSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.DueSection
{
    public class PeriodicDueLogController : ApiController
    {
        [HttpGet]
        [Route("api/DueSection/PeriodicDueLog/OpdBillDueReport")]
        public IHttpActionResult Report(DateTime init, DateTime final, string search,int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdBillReport_dt>
                ("sp_OpdBillDueReport ", new { init = init, final = final, search = search,firm=firm }).ToList();
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
        [Route("api/DueSection/PeriodicDueLog/OpdBillDueReportSum")]
        public IHttpActionResult Sum(DateTime init, DateTime final, string search, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdBillReportSum_dt>
                ("sp_OpdBillDueSumReport ", new { init = init, final = final, search = search, firm = firm }).ToList();
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
        [Route("api/DueSection/PeriodicDueLog/OpdBillDueReport1")]
        public IHttpActionResult Report1(DateTime init, DateTime final, string search, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdBillReport_dt>
                ("sp_OpdBillDueReport1 ", new { init = init, final = final, search = search, firm = firm }).ToList();
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
        [Route("api/DueSection/PeriodicDueLog/OpdBillDueReport1Sum")]
        public IHttpActionResult Report1Sum(DateTime init, DateTime final, string search, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdBillReportSum_dt>
                ("sp_OpdBillDueSumReport1 ", new { init = init, final = final, search = search, firm = firm }).ToList();
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
