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
    public class BillingSheetDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/BillingSheetDetails")]
        public IHttpActionResult Post(BillingSheetDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingSheetDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/BillingSheetDetails/Update")]
        public IHttpActionResult Update(BillingSheetDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingSheetDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/BillingSheetDetails")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<BillingSheetDetailsGetdata_dt>("sp_BillingDetailsGetdata",
                new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/BillingSheetDetails/Delete")]
        public IHttpActionResult Delete(BillingSheetDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BillingDetailsDelete", model);
            return Ok();
        }
    }
}

    

