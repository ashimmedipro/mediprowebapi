using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using medipro.api.Medipro.Models.NewModels.EMRDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EMRDocs
{
    public class HistoryExamFindingController : ApiController
    {
        //temp insert

        [HttpPost]
        [Route("api/TempHistoryExamFindingFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempHisExamFindingsFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/HistoryExamFindingFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(ConsentFormDetailBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempHisExamFindingsFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/HistoryExamFindingFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<HistroyExamFindingSelect_dt>
                ("sp_HisExamFindingsFormDetailSelect").ToList();
            return Ok(list);
        }



        //delete

        [HttpPost]
        [Route("api/HistoryExamFindingFormDetail/Delete")]
        public IHttpActionResult Delete(HisExamFindDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_HisExamFindingsFromDetailDelete", model);
            return Ok();
        }
    }
}
