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
    public class ServiceWiseCashDistController : ApiController
    {
        [HttpGet]
        [Route("api/ServiceManagement/CashDistribution/ServiceWiseCashDistribution/Patient/Select")]
        public IHttpActionResult Select(int firm,DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceWiseCashDist_dt>
                ("sp_ServicewiseCashDistributionEntryGetPatient", new {firm=firm, init = init, final = final}).ToList();
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
        [Route("api/ServiceManagement/CashDistribution/ServiceWiseCashDistribution/ServiceName/Select")]
        public IHttpActionResult ServSelect(string invno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ServiceNameGet_dt>
                ("sp_ServicewiseCashDistributionGetServiceByInvno", new { invno=invno}).ToList();
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
        [Route("api/ServiceManagement/CashDistribution/ServiceWiseCashDistribution/Particular/Select")]
        public IHttpActionResult PartSelect(int id)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ParticularGetbyId_dt>
                ("sp_ServicewiseCashDistributionGetParticularById", new { id = id}).ToList();
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
