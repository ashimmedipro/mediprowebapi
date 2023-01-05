using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class OcularExaminationPivotModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/kes/OcularExaminationPivot")]
        public IHttpActionResult Get()
        {

            OcularExaminationPivotModify oe = new OcularExaminationPivotModify();

            oe.OcularExaminationView();
            oe.OcularExaminationPivot();









            return Ok();

        }
    }
}
