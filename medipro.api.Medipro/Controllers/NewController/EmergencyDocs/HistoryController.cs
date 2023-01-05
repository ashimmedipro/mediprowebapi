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
    public class HistoryController : ApiController
    {
        [HttpPost]
        [Route("api/History")]
        public IHttpActionResult Post(HistoryInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HistoryInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/History/Update")]
        public IHttpActionResult Update(HistoryUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HistoryUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/History")]
        public IHttpActionResult Get(int his_id)
        {
            var list = DapperHelper.QueryStoredProcedure<HistoryGetdata_dt>("sp_HistoryGetdata",
                new { his_id = his_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/History/Delete")]
        public IHttpActionResult Delete(HistoryDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HistoryDelete", model);
            return Ok();
        }
    }
}
