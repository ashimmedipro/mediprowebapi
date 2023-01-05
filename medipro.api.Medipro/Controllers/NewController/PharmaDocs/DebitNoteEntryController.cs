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
    public class DebitNoteEntryController : ApiController
    {
        [HttpPost]
        [Route("api/DebitNoteEntry")]
        public IHttpActionResult PostDraft(DebitNoteEntry_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DebitNoteEntry", model);
            return Ok();
        }
    }
}
