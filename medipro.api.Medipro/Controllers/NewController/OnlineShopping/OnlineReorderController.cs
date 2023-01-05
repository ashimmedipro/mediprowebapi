using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.OnlineShopping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.OnlineShopping
{
    public class OnlineReorderController : ApiController
    {
        [HttpPost]
        [Route("api/OnlineShopping/Reorder/Insert")]
        public IHttpActionResult PostOpdTempRec(OnlineReorder_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_OnlineReorder", model);
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
