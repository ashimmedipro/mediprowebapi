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
    public class ConsentFormDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/ConsentFormDetails")]
        public IHttpActionResult Post(ConsentFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ConsentFormDetails/update")]
        public IHttpActionResult Update(ConsentFormDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ConsentFormDetails")]
        public IHttpActionResult Get(int consent_id)
        {
            var list = DapperHelper.QueryStoredProcedure<ConsentFormDetailsGetdata_dt>
                ("sp_ConsentFormDetailsGetData", new { consent_id = consent_id }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/ConsentFormDetails/Delete")]
        public IHttpActionResult Delete(ConsentFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFormDetailsDelete", model);
            return Ok();
        }
    }
}
