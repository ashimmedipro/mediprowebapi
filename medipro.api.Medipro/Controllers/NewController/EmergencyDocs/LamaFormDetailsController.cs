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
    public class LamaFormDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/LamaFormDetails")]
        public IHttpActionResult Post(LamaFormDetails_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaDetailInsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/LamaFormDetails/Update")]
        public IHttpActionResult Update(LamaFormDetails_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaDetailUpdate", model);
            return Ok();
        }


        [HttpGet]
        [Route("api/LamaFormDetails")]
        public IHttpActionResult Get(int lama_id)
        {
            var list = DapperHelper.QueryStoredProcedure<LamaFormDetailsSelect_dt>
                ("sp_LamaFormDetailSelect", new { lama_id = lama_id}).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/LamaFormDetails/Delete")]
        public IHttpActionResult Delete(LamaFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_LamaFormDetailDelete", model);
            return Ok();
        }
    }
}
