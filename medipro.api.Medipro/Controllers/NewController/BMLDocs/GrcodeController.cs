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
    public class GrcodeController : ApiController
    {
        [HttpPost]
        [Route("api/Grcode/Update")]
        public IHttpActionResult Update(GrcodeInsertUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_grcodeInsertUpdate", model);
            return Ok();
        }


        /* [HttpGet]
         [Route("api/Grcode")]
         public IHttpActionResult Get(int gr_code)
         {
             var list = DapperHelper.QueryStoredProcedure<GrcodeselectById_dt>("sp_grcodeselectById",
                 new { gr_code = gr_code }).ToList();
             return Ok(list);
         }*/

        [HttpGet]
        [Route("api/Grcode/{search}")]
        public IHttpActionResult Get(string search)
        {
            var list = DapperHelper.QueryStoredProcedure<GrcodeSelect_dt>("sp_GrCodeSelect ",
                new { search = search }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Grcode")]
        public IHttpActionResult Post(Grcode_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_GrCodeInsert", model);
            return Ok();
        }
    }
}
