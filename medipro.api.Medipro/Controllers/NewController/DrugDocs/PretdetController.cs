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
    public class PretdetController : ApiController
    {

        [HttpPost]
        [Route("api/Pretdet")]
        public IHttpActionResult Post(Pretdet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PretdetInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Pretdet/Update")]
        public IHttpActionResult Update(Pretdet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PretdetUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Pretdet")]
        public IHttpActionResult get(int sn)
        {
            PretdetList_dt Pretdet = new PretdetList_dt();
            var list = DapperHelper.QueryStoredProcedure<Pretdet_dt>
                ("sp_PretdetGetdata", new { sn = sn }).ToList();
            Pretdet.Pretdet = list;
            return Ok(Pretdet);
        }


        [HttpPost]
        [Route("api/Pretdet/Delete")]
        public IHttpActionResult Delete(PretdetDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PretdetDelete", model);
            return Ok();
        }
    }
}
