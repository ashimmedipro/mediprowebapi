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
    public class PurcdetController : ApiController
    {
        [HttpPost]
        [Route("api/Purcdet")]
        public IHttpActionResult Post(Purcdet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurcdetInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Purcdet/Update")]
        public IHttpActionResult Update(Purcdet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PrucdetUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Purcdet")]
        public IHttpActionResult get(int sn)
        {
            PurcdetList_dt Purcdet = new PurcdetList_dt();
            var list = DapperHelper.QueryStoredProcedure<Purcdet_dt>
                ("sp_PurcdetGetdata", new { sn = sn }).ToList();
            Purcdet.Purcdet = list;
            return Ok(Purcdet);
        }


        [HttpPost]
        [Route("api/Purcdet/Delete")]
        public IHttpActionResult Delete(PurcdetDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurcdetDelete", model);
            return Ok();
        }
    }
}
