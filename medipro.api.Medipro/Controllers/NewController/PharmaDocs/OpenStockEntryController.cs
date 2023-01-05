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
    public class OpenStockEntryController : ApiController
    {
        [HttpPost]
        [Route("api/OpenStockEntry")]
        public IHttpActionResult Post(OpenStockEntryInsert_Dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpenStockEntryInsert", model);
            return Ok();
        }
    }
}
