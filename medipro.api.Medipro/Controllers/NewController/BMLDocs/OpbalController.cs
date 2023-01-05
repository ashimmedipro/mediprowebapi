using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.BMLDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.BMLDocs
{
    public class OpbalController : ApiController
    {
        [HttpPost]
        [Route("api/Opbal/Update")]
        public IHttpActionResult Update(OpbalInsertUpdate_dt  model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_opbalInsertUpdate", model);
            return Ok();
        }
    }
}
