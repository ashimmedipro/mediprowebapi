using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.DrugDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.DrugDocs
{
    public class PurretuController : ApiController
    {
        [HttpPost]
        [Route("api/Purretu")]
        public IHttpActionResult Post(Purretu_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurretuInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Purretu/Update")]
        public IHttpActionResult Update(Purretu_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurretuUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Purretu")]
        public IHttpActionResult get(string inv_no)
        {
            PurretuList_dt Purretu = new PurretuList_dt();
            var list = DapperHelper.QueryStoredProcedure<Purretu_dt>
                ("sp_purretuGetdata", new { inv_no = inv_no }).ToList();
            Purretu.Purretu = list;
            return Ok(Purretu);
        }


        [HttpPost]
        [Route("api/Purretu/Delete")]
        public IHttpActionResult Delete(PurretuDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurretuDelete", model);
            return Ok();
        }
    }
}
