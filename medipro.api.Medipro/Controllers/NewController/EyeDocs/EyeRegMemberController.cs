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
    public class EyeRegMemberController : ApiController
    {
        [HttpPost]
        [Route("api/EyeRegistration/Member/Update")]
        public IHttpActionResult Update(EyeRegMemberUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_EyeRegMemberUpdate", model);
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

        [HttpGet]
        [Route("api/EyeRegistration/Member/Select")]
        public IHttpActionResult get(int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeRegMemberSelect_dt>
                ("sp_EyeRegMemberGetbyHospid", new { hospid = hospid }).ToList();
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
