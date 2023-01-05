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
    public class AnaesthesiaRecordDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/AnaesthesiaRecordDetails")]

        public IHttpActionResult Post(AnaesthesiaRecordDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AnaesthesiaRecordDetails/Update")]

        public IHttpActionResult Update(AnaesthesiaRecordDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AnaesthesiaRecordDetails")]

        public IHttpActionResult Get(int record_id)
        {
            var list = DapperHelper.QueryStoredProcedure<AnaesthesiaRecordDetailsGetdata_dt>
                ("sp_AnaesthesiaRecordDetailsGetdata", new { record_id = record_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/AnaesthesiaRecordDetails/Delete")]

        public IHttpActionResult Delete(AnaesthesiaRecordDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordDetailsDelete ", model);
            return Ok();
        }
    }
}
