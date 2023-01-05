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
    public class BedTransactionController : ApiController
    {
        [HttpGet]
        [Route("api/BedTransactionReport/Select")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedTransaction_dt>
                ("sp_InpatientSelectForBedTransactionReport").ToList();
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
        [Route("api/BedTransactionReport/ReportSelect")]
        public IHttpActionResult Report(int ipdno, DateTime ddate)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedTransactionReport_dt>
                ("sp_BedTransactionReport", new {ipdno=ipdno, ddate=ddate }).ToList();
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
