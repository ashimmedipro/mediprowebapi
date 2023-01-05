using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.Module_Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.Module_Tables
{
    public class MemberController : ApiController
    {
        [HttpPost]
        [Route("api/MemberInsert")]
        public IHttpActionResult Post(MemberInsert_dt model)
        {
            try
            {

                DapperHelper.ExecuteStoredProcedure("sp_Member_Insert", model);
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

        [HttpPost]
        [Route("api/MemberUpdate")]
        public IHttpActionResult MemUpdate(MemberInsert_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_Member_Update", model);
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
