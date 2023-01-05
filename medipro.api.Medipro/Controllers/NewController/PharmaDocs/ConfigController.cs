using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class ConfigController : ApiController
    {
        [HttpPost]
        [Route("api/Config")]
        public IHttpActionResult Post(Config_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConfigInsert", model);
            return Ok();
        }

        

        [HttpPost]
        [Route("api/Config/Update")]
        public IHttpActionResult Update(Config_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConfigUpdate", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Config/Delete")]
        public IHttpActionResult Delete(ConfigDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConfigDelete", model);
            return Ok();
        }
    }
}
