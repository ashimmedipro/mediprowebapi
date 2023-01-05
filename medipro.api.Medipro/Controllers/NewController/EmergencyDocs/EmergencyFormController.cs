using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EmergencyDocs;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EmergencyDocs
{
    public class EmergencyFormController : ApiController
    {
        [HttpPost]
        [Route("api/EmergencyForm")]
        public IHttpActionResult Post(EmergencyFormInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormInsert", model);
           
            return Ok();
        }

        [HttpPost]
        [Route("api/EmergencyInvestigation")]
        public IHttpActionResult PostInvestigation(EmergencyInvestigation_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyInvestigation", model);

            return Ok();
        }

        [HttpPost]
        [Route("api/tempEmergencyInvestigation")]
        public IHttpActionResult PosttempInvestiagtion(tempEmergencyInvestigation_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TempEmergencyInvestigation", model);

            return Ok();
        }

        [HttpPost]
        [Route("api/EmergencyForm/Update")]
        public IHttpActionResult Update(EmergencyFormUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/EmergencyForm")]

        public IHttpActionResult Get(int emergency_id)
        {
            var list = DapperHelper.QueryStoredProcedure<EmergencyFormGetdata_dt>
                ("sp_EmergencyFormGetdata", new { emergency_id = emergency_id }).ToList();
            return Ok(list);
        }

       


        [HttpPost]
        [Route("api/EmergencyForm/Delete")]
        public IHttpActionResult Delete(EmergencyFormDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmergencyFormdelete", model);
            return Ok();
        }

        
    
    }
}
