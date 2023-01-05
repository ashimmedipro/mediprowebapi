using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class PrintReceiptModifyController : ApiController
    {

        [HttpGet]
        [Route("api/ModifyStructure/PrintReceiptModify")]
        public IHttpActionResult Get()
        {

            PrintReceiptModify pr = new PrintReceiptModify();

            pr.PrintReceiptSelect();
            pr.SerivceSelect();



            return Ok();

        }
    }
}
