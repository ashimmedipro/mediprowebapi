using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceReceiptPrintModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/AdvanceReceiptPrintModify")]
        public IHttpActionResult Get()
        {
            AdvanceReceiptPrintModify a = new AdvanceReceiptPrintModify();

            a.AdvanceReceiptPrintSelect();



            return Ok();

        }
    }
}
