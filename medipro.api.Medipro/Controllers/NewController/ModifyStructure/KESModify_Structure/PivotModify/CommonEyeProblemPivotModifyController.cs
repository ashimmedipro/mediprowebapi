using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class CommonEyeProblemPivotModifyController : ApiController
    {


                    [HttpGet]
        [Route("api/ModifyStructure/kes/CommonEyeProblemPivot")]
        public IHttpActionResult Get()
        {

            CommonEyeProblemPivotModify c = new CommonEyeProblemPivotModify();

            c.CommonEyeProblemView();
            c.CommonEyeProblemPivot();




            return Ok();

        }
    }
}
