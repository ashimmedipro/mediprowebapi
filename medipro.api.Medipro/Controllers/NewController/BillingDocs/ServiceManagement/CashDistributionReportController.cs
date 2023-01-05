using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.ServiceManagement
{
    public class CashDistributionReportController : ApiController
    {
        //type=all
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportAll/Select")]
        public IHttpActionResult AllSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionReport_dt>
                ("sp_CashDistAllSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportAllTotal/Select")]
        public IHttpActionResult AllTotalSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            

            var list = DapperHelper.QueryStoredProcedure<CashDistributionTotal_dt>
                ("sp_CashDistAllTotalSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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

        //type=opd

        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportOpd/Select")]
        public IHttpActionResult OpdSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionReport_dt>
                ("sp_CashDistOpdSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportOpdTotal/Select")]
        public IHttpActionResult OpdTotalSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionTotal_dt>
                ("sp_CashDistOpdTotalSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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

        //type=ipd

        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportIpd/Select")]
        public IHttpActionResult IpdSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionReport_dt>
                ("sp_CashDistIpdSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReporIpdTotal/Select")]
        public IHttpActionResult IpdTotalSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionTotal_dt>
                ("sp_CashDistIpdTotalSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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

        //type=ipdsave

        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReportIpdSave/Select")]
        public IHttpActionResult IpdSaveSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionReport_dt>
                ("sp_CashDistIpdSaveSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/CashDistributionReporIpdSaveTotal/Select")]
        public IHttpActionResult IpdSaveTotalSelect(DateTime init, DateTime final, int firm)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistributionTotal_dt>
                ("sp_CashDistIpdSaveTotalSelectByDateRange", new { init = init, final = final, firm = firm }).ToList();
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
