using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EMRDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EMRDocs
{
    public class ChargeAndBillingSheetController : ApiController
    {
        //temp insert   

        [HttpPost]
        [Route("api/TempChargeAndBillingSheetFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempChargeBillingSheetFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/ChargeAndBillingSheetFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(ConsentFormDetailBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempChargeBillingSheetFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/ChargeAndBillingSheetFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<ClinicalProgressSelect_dt>
                ("sp_ChargeBillingSheetFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/ChargeAndBillingSheetFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChargeBillingSheetFromDetailDelete", model);
            return Ok();
        }
    }
}
