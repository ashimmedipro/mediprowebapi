using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class VisionAndRefractionPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/VisionAndRefractionPivot")]
        public IHttpActionResult Get()
        {

            VisionAndRefractionPivotModify vm = new VisionAndRefractionPivotModify();
            vm.VisionRefractionDetailsView();
            vm.VisionRefractionPivot();


            return Ok();

        }
    }
}
