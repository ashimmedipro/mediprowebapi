using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class QolSurveyModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/QolSurvey")]
        public IHttpActionResult Get()
        {
            QolSurveyModify q = new QolSurveyModify();
            q.QolSurveyDetailInsert();
            q.QolSurveyDetailSelect();
            q.QolSurveyDetailDelete();
            q.TempQolSurveyDetailInsert();
            q.TempQolSurveyDetailBulkInsert();
            q.TempQolSurveyDetailDelete();





            return Ok();

        }
    }
}
