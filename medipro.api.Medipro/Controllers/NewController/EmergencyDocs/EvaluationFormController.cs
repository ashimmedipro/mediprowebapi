using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EmergencyDocs
{
    public class EvaluationFormController : ApiController
    {
        [HttpPost]
        [Route("api/EvaluationForm")]
        public IHttpActionResult Post(EvaluationFormInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFormInsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/EvaluationForm/Update")]
        public IHttpActionResult Update(EvaluationFormUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFormUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/EvaluationForm")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<EvaluationFormGetdata_dt>
                ("sp_EvaluationFormGetdata", new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/EvaluationForm/Delete")]
        public IHttpActionResult Delete(EvaluationFormDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFromDelete", model);
            return Ok();
        }
    }
}
