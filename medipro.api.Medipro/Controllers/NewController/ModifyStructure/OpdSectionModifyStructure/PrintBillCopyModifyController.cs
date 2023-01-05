using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure
{
    public class PrintBillCopyModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/PrintBillCopyModify")]
        public IHttpActionResult Get()
        {

            PrintBillCopyModify p = new PrintBillCopyModify();
            p.OpdbillSelect();
            p.OpdrecSelect();
            p.CopyReceiptSelect();
            p.CopyPanelRecSelect();
            p.PrintBillCopyOpdBillUpdate();



            return Ok();

        }
    }
}
