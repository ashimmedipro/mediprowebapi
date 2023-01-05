using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class SmokingHistoryModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/SmokingHistory")]
        public IHttpActionResult Get()
        {

            SmokingHistoryModify s = new SmokingHistoryModify();

            s.SmokingHistoryDetailInsert();
            s.SmokingHistoryDetailSelect();
            s.SmokingHistoryDetailDelete();
            s.TempSmokingHistoryDetailInsert();
            s.TempSmokingHistoryDetailBulkInsert();
            s.TempSmokingHistoryDetailDelete();





            return Ok();

        }
    }
}
