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
    public class SalesAndOrderController : ApiController
    {
        [HttpGet]
        [Route("api/tempSalesOrder")]
        public IHttpActionResult Get(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<tempSalesOrderSelect_dt>
                ("sp_temp_SalesOrderSelect", new { userid = userid }).ToList();
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
        [Route("api/tempSalesOrderBySum")]
        public IHttpActionResult GetSum(int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<tempSalesOrderSelectSum_dt>
                ("sp_temp_SalesOrderSelectSum", new { userid = userid }).ToList();
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
        [Route("api/tempSalesOrder")]
        public IHttpActionResult Post(tempSalesOrderInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_SalesOrderInsert", model);
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
        [Route("api/tempSalesOrder/Update")]
        public IHttpActionResult Update(tempSalesOrderUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_tempSalesOrderEdit", model);
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
        [Route("api/tempSalesOrderDetails")]
        public IHttpActionResult PostDetails(tempSalesOrderDetailsInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SalesOrderDetailInsert", model);
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
        [Route("api/SalesOrders")]
        public IHttpActionResult PostAll(SalesOrderInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SalesOrderInsert", model);
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
        [Route("api/tempSalesOrder/Delete")]
        public IHttpActionResult Delete(tempSalesOrderDelete_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_SalesorderDelete", model);
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
        [Route("api/tempSalesOrderByDateRange/{startdate}/{enddate}/{userid}")]
        public IHttpActionResult GetDate(DateTime startdate, DateTime enddate, int userid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SalesOrderSelectByDateRange_dt>
                ("sp_SalesOrderSelectbyDateRange", new { startdate = startdate, enddate = enddate, userid= userid}).ToList();
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
        [Route("api/SalesOrderDetailByInvNo")]
        public IHttpActionResult GetByInvNo(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<SalesOrderSelectbyInvNo_dt>
                ("sp_SalesOrderDetailSelectByInvno", new { inv_no = inv_no }).ToList();
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
        [Route("api/salesOrderApprove/Update")]
        public IHttpActionResult Update(SalesOrderApproveUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SalesOrderApproveUpdate", model);
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
