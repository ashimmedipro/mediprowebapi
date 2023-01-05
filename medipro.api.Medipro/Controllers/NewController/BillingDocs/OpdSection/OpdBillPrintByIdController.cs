using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.OpdSection
{
    public class OpdBillPrintByIdController : ApiController
    {
        [HttpGet]
        [Route("api/OpdSection/OpdBillPrintById")]
        public IHttpActionResult Print(string inv_no)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<OpdBillPrintById_dt>
                    ("sp_opdbillprintById", new { inv_no = inv_no }).ToList();
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
