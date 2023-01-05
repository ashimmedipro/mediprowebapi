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
    public class BSIChartDetailsController : ApiController
    {
        [HttpPost]
        [Route("api/BSIChartDetails")]
        public IHttpActionResult Post(BSIChartDetailsInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChartDetailsInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/BSIChartDetails/Update")]
        public IHttpActionResult Update(BSIChartDetailsUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChartDetailsUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/BSIChartDetails")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<BSIChartDetailsGetdata_dt>
                ("sp_BSIChartDetailsGetdata", new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/BSIChartDetails/Delete")]
        public IHttpActionResult Delete(BSIChartDetailsDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChartDetailsDelete", model);
            return Ok();
        }
    }
}
