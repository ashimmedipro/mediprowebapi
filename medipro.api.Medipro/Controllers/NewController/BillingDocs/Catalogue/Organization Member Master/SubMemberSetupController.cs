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
    public class SubMemberSetupController : ApiController
    {
        [HttpGet]
        [Route("api/Catalogue/SubMemberSetupList")]
        public IHttpActionResult Total(string m_type)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SubMemberList_dt>
                    ("sp_SubMemberSetupList", new { m_type = m_type }).ToList();
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
