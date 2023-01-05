using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class CommonEyeProblemModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/CommonEyeProblem")]
        public IHttpActionResult Get()
        {

            CommonEyeProblem c = new CommonEyeProblem();

            c.CommonEyeProblemDetailInsert();
            c.CommonEyeProblemDetailSelect();
            c.CommonEyeProblemDetailDelete();
            c.TempCommonEyeProblemDetailInsert();
            c.TempCommonEyeProblemDetailBulkInsert();
            c.TempCommonEyeProblemDetailDelete();





            return Ok();

        }
    }
}
