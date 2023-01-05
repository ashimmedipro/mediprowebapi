using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.DueSectionModify
{
    public class CurrentDueReportModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/CurrentDueReportModify")] 
        public IHttpActionResult Get()
        {
            CurrentDueReportModify c = new CurrentDueReportModify();
            c.tOpdBillDue();
            c.RefererSelect();
            c.CurrentDueReportSelect();
            c.TOpdbillDue1Select();
            c.TOpdbillDue1TotalSelect();



            return Ok();

        }
    }
}

