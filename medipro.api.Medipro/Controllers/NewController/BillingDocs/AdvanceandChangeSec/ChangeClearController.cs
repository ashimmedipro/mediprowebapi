using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.AdvanceandChangeSec
{
    public class ChangeClearController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/ChangeClear/Patient/Select")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ChangeClearPatientGet_dt>
                ("sp_PatientListChange").ToList();
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
        [Route("api/OpdSection/ChangeClear/Update")]
        public IHttpActionResult Update(UpdateChange_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PatientChangeUpdate", model);
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
