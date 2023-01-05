using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceRegisterReportModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/AdvanceRegisterReportModify")]
        public IHttpActionResult Get()
        {
            AdvanceRegisterReportModify a = new AdvanceRegisterReportModify();

            a.AdvanceRegisterReportSelect();



            return Ok();

        }
    }
}
