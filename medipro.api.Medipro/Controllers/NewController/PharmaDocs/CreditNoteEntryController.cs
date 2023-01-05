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
    public class CreditNoteEntryController : ApiController
    {

        [HttpPost]
        [Route("api/CreditNoteEntry")]
        public IHttpActionResult PostDraft(CreditNoteEntry_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CreditNoteEntry", model);
            return Ok();
        }
    }
}
