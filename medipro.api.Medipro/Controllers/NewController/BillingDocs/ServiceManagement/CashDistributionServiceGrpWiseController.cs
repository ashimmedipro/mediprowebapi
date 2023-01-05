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
    public class CashDistributionServiceGrpWiseController : ApiController
    {
        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionServiceGroupwise/Gropuname/Select")]
        public IHttpActionResult GrpSelect()
        {
            var list = DapperHelper.QueryStoredProcedure<GrpNameSelect_dt>
                ("sp_GrpnameSelect").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/billing/ServiceManagement/CashDistributionServiceGroupwise/ConsultantClass/Select")]
        public IHttpActionResult ConsultantSelect(int grpid )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ConsultantClassSelect_dtP>
                ("sp_CnstntClassSelect", new { grpid=grpid}).ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionServiceGroupwise/TechDet/Select")]
        public IHttpActionResult TechdetSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ConsultantClassSelect_dtP>
                ("sp_TechdetSelect_dt").ToList();
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
        [Route("api/billing/ServiceManagement/CashDistributionServiceGroupwise/Select")]
        public IHttpActionResult DateSelect(DateTime initdate, DateTime finaldate, int firm, int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DeptWiseServiceDistribution_dt>
                ("sp_DeptwiseSalesSelectByDaterange", new { initdate = initdate, finaldate = finaldate, firm = firm, grpid = grpid }).ToList();
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
