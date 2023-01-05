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
    public class pathologyController : ApiController
    {
        [HttpPost]
        [Route("api/Histopathology")]
        public IHttpActionResult Post(Pathology_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Histopathology/Update")]
        public IHttpActionResult Update(PathologyUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Histopathology")]
        public IHttpActionResult Get(int pathology_id)
        {
            var list = DapperHelper.QueryStoredProcedure<PathologySelect_dt>
                ("sp_PathologySelect", new { pathology_id = pathology_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Histopathology/Delete")]
        public IHttpActionResult Delete(PathologyDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PathologyDelete", model);
            return Ok();
        }
    }
}
