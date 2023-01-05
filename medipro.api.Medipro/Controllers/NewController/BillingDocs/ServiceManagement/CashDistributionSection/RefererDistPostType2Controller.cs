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
    public class RefererDistPostType2Controller : ApiController
    {

        [HttpPost]
        [Route("api/ServiceManagement/CashDistributionSection/ReferrerDistributionPost/TempRefererTemplate/Insert")]
        public IHttpActionResult TempRefererTemplateInsert(TempRefTemplateInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_temp_RefererTemplateSearchInsert", model);
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
        [Route("api/ServiceManagement/CashDistributionSection/ReferrerDistributionPost/TemplateName/Select")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<TemplateNameSelect_dt>
                ("sp_RefererPaySlipGetTemplate").ToList();
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
        [Route("api/ServiceManagement/CashDistributionSection/ReferrerDistributionPost/RefererDetails/Select")]
        public IHttpActionResult RefererSelect(DateTime init, DateTime final, int val )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefDetailsSelect>
                ("sp_RefererPaySlipSelectFromtRefererAnalysis1", new { init=init, final=final, val= val}).ToList();
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
        [Route("api/ServiceManagement/CashDistributionSection/ReferrerDistributionPost/Total/Select")]
        public IHttpActionResult Total()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Total_dt>
                ("sp_RefererPaySlipGetTotal").ToList();
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
