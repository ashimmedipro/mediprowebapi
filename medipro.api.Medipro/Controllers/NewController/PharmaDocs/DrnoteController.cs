using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{

    public class DrnoteController : ApiController
    {
        [HttpPost]
        [Route("api/Drnote")]
        public IHttpActionResult Post(Drnote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrnoteInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Drnote/Update")]
        public IHttpActionResult Update(Drnote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrnoteUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Drnote")]
        public IHttpActionResult Get(string dr_no)
        {
            DrnoteList_dt Drnote = new DrnoteList_dt();
            var list = DapperHelper.QueryStoredProcedure<Drnote_dt>
                ("sp_DrnoteSelect", new { dr_no = dr_no }).ToList();
            Drnote.Drnote = list;
            return Ok(Drnote);
        }


        [HttpPost]
        [Route("api/Drnote/Delete")]
        public IHttpActionResult Delete(DrnoteDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrnoteDelete", model);
            return Ok();
        }
    }
}
