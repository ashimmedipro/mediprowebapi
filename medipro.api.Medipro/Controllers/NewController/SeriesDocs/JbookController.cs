using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.SeriesDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.SeriesDocs
{
    public class JbookController : ApiController
    {
        [HttpGet]
        [Route("api/Jbook")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<JbookSelect_dt>
                ("sp_JbookSelect", new { sn = sn }).ToList();
            return Ok(list);
        }
    }
}
