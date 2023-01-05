using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class PastEyeHistoryPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/PastEyeHistoryPivot")]
        public IHttpActionResult Get()
        {

            PastEyeHistoryPivotModify p = new PastEyeHistoryPivotModify();

            p.PastEyeHistoryView();
            p.PastEyeHistoryPivot();






            return Ok();

        }
    }
}
