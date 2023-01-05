using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class ChangeClearModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/ChangeClearModify")]
        public IHttpActionResult Get()
        {
            ChangeClearModify c = new ChangeClearModify();

            c.PatientList();
            c.PatientChangeUpdate();







            return Ok();

        }
    }
}
