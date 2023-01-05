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
    public class ObservationSheetDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/ObservationSheetDetails")]
        public IHttpActionResult Post(ObservationSheetDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObservationSheetDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ObservationSheetDetails/Update")]
        public IHttpActionResult Update(ObservationSheetDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObservationSheetDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ObservationSheetDetails")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<ObservationSheetDetailsSelect_dt>
                ("sp_ObservationSheetDetailsSelect", new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/ObservationSheetDetails/Delete")]
        public IHttpActionResult Delete(ObservationSheetDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObservationSheetDetailsDelete", model);
            return Ok();
        }
    }
}
