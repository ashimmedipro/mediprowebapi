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
    public class PurchaseEntryController : ApiController
    {
        [HttpPost]
        [Route("api/PurchaseEntryMaster")]
        public IHttpActionResult Post(PurchaseEntryMaster_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PurchaseEntryMaster",model);
            return Ok();
        }
    }
}
