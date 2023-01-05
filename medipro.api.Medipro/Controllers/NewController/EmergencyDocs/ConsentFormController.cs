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
    public class ConsentFormController : ApiController
    {
        [HttpPost]
        [Route("api/ConsentForm")]
        public IHttpActionResult Post(ConsentFormInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ConsentForm/Update")]
        public IHttpActionResult Update(ConsentFormUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ConsentForm")]
        public IHttpActionResult Get(int consent_id)
        {
            var list = DapperHelper.QueryStoredProcedure<ConsentFormGetdata_dt>
                ("sp_ConsentFormGetdata", new { consent_id = consent_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/ConsentForm/Delete")]
        public IHttpActionResult Delete(ConsentFormDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormDelete", model);
            return Ok();
        }
    }
}
