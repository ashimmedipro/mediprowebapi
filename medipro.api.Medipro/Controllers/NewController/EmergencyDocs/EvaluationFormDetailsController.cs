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
    public class EvaluationFormDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/EvaluationFormDetails")]
        public IHttpActionResult Post(EvaluationFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFormDetailsInsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/EvaluationFormDetails/Update")]
        public IHttpActionResult Update(EvaluationFormDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFormDetailsUpdate", model);
            return Ok();
        }


        [HttpGet]
        [Route("api/EvaluationFormDetails")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<EvaluationFormDetailsGetdata_dt>
                ("sp_EvaluationFormDetailsGetdata", new { sn = sn }).ToList();
            return Ok(list);
        }



        [HttpPost]
        [Route("api/EvaluationFormDetails/Delete")]
        public IHttpActionResult Delete(EvaluationFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EvaluationFormDetailsDelete", model);
            return Ok();
        }
    }
}
