using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using medipro.api.Medipro.Models.NewModels.EMRDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmergencyFormDetailsDelete_dt = medipro.api.Medipro.Models.NewModels.EMRDocs.EmergencyFormDetailsDelete_dt;

namespace medipro.api.Medipro.Controllers.NewController.EMRDocs
{
    public class ClinicalProgressController : ApiController
    { 
        //temp insert

        [HttpPost]
        [Route("api/TempClinicalProgressFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempClinicalProgressFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/ClinicalProgressFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(ConsentFormDetailBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempClinicalProgressFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/ClinicalProgressFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<ClinicalProgressSelect_dt>
                ("sp_ClinicalProgressFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/ClinicalProgressFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ClinicalProgressFromDetailDelete", model);
            return Ok();
        }
    }
}
