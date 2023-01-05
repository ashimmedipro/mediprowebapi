using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers
{
    public class ConfigsController : ApiController
    {
        [HttpGet]
        [Route("api/Configs")]
        public IHttpActionResult Get(string id)
        {
            var list = DapperHelper.QueryStoredProcedure<OpdBill_dto>("sp_OpdbillById", new { inv_no = id }).ToList();

            return Ok(list);

        }
    }
}
