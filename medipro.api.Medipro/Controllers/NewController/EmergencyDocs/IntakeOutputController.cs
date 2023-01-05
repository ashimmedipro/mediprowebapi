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
    public class IntakeOutputController : ApiController
    {
        [HttpPost]
        [Route("api/IntakeOutput")]
        public IHttpActionResult Post(IntakeOutputInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/IntakeOutput/Update")]
        public IHttpActionResult Update(IntakeOutputUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/IntakeOutput")]
        public IHttpActionResult Get(int intakeoutput_id)
        {
            var list = DapperHelper.QueryStoredProcedure<IntakeOutputGetdata_dt>
                ("sp_IntakeOutputGetdata", new { intakeoutput_id = intakeoutput_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/IntakeOutput/Delete")]
        public IHttpActionResult Delete(IntakeOutputDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IntakeOutputDelete", model);
            return Ok();
        }
    }
}
