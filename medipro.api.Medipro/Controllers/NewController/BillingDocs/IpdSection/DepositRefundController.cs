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
    public class DepositRefundController : ApiController
    {
        [HttpGet]
        [Route("api/DepositRefund/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositRefundSelect_dt>
                ("sp_InpatientSelect").ToList();
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

        [HttpPost]
        [Route("api/DepositRefund/Insert")]
        public IHttpActionResult Insert(DepositRefundInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DepositRefundInsert", model);
            return Ok();
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
