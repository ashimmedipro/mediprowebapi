using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class PastEyeHistoryModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/PastEyeHistory")]
        public IHttpActionResult Get()
        {

            PastEyeHistoryModify p = new PastEyeHistoryModify();

            p.PastEyeHistoryDetailsInsert();
            p.PastEyeHistoryDetailsSelect();
            p.PastEyeHistoryDetailsDelete();
            p.TempPastEyeHistoryDetailsInsert();
            p.TempPastEyeHistoryDetailsBulkInsert();
            p.TempPastEyeHistoryDetailsDelete();







            return Ok();

        }


    }
}
