using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection
{
    public class DepositController : ApiController
    {
        [HttpGet]
        [Route("api/Deposit/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositSelectInpatient_dt>
                ("sp_InpatientSelect").ToList();
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
        [Route("api/Deposit/TotalbyOpdbill")]
        public IHttpActionResult TotalByIpdno(int ipdno, string p_type)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<DepositGetTotal_dt>
                ("sp_DepositGetTotalByIpdno", new { ipdno = ipdno, p_type = p_type }).ToList();
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
        [Route("api/Deposit/TotalbyDeposit")]
        public IHttpActionResult TotalDeposit(int ipdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositGetTotal_dt>
                ("sp_DepositGetDepositByIpdno", new { ipdno = ipdno }).ToList();
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
        [Route("api/Deposit/TotalRefund")]
        public IHttpActionResult TotalRefund(int ipdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositGetTotal_dt>
                ("sp_DepositGetRefundByIpdno", new { ipdno = ipdno }).ToList();
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
        [Route("api/Deposit/TotalReceipt")]
        public IHttpActionResult TotalReceipt(int ipdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositGetTotal_dt>
                ("sp_DepositGetReceiptByIpdno", new { ipdno = ipdno }).ToList();
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
        [Route("api/Deposit/AdvanceAmount")]
        public IHttpActionResult AdvanceAmount(int hospid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DepositGetAdvance_dt>
                ("sp_DepositGetAdvanceByHospid", new { hospid = hospid }).ToList();
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
        [Route("api/Deposit/Insert")]
        public IHttpActionResult Insert(DepositInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DepositInsert", model);
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
