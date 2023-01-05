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
    public class Grcode1Controller : ApiController
    {
        [HttpPost]
        [Route("api/Grcode1")]
        public IHttpActionResult Post(Grcode1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_gr_codeInsert", model);
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
        [Route("api/Grcode1/Update")]
        public IHttpActionResult Update(Grcode1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_gr_codeUpdate", model);
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
        [Route("api/Grcode1")]
        public IHttpActionResult Get()
        {
            try
            {

            
            GrcodeList_dt Grcode = new GrcodeList_dt();
            var list = DapperHelper.QueryStoredProcedure<Grcode1_dt>
                ("sp_gr_code_Select").ToList();
            Grcode.Grcode = list;
            return Ok(Grcode);

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
        [Route("api/GrcodeInsertSelect")]
        public IHttpActionResult GetSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Grcode1InsertSelect_dt>
                ("sp_gr_code_InsertSelect").ToList();
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

        [HttpPost]
        [Route("api/Grcode1/Delete")]
        public IHttpActionResult Delete(Grcode1Delete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_gr_codeDelete", model);
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
