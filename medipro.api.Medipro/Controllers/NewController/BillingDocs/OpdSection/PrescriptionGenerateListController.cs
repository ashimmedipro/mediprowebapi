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
    public class PrescriptionGenerateListController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/OpdRegistration/PrescriptionGenerate/Select")]
        public IHttpActionResult List(int consid, DateTime init, DateTime final, int grpid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<PrescriptionGenerateList_dt>
                    ("sp_OPDBillForPrescriptionSelect", new { consid = consid, init = init, final = final, grpid = grpid }).ToList();
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
