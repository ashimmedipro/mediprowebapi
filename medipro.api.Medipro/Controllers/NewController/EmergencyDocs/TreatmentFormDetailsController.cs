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
    public class TreatmentFormDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/TreatmentFormDetails")]
        public IHttpActionResult Post(TreatmentFormDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/TreatmentFormDetails/Update")]
        public IHttpActionResult Update(TreatmentFormDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/TreatmentFormDetails")]
        public IHttpActionResult Get(int order_id)
        {
            var list = DapperHelper.QueryStoredProcedure<TreatmentFormDetailsGetdata_dt>
                ("sp_TreatmentFormDetailsGetdata", new { order_id = order_id }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/TreatmentFormDetails/Delete")]
        public IHttpActionResult Delete(TreatmentFormDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_TreatmentFormDetailsDelete", model);
            return Ok();
        }
    }
}
