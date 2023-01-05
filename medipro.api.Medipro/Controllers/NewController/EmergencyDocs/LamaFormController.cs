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
    public class LamaFormController : ApiController
    {
        [HttpPost]
        [Route("api/LamaForm")]
        public IHttpActionResult Post(LamaFormInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaFormInsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/LamaForm/Update")]
        public IHttpActionResult Update(LamaFormUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaFormUpdate", model);
            return Ok();
        }


        [HttpGet]
        [Route("api/LamaForm")]
        public IHttpActionResult Get(int lama_id)
        {
            var list = DapperHelper.QueryStoredProcedure<LamaFormGetdata_dt>
                ("sp_LamaFormGetdata", new { lama_id = lama_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/LamaForm/Delete")]
        public IHttpActionResult Delete(LamaFormDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaFormDelete", model);
            return Ok();
        }
    }
}
