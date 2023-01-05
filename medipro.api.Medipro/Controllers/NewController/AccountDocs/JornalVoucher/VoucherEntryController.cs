using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.BMLDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.BMLDocs
{
    public class VoucherEntryController : ApiController
    {
        [HttpPost]
        [Route("api/VoucherEntry/DeleteAll")]
        public IHttpActionResult DeleteAll(VoucherEntryDeleteAll_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryDeleteAll", model);
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

        //[HttpPost]
        //[Route("api/VoucherEntry")]
        //public IHttpActionResult Post(VoucherEntryInsertJbook_dt model)
        //{
        //    DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryInsertJbook", model);
        //    return Ok();
        //}
        [HttpPost]
        [Route("api/VoucherEntry")]
        public IHttpActionResult Post(VoucherEntryInsertUpdate_dt model)
        {
            try
            {

            
            //DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryInsertJbook", model);
            DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryInsertUpdate", model);
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
        [Route("api/VoucherEntry/Update")]
        public IHttpActionResult Update(VoucherEntryInsertUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryInsertUpdate", model);
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
        [Route("api/VoucherEntry/DeleteById")]
        public IHttpActionResult DeleteById(VoucherEntryDeleteById_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryDeleteById", model);
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
        [Route("api/VoucherEntry")]
        public IHttpActionResult Get(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<VoucherEntrySelect_dt>
                ("sp_temp_voucherEntrySelect", new { userid = userid }).ToList();
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
        [Route("api/Jbook2TempVoucher")]
        public IHttpActionResult Jbook2TempVoucher(Jbook2TempVoucher_dt model)
        {
            try
            {

            
            //DapperHelper.ExecuteStoredProcedure("sp_temp_voucherEntryInsertJbook", model);
            DapperHelper.ExecuteStoredProcedure("sp_Jbook2TempVoucher", model);
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
