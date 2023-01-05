using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.AccountDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.AccountDocs
{
    public class sbcode1Controller : ApiController
    {
        [HttpPost]
        [Route ("api/Sbcode1")]
        public IHttpActionResult Post(sbcode1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SB_CODEInsert", model);
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
        [Route("api/Sbcode1/Update")]
        public IHttpActionResult Update(sbcode1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SB_CODEUpdate", model);
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
        [Route("api/Sbcode1")]
        public IHttpActionResult Select(int gr_code)
        {
            try
            {

            
            sbcode1LIst_dt Sbcode = new sbcode1LIst_dt();
            var list = DapperHelper.QueryStoredProcedure<sbcode1Select_dt>
                ("sp_SB_CODESelect", new { gr_code  = gr_code }).ToList();
            Sbcode.Sbcode = list;
            return Ok(Sbcode);
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
        [Route("api/Sbcodes1")]
        public IHttpActionResult SelectAll(int gr_code)
        {
            try
            {

            
            sbcode1LIst_dt Sbcode = new sbcode1LIst_dt();
            var list = DapperHelper.QueryStoredProcedure<sbcode1Select_dt>
                ("sp_SB_CODESelect", new{ gr_code = 1}).ToList();
            Sbcode.Sbcode = list;
            return Ok(Sbcode);
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
        [Route("api/Sbcode1/Delete")]
        public IHttpActionResult Delete(sbcode1Delete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SB_CODEDelete", model);
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
