using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class LabExaminationPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/LabExaminationPivot")]
        public IHttpActionResult Get()
        {

            LabExaminationPivotModify l = new LabExaminationPivotModify();

            l.LabExaminationView();
            l.LabExaminationPivot();



            return Ok();

        }
    }
}
