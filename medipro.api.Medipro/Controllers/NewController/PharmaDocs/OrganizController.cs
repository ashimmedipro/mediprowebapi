using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class OrganizController : ApiController
    {
        [HttpPost]
        [Route("api/Organiz/Insert")]
        public IHttpActionResult Post(Organiz_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_ORGANIZ_Insert", model);
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


        //
        [HttpPost]
        [Route("api/Organiz/Update")]
        public IHttpActionResult Update(Organiz_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_ORGANIZ_Update", model);
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


        //
        [HttpGet]
        [Route("api/Organiz/select")]
        public IHttpActionResult Get(string search="")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<OrganizSelect_dt>
                    ("sp_ORGANIZ_Select", new { search = search }).ToList();
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


        //
        [HttpPost]
        [Route("api/Organiz/Delete")]
        public IHttpActionResult Delete(OrganizDelete_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_ORGANIZ_Delete ", model);
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
