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
    public class Opbal1Controller : ApiController
    {
        [HttpPost]
        [Route("api/Opbal1")]
        public IHttpActionResult Post(Opbal1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_OP_BALInsert", model);
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
        [Route("api/Opbal1/Update")]
        public IHttpActionResult Update(Opbal1_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_OP_BALUpdate", model);
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
        [Route("api/Opbal1")]
        public IHttpActionResult GetbyFirm(int firm)
        {
            try
            {

            
            OpbalList_dt Opbal = new OpbalList_dt();
            var list = DapperHelper.QueryStoredProcedure<OpbalSelect_dt>
                ("sp_OP_BALSelect", new { firm = firm}).ToList();
            Opbal.Opbal = list;
            return Ok(Opbal);

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
        [Route("api/OpbalSelectbyfirmandbalance")]
        public IHttpActionResult Get(int firm1, int firm2)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Opbal_selectByFirmandBalance_dt>
                ("sp_OP_BAL_InsertSelectbyBalanceandFirm", new { firm1 = firm1, firm2= firm2 }).ToList();
            
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
        [Route("api/OpbalDebit")]
        public IHttpActionResult GetDebit(int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Opbal1Debit_dt>
                ("sp_TotalDebitbyFirm ", new { firm = firm }).ToList();
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
        [Route("api/OpbalCredit")]
        public IHttpActionResult GetCredit(int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Opbal1Credit_dt>
                ("sp_TotalCreditByFirm", new { firm = firm }).ToList();
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
        [Route("api/Opbal1/Delete")]
        public IHttpActionResult Delete(Opbal1Delete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_OP_BALDelete", model);
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
