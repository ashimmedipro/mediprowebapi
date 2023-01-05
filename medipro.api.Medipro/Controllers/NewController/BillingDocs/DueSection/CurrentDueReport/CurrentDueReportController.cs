using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.DueSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.CurrentDueReport
{
    public class CurrentDueReportController : ApiController
    {
        //[HttpGet]
        //[Route("api/RefererSelect")]
        //public IHttpActionResult RefererSelect()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<CurrDueRepRefererSelect_dt>
        //        ("sp_CurrentDueReportRefererSelect").ToList();//change 
        //    return Ok(list);
        //}

        [HttpGet]
        [Route("api/DueSection/CurrentDueReport/Select")]
        public IHttpActionResult Select(DateTime ddate, string p_type, int firm )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CurrentDueReportSelect_dt>
                ("sp_CurrentDueReportSelect", new { ddate=ddate, p_type=p_type,firm=firm }).ToList();
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
        [Route("api/DueSection/topdbilldue/Select")]
        public IHttpActionResult topdbillSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<tOpdBilldue1Select_dt>
                ("sp_tOpdbillDue1Select").ToList();
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
        [Route("api/DueSection/topdbilldue/Total")]
        public IHttpActionResult Total()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<tOpdBilldue1Total_dt>
                ("sp_tOpdbillDue1TotalSelect").ToList();
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
