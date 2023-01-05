using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class OpdbillForPrescriptionController : ApiController
    {
        [HttpGet]
        [Route("api/OPDBillForPrescriptionSelect/{consid}/{init}/{final}/{grpid}")]
        public IHttpActionResult get(int consid, DateTime init, DateTime final, int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdbillForPrescriptionSelect_dt>
                ("sp_OPDBillForPrescriptionSelect",
                new { consid = consid, init = init, final = final, grpid = grpid }).ToList();
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
