using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class EyeRegistrationModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/kes/EyeRegistration")]
        public IHttpActionResult Get()
        {

            EyeRegistrationModify e = new EyeRegistrationModify();

            e.EyeRegInsert();
            e.EyeRegUpdate();
            e.EyeRegSelect();
            e.EyeRegMemberUpdate();
            e.EyeRegMemberSelect();



            return Ok();
        }

    }
}
