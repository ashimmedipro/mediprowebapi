using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class DueClearController : ApiController
    {
        [HttpGet]
        [Route("api/DueClear/ViewData")]
        public IHttpActionResult ViewData(int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DueClearView_dt>
                ("sp_DueClearView", new { firm = firm }).ToList();
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


        [HttpGet]
        [Route("api/DueClear/SelectInvNo")]
        public IHttpActionResult SelectInvNo(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DueClearSelectInvno_dt>
                ("sp_DueClearSelectInvNo", new { inv_no = inv_no }).ToList();
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
        [Route("api/DueClear")]
        public IHttpActionResult Insert(DueClear_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DueClearInsert", model);
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
