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
    public class VrSeriesController : ApiController
    {
        [HttpGet]
        [Route("api/VrSeries")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<VrSeriesSelect_dt>
                ("sp_vrSeriesSelect", new { sn = sn }).ToList();
            return Ok(list);
        }
    }
}
