using medipro.api.Medipro.Controllers.NewController.PharmaDocs;
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
    public class CreditNoteController : ApiController
    {
        [HttpPost]
        [Route("api/CreditNote")]
        public IHttpActionResult Post(CreditNote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CredirtnoteInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/CreditNote/Update")]
        public IHttpActionResult Update(CreditNote_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CredirtnoteUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/CreditNote")]
        public IHttpActionResult Get(string cr_no)
        {
            CreditNoteList_dt Creditnote = new CreditNoteList_dt();
            var list = DapperHelper.QueryStoredProcedure<CreditNote_dt>
                ("sp_CredirtnoteSelect", new { cr_no = cr_no }).ToList();
            Creditnote.Creditnote = list;
            return Ok(Creditnote);
        }

        [HttpPost]
        [Route("api/CreditNote/Delete")]
        public IHttpActionResult Delete(CreditNoteDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CredirtnoteDelete", model);
            return Ok();
        }
    }
}
