using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.OrganizationMemberMaster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.Organization_Member_Master
{
    public class MemberOrgController : ApiController
    {
        [HttpGet]
        [Route("api/OrganizationMember/MemberOrgSelect")]
        public IHttpActionResult Select()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberOrgSelect_dt>
                    ("sp_MemberOrgSelect").ToList();
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
        [Route("api/OrganizationMember/MemberOrgReport")]
        public IHttpActionResult MemberOrgCrystalReport(int orgid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberOrgReport_dt>
                    ("sp_MemberOrgnameReport", new { orgid = orgid }).ToList();
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
