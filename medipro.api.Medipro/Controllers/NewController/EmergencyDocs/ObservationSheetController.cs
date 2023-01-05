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
    public class ObservationSheetController : ApiController
    {
        [HttpPost]
        [Route("api/ObservationSheet")]
        public IHttpActionResult Post(ObservationSheetInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObesrvationSheetInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ObservationSheet/Update")]
        public IHttpActionResult Update(ObservationSheetUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObesrvationSheetUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ObservationSheet")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<ObservationSheetGetdata_dt>("sp_ObesrvationSheetGetdata",
                new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/ObservationSheet/Delete")]
        public IHttpActionResult Delete(ObservartionSheetDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ObesrvationSheetDelete ", model);
            return Ok();
        }
    }
}
