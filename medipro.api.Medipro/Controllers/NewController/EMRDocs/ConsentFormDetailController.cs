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
    public class ConsentFormDetailController : ApiController
    {
        //temp insert
         
        [HttpPost]
        [Route("api/TempConsentFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempConsentFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/ConsentFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(ConsentFormDetailBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempConsentFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/ConsentFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<ConsentFormDetailSelect_dt>
                ("sp_ConsentFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/ConsentFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ConsentFromDetailDelete", model);
            return Ok();
        }
    }
}
