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
    public class PrintBillCopyController : ApiController
    {
        [HttpGet]
        [Route("api/IpdSection/PrintBillCopy/OpdBill/Select")]
        public IHttpActionResult OpdbillSelect(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintBillCopyOpdBillGet_dt>
                ("sp_PrintBillCopyOpdBillSelectByInv_no ", new { inv_no=inv_no }).ToList();
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
        [Route("api/IpdSection/PrintBillCopy/OpdRec/Select")]
        public IHttpActionResult OpdRecSelect(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintBillCopyOpdRecGet_dt>
                ("sp_PrintBillCopyOpdRecSelectByInv_no ", new { inv_no = inv_no }).ToList();
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
        [Route("api/IpdSection/PrintBillCopy/Receipt/Select")]
        public IHttpActionResult ReceiptSelect(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintBillCopyReceiptGet_dt>
                ("sp_PrintBillCopyReceiptSelectByInv_no ", new { inv_no = inv_no }).ToList();
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
        [Route("api/IpdSection/PrintBillCopy/PanelRec/Select")]
        public IHttpActionResult PanelRecSelect(string inv_no, int master_servid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<PrintBillCopyPanelRecGet_dt>
                ("sp_PrintBillCopyPanelRecSelectByInv_no ", new { inv_no = inv_no , master_servid = master_servid }).ToList();
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
        [Route("api/IpdSection/PrintBillCopy/OpdBill/Update")]
        public IHttpActionResult Update(PrintBillCopyOpdbillUpdate_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PrintBillCopyOpdBillUpdate", model);
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
