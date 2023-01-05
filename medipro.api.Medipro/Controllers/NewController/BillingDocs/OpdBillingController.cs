using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class OpdBillingController:ApiController
    {

        [HttpGet]
        [Route("api/getTempOpdRecByUserid")]
        public IHttpActionResult GetTempOpdRecByUserid(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<OpdTmpGet_dt>
                ("sp_tmpOpdRecSelect", new { userid = userid }).ToList();
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
        [Route("api/tempOpdRecInsert")]
        public IHttpActionResult PostOpdTempRec(OpdTempInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tmpOpdRecInsert", model);
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
        [Route("api/tempOpdRecInsert/Update")]
        public IHttpActionResult EditOpdTempRec(OpdTempInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tmpOpdRecUpdate", model);
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
        [Route("api/opdBillInsert")]
        public IHttpActionResult PostOpdBill(OpdBillInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Opdbill_Insert", model);
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
        [Route("api/receiptInsert")]
        public IHttpActionResult PostReceipt(receiptPost_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Receipt_Insert", model);
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
        [Route("api/tempOpdRecSum")]
        public IHttpActionResult tempOpdRecSum(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<tmpopdrecSum_Dt>
                ("sp_tMPopdRECSum", new { userid = userid });
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
        [Route("api/tempOpdRecInsert/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tmpOpdRecDeleteById", new { sn = id });
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
        [Route("api/tempOpdRecInsert/DeleteAll/{userid}")]
        public IHttpActionResult DeleteAll(int userid)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tmpOpdRecDelete", new { userid = userid });
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