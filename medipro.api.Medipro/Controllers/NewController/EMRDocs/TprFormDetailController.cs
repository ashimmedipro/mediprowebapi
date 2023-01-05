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
    public class TprFormDetailController : ApiController
    {
        //temp insert

        [HttpPost]
        [Route("api/TempTprFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempTprFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/TprFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(ConsentFormDetailBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempTprFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/TprFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<ClinicalProgressSelect_dt>
                ("sp_TprFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/TprFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TrpFromDetailDelete", model);
            return Ok();
        }
    }
}
