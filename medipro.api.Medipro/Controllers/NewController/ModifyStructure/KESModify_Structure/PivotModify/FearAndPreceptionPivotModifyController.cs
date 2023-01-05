using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class FearAndPreceptionPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/FearAndPreceptionPivot")]
        public IHttpActionResult Get()
        {

            FearAndPreceptionPivotModify f = new FearAndPreceptionPivotModify();

            f.FearAndPreceptionView();
            f.FearAndPreceptionPivot();




            return Ok();

        }
    }
}
