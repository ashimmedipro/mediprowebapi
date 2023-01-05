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
    public class SbCodeController : ApiController
    {
        [HttpPost]
        [Route("api/Sbcode/Update")]
        public IHttpActionResult Update(SbCodeInsertUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SbCodeInsertUpdate", model);
            return Ok();
        }


        /* [HttpGet]
        [Route("api/Sbcode")]
        public IHttpActionResult Get(int sb_code)
        {
            var list = DapperHelper.QueryStoredProcedure<SbcodeselectById_dt>("sp_sbcodeselectById ",
                new { sb_code = sb_code }).ToList();
            return Ok(list);
        }*/

        [HttpGet]
        [Route("api/Sbcode")]
        public IHttpActionResult Select(int sb_code) 
        {
            var list = DapperHelper.QueryStoredProcedure<SbcodeSelect_dt>("sp_SbCodeSelect ",
                new { sb_code = sb_code }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Sbcode")]
        public IHttpActionResult Post(Sbcode_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SB_CODEInsert", model);
            return Ok();
        }
    }
}
