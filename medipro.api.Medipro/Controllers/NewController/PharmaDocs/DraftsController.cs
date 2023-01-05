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
    public class DraftsController : ApiController
    {
        [HttpPost]
        [Route("api/Drafts")]
        public IHttpActionResult Post(Drafts_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DraftsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Drafts/Update")]
        public IHttpActionResult Update(Drafts_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DraftsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Drafts")]
        public IHttpActionResult Get(string df_no)
        {
            DraftsList_dt Drafts = new DraftsList_dt();
            var list = DapperHelper.QueryStoredProcedure<Drafts_dt>
                ("sp_draftsSelect", new { df_no = df_no }).ToList();
            Drafts.Drafts = list;
            return Ok(Drafts);
        }

        [HttpPost]
        [Route("api/Drafts/Delete")]
        public IHttpActionResult Delete(Drafts_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_draftsDelete", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DraftsReceiptEntry")]
        public IHttpActionResult PostDraft(DraftReceiptEntry_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DraftRecieptEntry", model);
            return Ok();
        }
    }
}
