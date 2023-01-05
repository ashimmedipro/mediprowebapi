using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement.CashDistbrutionReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.ServiceManagement.CashDistributionReport
{
    public class InvoiceWiseExpensesAnalysisController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionReport/InvoicewiseExpensesAnalysis/Select")]
        public IHttpActionResult Select(DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<InvoiceWiseExpensesAnalysisSelect_dt>
                ("sp_OpdBillExpenseAnalysisSelectByDateRange", new { init = init, final = final}).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/InvoicewiseExpensesAnalysis/Particular/Select")]
        public IHttpActionResult ParticularSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ParticularSelect_dt>
                ("sp_OpdBillExpenseAnalysisParticularSelect").ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionReport/InvoicewiseExpensesAnalysis/Particular/Select")]
        public IHttpActionResult PayCodeSelect(DateTime init, DateTime final, int pay_code)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<InvoiceWiseExpensesAnalysisSelect_dt>
                ("sp_OpdBillExpenseAnalysisSelectByParticular", new { init = init, final = final, pay_code=pay_code }).ToList();
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
