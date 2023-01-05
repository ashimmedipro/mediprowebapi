using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class CurrentChangeReportModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/CurrentChangeReportModify")]
        public IHttpActionResult Get()
        {
            CurrentChangeReportModify c = new CurrentChangeReportModify();

            c.CurrentChangeReportSelect();






            return Ok();

        }
    }
}
