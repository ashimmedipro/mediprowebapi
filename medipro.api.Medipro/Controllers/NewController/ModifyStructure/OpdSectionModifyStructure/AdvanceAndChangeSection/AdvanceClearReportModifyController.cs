using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceClearReportModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/AdvanceClearReportModify")]
        public IHttpActionResult Get()
        {
            AdvanceClearReportModify a = new AdvanceClearReportModify();

            a.AdvanceClearReportSelect();



            return Ok();

        }
    }
}
