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
    public class opdrecController : ApiController
    {
        [HttpPost]
        [Route("api/opdrec")]
        public IHttpActionResult Post(opdrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdrecInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/opdrec/Update")]
        public IHttpActionResult Update(opdrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdrecUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/opdrec")]
        public IHttpActionResult Get(int sn)
        {
            opdrecList_dt Opdrec = new opdrecList_dt();
            var list = DapperHelper.QueryStoredProcedure<opdrec_dt>("sp_OpdrecGetdata",
                new { sn = sn }).ToList();
            Opdrec.Opdrec = list;
            return Ok(Opdrec);
        }

        [HttpPost]
        [Route("api/opdrec/Delete")]
        public IHttpActionResult Delete(opdrecDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdrecDelete", model);
            return Ok();
        }
    }
}
