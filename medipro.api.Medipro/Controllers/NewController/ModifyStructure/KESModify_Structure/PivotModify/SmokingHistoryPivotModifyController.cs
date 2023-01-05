using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class SmokingHistoryPivotModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/kes/SmokingHistoryPivot")]
        public IHttpActionResult Get()
        {

            SmokingHistoryPivotModify s = new SmokingHistoryPivotModify();

            s.SmokingHistoryView();
            s.SmokingHistoryPivot();




            return Ok();

        }
    }
}
