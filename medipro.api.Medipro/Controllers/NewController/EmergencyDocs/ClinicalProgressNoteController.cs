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
    public class ClinicalProgressNoteController : ApiController
    {
        [HttpPost]
        [Route("api/ClinicalProgress")]
        public IHttpActionResult Post(ClinicalProgressInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ClinicalProgressInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ClinicalProgress/Update")]
        public IHttpActionResult Update(ClinicalProgressUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ClinicalProgressUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ClinicalProgress")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<ClinicalProgressGetdata_dt>
                ("sp_ClinicalProgressGetdata", new { sn = sn }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/ClinicalProgress/Delete")]
        public IHttpActionResult Delete(ClinicalProgressDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ClinicalProgressDelete", model);
            return Ok();

        }
    }
}
