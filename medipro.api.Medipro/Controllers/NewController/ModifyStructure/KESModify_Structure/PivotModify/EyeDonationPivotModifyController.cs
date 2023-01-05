using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure.PivotModify
{
    public class EyeDonationPivotModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/EyeDonationPivot")]
        public IHttpActionResult Get()
        {

            EyeDonationPivotModify e = new EyeDonationPivotModify();

            e.EyeDonationView();
            e.EyeDonationPivot();




            return Ok();

        }
    }
}
