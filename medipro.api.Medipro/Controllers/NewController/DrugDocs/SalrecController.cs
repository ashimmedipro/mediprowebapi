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
    public class SalrecController : ApiController
    {
        [HttpPost]
        [Route("api/Salrec")]
        public IHttpActionResult Post(Salrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Salrec1Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Salrec/Update")]
        public IHttpActionResult Update(Salrec_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Salrec1Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Salrec")]
        //[Authorize("admin", "user")]
        public IHttpActionResult get(int sn)
        {
            SalrecList_dt Salrec = new SalrecList_dt();
            var list = DapperHelper.QueryStoredProcedure<Salrec_dt>
                ("sp_Salrec1Getdata", new { sn = sn }).ToList();
            Salrec.Salrec = list;
            return Ok(Salrec);
        }


        [HttpPost]
        [Route("api/Salrec/Delete")]
        public IHttpActionResult Delete(SalrecDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Salrec1Delete ", model);
            return Ok();
        }
    }
}
