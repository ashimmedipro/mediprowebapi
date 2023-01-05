using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class VisionRefractionModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/VisionAndRefraction")]
        public IHttpActionResult Get()
        {
            VisionRefractionModify v = new VisionRefractionModify();


            v.VisionRefrationInsert();
            v.VisionRefractionUpdate(); 
            v.VisionRefractionSelect();
            v.VisionRefractionDelete();
            v.VisionRefractionDetailInsert();
            v.VisionRefractionDetailUpdate();
            v.VisionRefractionDetailSelect();
            v.VisionRefractionDetailDelete();
            v.TempVisionRefractionDetailInsert();
            v.TempVisionRefractionDetailBulkInsert();
            v.TempVisionRefractionDetailDelete();


            return Ok();

        }
    }
}
