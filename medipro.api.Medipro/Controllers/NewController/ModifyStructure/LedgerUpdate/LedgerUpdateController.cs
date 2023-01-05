using medipro.api.Medipro.Models.NewModels.LedgerUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.LedgerUpdate
{
    public class LedgerUpdateController : ApiController
    {
        [HttpGet]
        [Route("api/LedgerUpdate")]
        public IHttpActionResult LedgerUpdate()
        {
            LedgerUpdateSbledCode l  = new LedgerUpdateSbledCode();

            l.LedgerUpdate();


            return Ok();

        }

        [HttpGet]
        [Route("api/OpbalUpdate")]
        public IHttpActionResult OpBalUpdate()
        {
            OpBalUpdate o = new OpBalUpdate();

            o.OpBalUpdateSbledCode();


            return Ok();

        }
    }
}
