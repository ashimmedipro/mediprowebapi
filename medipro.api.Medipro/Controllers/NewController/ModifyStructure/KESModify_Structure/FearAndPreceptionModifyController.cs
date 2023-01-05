using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class FearAndPreceptionModifyController : ApiController
    {
        
        [HttpGet]
        [Route("api/ModifyStructure/kes/FearAndPreception")]
        public IHttpActionResult Get()
        {

            FearAndPreceptionModify f = new FearAndPreceptionModify();

            f.FearPreceptionDetailInsert();
            f.FearPreceptionDetailSelect();
            f.FearPreceptionDetailDelete();
            f.TempFearPreceptionDetailInsert();
            f.TempFearPreceptionDetailBulkInsert();
            f.TempFearPreceptionDetailDelete();



            return Ok();

        }

    }
}
