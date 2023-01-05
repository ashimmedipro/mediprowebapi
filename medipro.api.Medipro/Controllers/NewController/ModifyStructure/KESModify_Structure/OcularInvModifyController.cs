using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class OcularInvModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/OcularInvestigation")]
        public IHttpActionResult Get()
        {

            OcularInvModify oi = new OcularInvModify();
            oi.OcularInvDetailInsert();
            oi.OcularInvDetailSelect();
            oi.OcularInvDetailDelete();
            oi.TempOcularInvDetailInsert();
            oi.TempOcularInvDetailBulkInsert();
            oi.TempOcularInvDetailDelete();








            return Ok();

        }
    }
}
