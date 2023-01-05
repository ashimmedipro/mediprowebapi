using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.ServiceManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.ServiceManagement.CashDistributionSection
{
    public class CashDistCstAddController : ApiController
    {
        [HttpGet]
        [Route("api/ServiceManagement/CashDistributionSection/CashDistributionConsultantAddByInvno")]
        public IHttpActionResult Select(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistCnstAdd_dt>
                ("sp_CashDistributionConsultantAddInvoiceDetails", new { inv_no=inv_no}).ToList();
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
        [Route("api/ServiceManagement/CashDistributionSection/CashDistributionConsultantAdd/Ac_Code/Select")]
        public IHttpActionResult AccodeSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CashDistGetAccode_dt>
                ("sp_CashDistributionConsultantAddGetAcCode").ToList();
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
        [Route("api/ServiceManagement/CashDistributionSection/CashDistributionConsultantAdd/Servmang/Insert")]
        public IHttpActionResult Insert(ServmangInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_ServmangrecInsert", model);
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
