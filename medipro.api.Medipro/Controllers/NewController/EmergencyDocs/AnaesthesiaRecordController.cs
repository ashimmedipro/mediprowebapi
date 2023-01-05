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
    public class AnaesthesiaRecordController : ApiController
    {
        [HttpPost]
        [Route("api/AnaesthesiaRecord")]

        public IHttpActionResult Post(AnaesthesiaRecordInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AnaesthesiaRecord/Update")]

        public IHttpActionResult Update(AnaesthesiaRecordUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AnaesthesiaRecord")]

        public IHttpActionResult Get(int record_id)
        {
            var list = DapperHelper.QueryStoredProcedure<AnaesthesiaRecordGetdata_dt>
                ("sp_AnaesthesiaRecordGetdata", new { record_id = record_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/AnaesthesiaRecord/Delete")]

        public IHttpActionResult Delete(AnaesthesiaRecordDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AnaesthesiaRecordDelete", model);
            return Ok();
        }
    }
}
