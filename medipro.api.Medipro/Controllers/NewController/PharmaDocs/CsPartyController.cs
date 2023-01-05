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
    public class CsPartyController : ApiController
    {
        [HttpPost]
        [Route("api/CsParty")]
        public IHttpActionResult Post(CsParty_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CspartyInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/CsParty/Update")]
        public IHttpActionResult Update(CsParty_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CspartyUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/CsParty")]
        public IHttpActionResult Get()
        {
            CsPartyList_dt Csparty = new CsPartyList_dt();
            var list = DapperHelper.QueryStoredProcedure<CsPartySelect_dt>
                ("sp_CspartySelect").ToList();
            Csparty.Csparty = list;
            return Ok(Csparty);
        }

        [HttpGet]
        [Route("api/CsParty1")]
        public IHttpActionResult Select()
        {
            var list = DapperHelper.QueryStoredProcedure<CsPartySelect1_dt>
                ("sp_CspartySelect1").ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/CsParty/Delete")]
        public IHttpActionResult Delete(CsPartyDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CspartyDelete", model);
            return Ok();
        }
    }
}
