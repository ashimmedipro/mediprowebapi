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
    public class Member_SetupController : ApiController
    {
        [HttpGet]
        [Route("api/Catalogue/MemberSetupList")]
        public IHttpActionResult Total(string m_type)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<MemberSetupList_dt>
                    ("sp_MemberSetupList", new { m_type=m_type }).ToList();
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
