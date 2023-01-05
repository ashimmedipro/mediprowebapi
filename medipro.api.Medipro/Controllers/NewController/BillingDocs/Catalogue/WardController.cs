using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue
{
    public class WardController : ApiController
    {
        [HttpPost]
        [Route("api/Ward")]
        public IHttpActionResult Insert(Ward_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_wardInsert", model);
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
        [Route("api/Ward/Update")]
        public IHttpActionResult Update(Ward_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_wardEdit", model);
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
        [Route("api/Ward/select")]
        public IHttpActionResult Select(string search = "")
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Ward_dt>
                ("sp_wardSelectByWardName ", new { search=search}).ToList();
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
