using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class PeriodicChangeRegisterModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/PeriodicChangeRegisterModify")]
        public IHttpActionResult Get()
        {
            PeriodicChangeRegisterModify p = new PeriodicChangeRegisterModify();


            p.PeriodicChangeRegisterSelect();





            return Ok();

        }
    }
}
