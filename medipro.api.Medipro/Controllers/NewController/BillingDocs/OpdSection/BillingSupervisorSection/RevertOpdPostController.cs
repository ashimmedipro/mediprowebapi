using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.Billing_Supervisor_Section;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.OpdSection.BillingSupervisorSection
{
    public class RevertOpdPostController : ApiController
    { 
        

        [HttpPost]
        [Route("api/OpdSection/BillingSupervisorSection/Insert")]
        public IHttpActionResult PostOpdTempRec(RevertOpdBill_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_RevertOpdBillPost", model);
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
