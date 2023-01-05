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
    public class SalretuController : ApiController
    {
        [HttpPost]
        [Route("api/Salretu")]
        public IHttpActionResult Post(Salretu_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SalretuInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Salretu/Update")]
        public IHttpActionResult Update(Salretu_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SalretuUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Salretu")]
        public IHttpActionResult get(int sn)
        {
            SalretuList_dt Salretu = new SalretuList_dt();
            var list = DapperHelper.QueryStoredProcedure<Salretu_dt>
                ("sp_SalretuGetdata", new { sn = sn }).ToList();
            Salretu.Salretu = list;
            return Ok(Salretu);
        }


        [HttpPost]
        [Route("api/Salretu/Delete")]
        public IHttpActionResult Delete(SalretuDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SalretuDelete ", model);
            return Ok();
        }
    }
}
