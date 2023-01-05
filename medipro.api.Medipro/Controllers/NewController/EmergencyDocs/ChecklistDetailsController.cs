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
    public class ChecklistDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/ChecklistDetails")]
        public IHttpActionResult Post(ChecklistDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ChecklistDetails/Update")]
        public IHttpActionResult Post(ChecklistDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ChecklistDetails")]
        public IHttpActionResult Get(int checklist_id)
        {
            var list = DapperHelper.QueryStoredProcedure<ChecklistDetailsGetdata_dt>
                ("sp_ChecklistDetailsGetdata", new { checklist_id = checklist_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/ChecklistDetails/Delete")]
        public IHttpActionResult Delete(ChecklistDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistDetailsDelete", model);
            return Ok();
        }
    }
}
