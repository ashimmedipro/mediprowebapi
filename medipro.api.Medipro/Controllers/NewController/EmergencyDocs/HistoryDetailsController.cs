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
    public class HistoryDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/HistoryDetails")]
        public IHttpActionResult Post(HistoryDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HistoryDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/HistoryDetails/Update")]
        public IHttpActionResult Update(HistoryDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_historyDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/HistoryDetails")]
        public IHttpActionResult Get(int his_id)
        {
            var list = DapperHelper.QueryStoredProcedure<HistoryDetailsGetdata_dt>("sp_HistoryDetailsGetdata",
                new { his_id = his_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/HistoryDetails/Delete")]
        public IHttpActionResult Delete(HistoryDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HistoryDetailsDelete", model);
            return Ok();
        }
    }
}
