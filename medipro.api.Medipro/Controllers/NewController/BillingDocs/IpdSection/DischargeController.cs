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
    public class DischargeController : ApiController
    {
        [HttpGet]
        [Route("api/Discharge/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeInpatientSelect_dt>
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
        [Route("api/Discharge/DischargeAmount")]
        public IHttpActionResult Amount(int ipdno)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeAmount_dt>
                    ("sp_DischargeAmountByIpdno", new { ipdno = ipdno }).ToList();
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
        [Route("api/Discharge/DischargeTotal")]
        public IHttpActionResult Total(int ipdno, int firm, string p_type)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeTotal_dt>
                    ("sp_DischargeTotal", new { ipdno = ipdno, firm = firm, p_type = p_type }).ToList();
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
        [Route("api/Discharge/DischargeDiscount")]
        public IHttpActionResult Discount(int ipdno, string p_type, int firm)
        {
            try
            {



                var list = DapperHelper.QueryStoredProcedure<DischargeDiscount_dt>
                    ("sp_DischargeGetDiscount", new { ipdno = ipdno, p_type = p_type, firm = firm }).ToList();
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
        [Route("api/Discharge/DischargeGetDeposit")]
        public IHttpActionResult Deposit(int ipdno, int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeTotal_dt>
                    ("sp_DischargeGetDeposit", new { ipdno = ipdno, firm = firm }).ToList();
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
        [Route("api/Discharge/GetRefund")]
        public IHttpActionResult Refund(int ipdno, int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeRefund_dt>
                    ("sp_DischargeGetRefund", new { ipdno = ipdno, firm = firm }).ToList();
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
        [Route("api/Discharge/IcdCode")]
        public IHttpActionResult IcdCode()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DischargeIcdCode_dt>
                    ("sp_DischargeIcdcodeSelect").ToList();
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
        [Route("api/Discharge/Insert")]
        public IHttpActionResult Insert(DischargeInsert_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_Discharge_Insert", model);
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


        //get ac_code

        [HttpGet]
        [Route("api/Discharge/ac_code/Select")]
        public IHttpActionResult AcCodeSearch(int firm, string search)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<AccodeGet_dt>
                    ("sp_AcCodeSelectByFirmAndBillmode", new { firm = firm, search = search }).ToList();
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
        //get accode without search
        [HttpGet]
        [Route("api/Discharge/ac_code/Select")]
        public IHttpActionResult AcCode(int firm)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<AccodeGet_dt>
                    ("sp_AcCodeSelectByFirmAndBillmode", new { firm = firm, search = "" }).ToList();
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
