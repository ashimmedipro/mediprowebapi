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
    public class IntakeOutputDetailController : ApiController
    {
        [HttpPost]
        [Route("api/IntakeOutputDetail")]
        public IHttpActionResult Post(IntakeOutputDetailInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputDetailInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/IntakeOutputDetail/Update")]
        public IHttpActionResult Update(IntakeOutputDetailUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputDetailUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/IntakeOutputDetail")]
        public IHttpActionResult Get(int intakeoutput_id)
        {
            var list = DapperHelper.QueryStoredProcedure<IntakeOutputDetailGetdata_dt>
                ("sp_IntakeOutputDetailGetdata", new { intakeoutput_id = intakeoutput_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/IntakeOutputDetail/Delete")]
        public IHttpActionResult Delete(IntakeOutputDetailDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputDetailDelete", model);
            return Ok();
        }
    }
}
