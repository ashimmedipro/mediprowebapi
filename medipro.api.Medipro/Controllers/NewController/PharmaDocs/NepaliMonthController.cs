using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class NepaliMonthController : ApiController
    {
        [HttpPost]
        [Route("api/NepaliMonth")]
        public IHttpActionResult Post(NepaliMonth_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NepaliMonth_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/NepaliMonth/Update")]
        public IHttpActionResult Update(NepaliMonth_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NepaliMonth_Update", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/NepaliMonth/Delete")]
        public IHttpActionResult Delete (NepaliMonthDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NepaliMonth_Delete", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/NepaliMonth")]
        public IHttpActionResult get(string serial)
        {
            var list = DapperHelper.QueryStoredProcedure<NepaliMonth_dt>
                ("sp_NepaliMonth_Select", new { serial = serial }).ToList();
            return Ok(list);
        }
    }
}
