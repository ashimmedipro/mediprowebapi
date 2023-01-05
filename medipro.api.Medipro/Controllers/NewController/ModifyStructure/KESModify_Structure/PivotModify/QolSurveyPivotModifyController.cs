using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class QolSurveyPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/QolSurveyPivot")]
        public IHttpActionResult Get()
        {

            QolSurveyPivot q = new QolSurveyPivot();
            q.QolSurveyDetailView();
            q.QolSurveyDetailPivot();



            return Ok();

        }
    }
}
