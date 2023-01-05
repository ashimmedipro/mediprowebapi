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
    public class PartDiscController : ApiController
    {
        [HttpPost]
        [Route("api/PartDisc")]
        public IHttpActionResult Post(PartDisc_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PARTDISC_Insert", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/PartDisc/{compCode}/{partytype}/{search}")]
        public IHttpActionResult get(int compcode, string partytype, string search)
        {
            var list = DapperHelper.QueryStoredProcedure<PartDisc_dt>
                ("sp_PartDiscSelect", new { compcode = compcode, partytype = partytype, search = search }).ToList();
            return Ok(list);
        }
    }
}
