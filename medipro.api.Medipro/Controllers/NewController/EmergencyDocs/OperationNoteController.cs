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
    public class OperationNoteController : ApiController
    {
        [HttpPost]
        [Route("api/OperationNote")]
        public IHttpActionResult Post(OperationNoteInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/OperationNote/Update")]
        public IHttpActionResult Update(OperationNoteUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/OperationNote")]
        public IHttpActionResult Get(int operation_id)
        {
            var list = DapperHelper.QueryStoredProcedure<OperationNoteGetdata_dt>("sp_OperationNoteGetdata",
                new { operation_id = operation_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/OperationNote/Delete")]
        public IHttpActionResult Delete(OperationNoteDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteDelete", model);
            return Ok();
        }

    }
}
