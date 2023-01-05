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
    public class IpdTrialController : ApiController
    {
        [HttpPost]
        [Route("api/IpdTrial/Insert")]
        public IHttpActionResult Insert(IpdTrial_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_IPDTrail", model);
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

        [HttpGet]
        [Route("api/IpdTrial/Select")]
        public IHttpActionResult Select(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdTrialSelect_dt>
                ("sp_IpdTrialSelect",new {userid=userid }).ToList();
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
        [Route("api/IpdTrial/Total")]
        public IHttpActionResult Total(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdTrialTotal_dt>
                ("sp_IpdTrialGetTotal", new { userid = userid }).ToList();
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
