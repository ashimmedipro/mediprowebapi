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
    public class PartDisc1Controller : ApiController
    {
        [HttpPost]
        [Route("api/PartDisc1")]
        public IHttpActionResult Post(PartDisc1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PARTDISC1_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/PartDisc1/Update")]
        public IHttpActionResult Update(PartDisc1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PARTDISC1_Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/PartDisc1")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<PartDisc1_dt>
                ("sp_PARTDISC1_Select", new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/PartDiscMax")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<ParDisc1SelectMax_dt>
                ("sp_PARTDISC1_MaxSelect").ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/PartDisc1/Delete")]
        public IHttpActionResult Delete(PartDisc1Delete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_PARTDISC1_Delete", model);
            return Ok();
        }
    }
}
