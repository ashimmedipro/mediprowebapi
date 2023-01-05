using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class LabExaminationModifyController : ApiController
    {



        [HttpGet]
        [Route("api/ModifyStructure/kes/LabExamination")]
        public IHttpActionResult Get()
        {

            LabExamination l = new LabExamination();

            l.LabExaminationDetailInsert();
            l.LabExaminationDetailSelect();
            l.LabExaminationDetailDelete();
            l.TempLabExaminationDetailInsert();
            l.TempLabExaminationDetailBulkInsert();
            l.TempLabExaminationDetailDelete();


            return Ok();

        }
    }
}
