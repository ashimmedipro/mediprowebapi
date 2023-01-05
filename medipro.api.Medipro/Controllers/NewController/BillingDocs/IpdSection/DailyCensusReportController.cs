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
    public class DailyCensusReportController : ApiController
    {
        [HttpGet]
        [Route("api/IpdSection/DailyCensusReport/Select")]
        public IHttpActionResult Select(DateTime ddate)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DailyCensusReport_dt>
                ("sp_DailyCensusPatientSummary", new { ddate = ddate }).ToList();
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
        [Route("api/IpdSection/DailyCensusReport/WardwiseSelect")]
        public IHttpActionResult WardwiseSelect(DateTime ddate)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DailyCensusReportWardWise_dt>
                ("sp_DailyCensusWardSummary ", new { ddate = ddate }).ToList();
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
        [Route("api/IpdSection/DailyCensusReport/RefererWiseSelect")]
        public IHttpActionResult RefererWiseSelect(DateTime init,int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DailyCensusReportRefererWise_dt>
                ("sp_DailyCensusRefererSummry ", new { init = init, firm=firm }).ToList();
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

        //[HttpGet]
        //[Route("api/RefererSelect")]
        //public IHttpActionResult RefererGet()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<RefererGet_dt>
        //        ("sp_DailyCensusGetReferer ").ToList();//--change 
        //    return Ok(list);
        //}

        [HttpGet]
        [Route("api/IpdSection/DailyCensusReport/Bed/Total")]
        public IHttpActionResult TotalBed()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<GetTotalBed_dt>
                ("sp_GetTotalBed ").ToList();
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
