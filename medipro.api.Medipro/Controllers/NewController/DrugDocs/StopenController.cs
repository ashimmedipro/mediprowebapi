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
    public class StopenController : ApiController
    {
        [HttpPost]
        [Route("api/Stopen")]
        public IHttpActionResult Post(Stopen_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_StopenInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Stopen/Update")]
        public IHttpActionResult Update(Stopen_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_StopenUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Stopen")]
        public IHttpActionResult get(int sn)
        {
            StopenList_dt Stopen = new StopenList_dt();
            var list = DapperHelper.QueryStoredProcedure<Stopen_dt>
                ("sp_StopenGetdata", new { sn = sn }).ToList();
            Stopen.Stopen = list;
            return Ok(Stopen);
        }


        [HttpPost]
        [Route("api/Stopen/Delete")]
        public IHttpActionResult Delete(StopenDelete_dt model) 
        {
            DapperHelper.ExecuteStoredProcedure("sp_StopenDelete ", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Stopen1")]
        public IHttpActionResult Post(Stopen1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_STOPEN1Insert", model);
            return Ok();
        }
    }
}
