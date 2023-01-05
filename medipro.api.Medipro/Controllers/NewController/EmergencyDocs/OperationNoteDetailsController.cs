using medipro.api.Medipro.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static medipro.api.Medipro.Models.NewModels.EmergencyDocs.OperationNoteDetails;

namespace medipro.api.Medipro.Controllers.NewController.EmergencyDocs
{
    public class OperationNoteDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/OperationNoteDetails")]
        public IHttpActionResult Post(OperationNoteDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/OperationNoteDetails/Update")]
        public IHttpActionResult Update(OperationNoteDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/OperationNoteDetails")]
        public IHttpActionResult Get(int operation_id)
        {
            var list = DapperHelper.QueryStoredProcedure<OperationNoteDetailsGetdata_dt>("sp_OperationNoteDetailsGetdata",
                new { operation_id = operation_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/OperationNoteDetails/Delete")]
        public IHttpActionResult Delete(OperationNoteDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OperationNoteDetailsDelete", model);
            return Ok();
        }
    }
}
