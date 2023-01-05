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
    public class AdmissionRecordsController : ApiController
    {
        [HttpPost]
        [Route("api/AdmissionRecords")]
        public IHttpActionResult Post(AdmissionRecordsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AdmissionRecords/Update")]
        public IHttpActionResult Update(AdmissionRecordsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsUpdate", model);
            return Ok();
        }



        [HttpGet]
        [Route("api/AdmissionRecords")]
        public IHttpActionResult get(int admission_id)
        {
            var list = DapperHelper.QueryStoredProcedure<AdmissionRecordsGetData_dt>
                ("sp_AdmissionRecordsGetdata", new { admission_id = admission_id }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/AdmissionRecords/Delete")]
        public IHttpActionResult Delete(AdmissionRecordsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionRecordsDelete", model);
            return Ok();
        }
       
    }
}
