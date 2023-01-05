﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.OpdSectionModifyStructure.AdvanceAndChangeSection
{
    public class AdvanceReceiptModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/AdvanceReceiptModify")]
        public IHttpActionResult Get()
        {
            AdvanceReceiptModify a = new AdvanceReceiptModify();

            a.AccodeCardSelect();
            a.AdvanceNewMemberInsert();
            a.AdvanceOldMemberInsert();
            a.AdvanceMemberSelect();



            return Ok();

        }
    }
}
