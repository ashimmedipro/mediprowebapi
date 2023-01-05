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
    public class StbalController : ApiController
    {
        [HttpPost]
        [Route("api/Stbal")]
        public IHttpActionResult Post(Stbal_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_StbalInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Stbal/Update")]
        public IHttpActionResult Update(Stbal_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_StbalUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Stbal")]
        public IHttpActionResult get(int sn)
        {
            StbalList_dt Stbal = new StbalList_dt();
            var list = DapperHelper.QueryStoredProcedure<Stbal_dt>
                ("sp_StbalGetdata", new { sn = sn }).ToList();
            Stbal.Stbal = list;
            return Ok(Stbal);
        }


        [HttpPost]
        [Route("api/Stbal/Delete")]
        public IHttpActionResult Delete(StbalDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_StbalDelete", model);
            return Ok();
        }
    }
}
