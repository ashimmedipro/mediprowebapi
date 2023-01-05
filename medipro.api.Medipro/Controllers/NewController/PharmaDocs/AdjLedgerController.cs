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
    public class AdjLedgerController : ApiController
    {
        [HttpPost]
        [Route("api/Adjledger")]
        public IHttpActionResult Post(AdjLedger_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjledgerInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Adjledger/Update")]
        public IHttpActionResult Update(AdjLedger_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjledgerUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Adjledger")]
        public IHttpActionResult Get(int sn)
        {
            AdjledgerList_dt Adjledger = new AdjledgerList_dt();
            var list = DapperHelper.QueryStoredProcedure<AdjLedger_dt>
                ("sp_AdjledgerSelect", new { sn = sn }).ToList();
            Adjledger.Adjledger = list;
            return Ok(Adjledger);
        }


        [HttpPost]
        [Route("api/Adjledger/Delete")]
        public IHttpActionResult Delete(AdjLedger_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjledgerDelete", model);
            return Ok();
        }
    }
}
