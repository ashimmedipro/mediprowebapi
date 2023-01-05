using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.DueSectionModify
{
    public class DueClearModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/DueClearModify")]
        public IHttpActionResult Get()
        {
            DueClearModify d = new DueClearModify();

            d.DueClearViewSelect();
            d.DueClearSelect();
            d.DueClearInsert();



            return Ok();

        }
    }
}
