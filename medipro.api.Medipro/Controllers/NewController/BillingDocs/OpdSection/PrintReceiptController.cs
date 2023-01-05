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
    public class PrintReceiptController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/PrintReceipt/Select")]
        public IHttpActionResult Select(string r_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintReceiptSelect_dt>
                ("sp_PrintReceiptSelectByRno", new { r_no = r_no }).ToList();
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
        [Route("api/OpdSection/PrintReceipt/Service/Select")]
        public IHttpActionResult ServiceSelect(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintReceiptServiceSelect_dt>
                ("sp_ServiceSelectByInvno", new { inv_no= inv_no }).ToList();
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
