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
    public class DeathCertificateController : ApiController
    {
        [HttpGet]
        [Route("api/DeathCertificate/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DeathCertificateSelectInpatient_dt>
                ("sp_DeathCertificateGetInpatient").ToList();
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
        [Route("api/DeathCertificate/Insert")]
        public IHttpActionResult Insert(DeathCertificateInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DeathCertificateInsert", model);
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
