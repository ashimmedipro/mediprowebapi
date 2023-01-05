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
    public class AdmissionFormDetailController : ApiController
    {
        //temp insert

        [HttpPost]
        [Route("api/TempAdmissionFormDetail/Insert")]
        public IHttpActionResult TempPost(TempEmergencyFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempAdmissionFormDetailInsert", model);

            return Ok();
        }

        //bulk insert
        [HttpPost]
        [Route("api/AdmissionFormDetail/BulkInsert")]
        public IHttpActionResult BulkPost(EmergencyFormDetailsBulkInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempAdmissionFormDetailBulkInsert", model);

            return Ok();
        }


        //select 

        [HttpGet]
        [Route("api/AdmissionFormDetail/Select")]

        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<AdmissionFormDetailSelect_dt>
                ("sp_AdmissionFormDetailSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/AdmissionFormDetail/Delete")]
        public IHttpActionResult Delete(EmergencyFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdmissionFromDetailDelete", model);
            return Ok();
        }
    }
}
