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
    public class GeneralBillingDueController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/GenralBilling/Due")]
        public IHttpActionResult FormSelect(int  hospid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<GenralBillingDue_dt>
                    ("sp_opdbilldueCheckByHospid", new { hospid = hospid }).ToList();
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
