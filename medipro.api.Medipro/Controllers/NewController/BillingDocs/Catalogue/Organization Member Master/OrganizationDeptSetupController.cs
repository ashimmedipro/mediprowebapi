using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.Organization_Member_Master
{
    public class OrganizationDeptSetupController : ApiController
    {
        [HttpGet]
        [Route("api/EmpDeptList")]
        public IHttpActionResult EmpdptList(int orgid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EmpDept_dt>
                    ("sp_EmpDeptList", new { orgid=orgid }).ToList();
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
        [Route("api/EmpDeptReport")]
        public IHttpActionResult EmpdptReport()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EmpDeptSelectReport_dt>
                    ("sp_OrgDeptSetupReport").ToList();
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
        [Route("api/EmpDeptDetailReport")]
        public IHttpActionResult EmpdptDetailReport(int dptid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EmpDeptDetailSelectReport_dt>
                    ("sp_OrgDeptSetupDetailReport", new { dptid = dptid }).ToList();
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
