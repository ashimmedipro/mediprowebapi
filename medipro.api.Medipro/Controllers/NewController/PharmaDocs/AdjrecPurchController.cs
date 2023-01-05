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
    public class AdjrecPurchController : ApiController
    {
        [HttpPost]
        [Route("api/AdjrecPurch")]
        public IHttpActionResult Post(AdjrecPurch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecpurchInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AdjrecPurch/Update")]
        public IHttpActionResult Update(AdjrecPurch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecpurchUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AdjrecPurch")]
        public IHttpActionResult Get(int sn)
        {
            AdjrecPurchList_dt Adjrecpurch = new AdjrecPurchList_dt();
            var list = DapperHelper.QueryStoredProcedure<AdjrecPurch_dt>
                ("sp_AdjrecpurchSelect", new { sn = sn }).ToList();
            Adjrecpurch.Adjrecpurch = list;
            return Ok(Adjrecpurch);
        }

        [HttpPost]
        [Route("api/AdjrecPurch/Delete")]
        public IHttpActionResult Delete(AdjrecPurch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjrecpurchDelete", model);
            return Ok();
        }
    }
}
