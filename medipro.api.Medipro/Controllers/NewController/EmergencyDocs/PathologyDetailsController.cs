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
    public class PathologyDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/HistopathologyDetails")]
        public IHttpActionResult Post(pathologyDetails_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/HistopathologyDetails/Update")]
        public IHttpActionResult Update(pathologyDetails_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/HistopathologyDetails")]
        public IHttpActionResult Get(int pathology_id)
        {
            var list = DapperHelper.QueryStoredProcedure<pathologyDetailsSelect_dt>
                ("sp_PathologyDetailsSelect", new { pathology_id = pathology_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/HistopathologyDetails/Delete")]
        public IHttpActionResult Delete(pathologyDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyDetailsDelete", model);
            return Ok();
        }
    }
}
