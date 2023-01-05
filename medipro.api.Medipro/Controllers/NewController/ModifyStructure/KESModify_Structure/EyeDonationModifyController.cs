using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.ModifyStructure.KESModify_Structure
{
    public class EyeDonationModifyController : ApiController
    {
        [HttpGet]
        [Route("api/ModifyStructure/kes/EyeDonation")]
        public IHttpActionResult Get()
        {

            EyeDontationModify e = new EyeDontationModify();

            e.EyeDonationDetailInsert();
            e.EyeDonationDetailSelect();
            e.EyeDonationDetailDelete();
            e.TempEyeDonationDetailInsert();
            e.TempEyeDonationDetailBulkInsert();
            e.TempEyeDonationDetailDelete();



            return Ok();

        }
    }
}
