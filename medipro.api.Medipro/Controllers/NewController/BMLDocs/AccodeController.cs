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
    public class AccodeController : ApiController
    {
        [HttpPost]
        [Route("api/Accode/Update")]
        public IHttpActionResult Update(AccodeInsertUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_accodeInsertUpdate", model);
            return Ok();
        }

       /* [HttpGet]
        [Route("api/Accode")]
        public IHttpActionResult Get(int ac_code)
        {
            var list = DapperHelper.QueryStoredProcedure<AccodeselectById_dt>("sp_accodeselectById",
                new { ac_code = ac_code }).ToList();
            return Ok(list);
        }*/

        [HttpGet]
        [Route("api/AccodeSearch/{search}")]
        public IHttpActionResult Get(string search)
        {
            var list = DapperHelper.QueryStoredProcedure<AccodeSearch_dt>("sp_accodeSearch",
                new { search = search }).ToList();
            return Ok(list);
        }
    }
}
