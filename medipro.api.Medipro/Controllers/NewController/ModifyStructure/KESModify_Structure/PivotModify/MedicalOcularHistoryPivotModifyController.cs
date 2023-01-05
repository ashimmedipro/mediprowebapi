using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class MedicalOcularHistoryPivotModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/kes/MedicalOcularHistoryPivot")]
        public IHttpActionResult Get()
        {

            MedicalOcularHistoryPivotModify mo = new MedicalOcularHistoryPivotModify();
            mo.MedicalOcularHistoryview();
            mo.MedicalOcularHistoryPivot();




            return Ok();

        }
    }
}
