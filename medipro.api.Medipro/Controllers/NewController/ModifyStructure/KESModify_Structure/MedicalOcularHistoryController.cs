using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class MedicalOcularHistoryController : ApiController
    {


       

        [HttpGet]
        [Route("api/ModifyStructure/kes/MedicalOcularHistory")]
        public IHttpActionResult Get()
        {

            MedicalOcularHistory mo = new MedicalOcularHistory();
            mo.MedicalOcularHistorydetailSelect();
            mo.MedicalOcularHistorydetailDelete();
            mo.TempMedicalOcularHistorydetailInsert();
            mo.TempMedicalOcularHistorydetailBulkInsert();
            mo.TempMedicalOcularHistorydetailDelete();



            return Ok();

        }

    }
}
