using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class OcularInvDetailPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/OcularInvestigationPivot")]
        public IHttpActionResult Get()
        {

            OcularInvestigationDetailPivotModify o = new OcularInvestigationDetailPivotModify();

            o.OcularInvView();
            o.OcularInvPivot();




            return Ok();

        }
    }
}
