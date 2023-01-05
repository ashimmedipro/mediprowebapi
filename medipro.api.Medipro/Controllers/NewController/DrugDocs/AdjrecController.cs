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
    public class AdjrecController : ApiController
    {
        [HttpPost]
        [Route("api/Adjrec")]
        public IHttpActionResult Post(Adjrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Adjrec/Update")]
        public IHttpActionResult Update(Adjrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Adjrec")]
        public IHttpActionResult get(int sn)
        {
            AdjrecList_dt Adjrec = new AdjrecList_dt();
            var list = DapperHelper.QueryStoredProcedure<Adjrec_dt>
                ("sp_AdjrecGetdata", new { sn = sn }).ToList();
            Adjrec.Adjrec = list;
            return Ok(Adjrec);
        }


        [HttpPost]
        [Route("api/Adjrec/Delete")]
        public IHttpActionResult Delete(AdjrecDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecDelete ", model);
            return Ok();
        }
    }
}
