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
    public class EmergencyFormDetailController : ApiController
    {
        //temp insert
         
        [HttpPost]
        [Route("api/TempEmergencyFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempEmergencyFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/EmergencyFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(EmergencyFormDetailsBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempEmergencyFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/EmergencyFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<EmergencyFormDetailsSelect_dt>
                ("sp_EmergencyFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/EmergencyFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergenctyFromDetailDelete", model);
            return Ok();
        }

    }
}
