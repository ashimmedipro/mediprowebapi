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
    public class IpdRegistrationRegisterController : ApiController
    {
        [HttpGet]
        [Route("api/IpdRegistrationRegister/Select")]
        public IHttpActionResult SelectByDateRange(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdRegistrationRegisterSelectByDateRange_dt>
                ("sp_IpdRegistrationSelectByDateRange", new { init = init, final = final }).ToList();
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
        [Route("api/IpdRegistrationRegisterCount/Select")]
        public IHttpActionResult CountGetByDateRange(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<IpdRegistrationRegisterCountSelectByDateRange_dt>
                ("sp_IpdRegistrationCountByDateRange", new { init = init, final = final }).ToList();
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
