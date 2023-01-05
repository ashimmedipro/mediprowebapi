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
    public class AdjBookController : ApiController
    {
        [HttpPost]
        [Route("api/AdjBook")]
        public IHttpActionResult Post(AdjBook_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjBookInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AdjBook/Update")]
        public IHttpActionResult Update(AdjBook_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjBookUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AdjBook/{inv_no}")]
        public IHttpActionResult Get()
        {
            AdjBookList_dt Adjbook = new AdjBookList_dt();
            var list = DapperHelper.QueryStoredProcedure<AdjBook_dt>
                ("sp_AdjBookGetdata", new { inv_no = "" }).ToList();
            Adjbook.AdjBook = list;

            return Ok(Adjbook);
        }


        [HttpPost]
        [Route("api/AdjBook/Delete")]
        public IHttpActionResult Delete(AdjBookDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjBookDelete", model);
            return Ok();
        }
    }
}
