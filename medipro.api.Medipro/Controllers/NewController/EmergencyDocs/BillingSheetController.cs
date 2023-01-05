using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EmergencyDocs
{
    public class BillingSheetController : ApiController
    {
        [HttpPost]
        [Route("api/BillingSheet")]
        public IHttpActionResult Post(BillingSheetInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingSheetInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/BillingSheet/Update")]
        public IHttpActionResult Update(BillingSheetUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingSheetUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/BillingSheet")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<BillingSheetGetdata_dt>("sp_BillingSheetGetdata",
                new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/BillingSheet/Delete")]
        public IHttpActionResult Delete(BillingSheetDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingSheetDelete", model);
            return Ok();
        }
    }
}
