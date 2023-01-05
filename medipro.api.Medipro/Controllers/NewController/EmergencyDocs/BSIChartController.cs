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
    public class BSIChartController : ApiController
    {
        [HttpPost]
        [Route("api/BSIChart")]
        public IHttpActionResult Post(BSIChartInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChart_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/BSIChart/Update")]
        public IHttpActionResult Update(BSIChartUpdate_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChart_Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/BSIChart")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<BSIChartGetdata_dt>
                ("sp_BSIChart_Getdata", new { sn = sn }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/BSIChart/Delete")]
        public IHttpActionResult Delete(BSIChartDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_BSIChart_Delete", model);
            return Ok();
        }
    }
}
