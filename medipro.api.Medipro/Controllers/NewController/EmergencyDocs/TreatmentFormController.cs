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
    public class TreatmentFormController : ApiController
    {
        [HttpPost]
        [Route("api/TreatmentForm")]
        public IHttpActionResult Post(TreatmentFormInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/TreatmentForm/Update")]
        public IHttpActionResult Update(TreatmentFormUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/TreatmentForm")]
        public IHttpActionResult Get(int order_id)
        {
            var list = DapperHelper.QueryStoredProcedure<TreatmentFormGetdata_dt>
                ("sp_TreatmentFormGetdata", new { order_id = order_id }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/TreatmentForm/Delete")]
        public IHttpActionResult Delete(TreatmentFormDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormDelete", model);
            return Ok();
        }
    }
}
