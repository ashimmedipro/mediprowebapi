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
    public class templedger1Controller : ApiController
    {
        [HttpPost]
        [Route("api/templedger1")]
        public IHttpActionResult Post(templedger1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_temppledger1Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/templedger1/Update")]
        public IHttpActionResult Update(templedger1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_temppledger1Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/templedger1")]
        public IHttpActionResult Get(double serial)
        {
            var list = DapperHelper.QueryStoredProcedure<templedger1_dt>
                ("sp_temppledger1Select", new { serial = serial }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/templedger1/Delete")]
        public IHttpActionResult Delete(templedger1_Delete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_temppledger1Delete", model);
            return Ok();
        }
    }
}
