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
    public class CrnoteController : ApiController
    {
        [HttpPost]
        [Route("api/Crnote")]
        public IHttpActionResult Post(Crnote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CrnoteInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Crnote/Update")]
        public IHttpActionResult Update(Crnote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CrnateUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Crnote")]
        public IHttpActionResult get(int cr_no)
        {
            CrnoteList_dt Crnote = new CrnoteList_dt();
            var list = DapperHelper.QueryStoredProcedure<Crnote_dt>
                ("sp_CrnoteGetdata", new { cr_no = cr_no }).ToList();
            Crnote.Crnote = list;
            return Ok(Crnote);
        }


        [HttpPost]
        [Route("api/Crnote/Delete")]
        public IHttpActionResult Delete(CrnoteDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CrnoteDelete", model);
            return Ok();
        }
    }
}
