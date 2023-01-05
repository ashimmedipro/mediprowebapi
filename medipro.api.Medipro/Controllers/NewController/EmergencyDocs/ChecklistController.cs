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
    public class ChecklistController : ApiController
    {
        [HttpPost]
        [Route("api/Checklist")]
        public IHttpActionResult Post(ChecklistInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Checklist/Update")]
        public IHttpActionResult Update(ChecklistUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Checklist")]
        public IHttpActionResult Get(int checklist_id)
        {
            var list = DapperHelper.QueryStoredProcedure<ChecklistGetdata_dt>
                ("sp_ChecklistGetData", new { checklist_id = checklist_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Checklist/Delete")]
        public IHttpActionResult Delete(ChecklistDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChecklistDelete", model);
            return Ok();
        }
    }
}
