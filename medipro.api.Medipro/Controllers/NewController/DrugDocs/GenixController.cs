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
    public class GenixController : ApiController
    {

        [HttpPost]
        [Route("api/Genix")]
        public IHttpActionResult Post(Genix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_GenericInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Genix/Update")]
        public IHttpActionResult Update(Genix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_GenericUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Genix")]
        public IHttpActionResult get(int genid)
        {
            generic_dt generic = new generic_dt();
            var list = DapperHelper.QueryStoredProcedure<Genix_dt>
                ("sp_GenericGetdata", new { genid = genid }).ToList();
            generic.Generic = list;
            return Ok(generic);
        }


        [HttpPost]
        [Route("api/Genix/Delete")]
        public IHttpActionResult Delete(GenixDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_GenericDelete", model);
            return Ok();
        }
    }
}
