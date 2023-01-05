using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceClearModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/AdvanceClearModify")]
        public IHttpActionResult Get()
        {
            AdvanceClearModify a = new AdvanceClearModify();

            a.AdvanceClearSelect();
            a.AdvanceClearUpdate();


            return Ok();

        }
    }
}
