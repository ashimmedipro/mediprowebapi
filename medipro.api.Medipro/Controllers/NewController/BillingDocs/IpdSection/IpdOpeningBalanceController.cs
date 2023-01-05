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
    public class IpdOpeningBalanceController : ApiController
    {
        [HttpGet]
        [Route("api/IpdOpeningBalance/Select/Inpatient")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdOpeningBalanceSelectInpatient_dt>
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
        [Route("api/IpdOpeningBalance/Insert")]
        public IHttpActionResult Insert(IpdOpeningBalanceInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_IpdOpeningBalanceOpdbillInsert", model);
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
