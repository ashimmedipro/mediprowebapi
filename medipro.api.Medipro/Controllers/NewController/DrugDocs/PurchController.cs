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
    public class PurchController : ApiController
    {
        [HttpPost]
        [Route("api/Purch")]
        public IHttpActionResult Post(Purch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurchInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Purch/Update")]
        public IHttpActionResult Update(Purch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurchUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Purch")]
        public IHttpActionResult get(int inv_no)
        {
            PurchList_dt Purch = new PurchList_dt();
            var list = DapperHelper.QueryStoredProcedure<Purch_dt>
                ("sp_PurchGetdata", new { inv_no = inv_no }).ToList();
            Purch.Purch = list;
            return Ok(Purch);
        }


        [HttpPost]
        [Route("api/Purch/Delete")]
        public IHttpActionResult Delete(PurchDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurchDelete", model);
            return Ok();
        }
    }
}
