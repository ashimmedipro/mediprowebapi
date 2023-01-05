using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class OcularExaminationModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/kes/OcularExamination")]
        public IHttpActionResult Get()
        {

            OcularExamModify o = new OcularExamModify();

            o.OcularExamDetailInsert();
            o.OcularExamDetailSelect();
            o.OcularExamDetailDelete();
            o.TempOcularExamDetailInsert();
            o.TempOcularExamDetailBulkInsert();
            o.TempOcularExamDetailDelete();







            return Ok();

        }
    }
}
