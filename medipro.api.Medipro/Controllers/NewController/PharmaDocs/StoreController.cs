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
    public class StoreController : ApiController
    {
        [HttpPost]
        [Route("api/Store")]
        public IHttpActionResult Post(Store_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_storeInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Store/Update")]
        public IHttpActionResult Update(Store_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_storeUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Store")]
        public IHttpActionResult Get(int id)
        {
            var list = DapperHelper.QueryStoredProcedure<Store_dt>
                ("sp_storeSelect", new { id = id }).ToList();
            return Ok(list);
        }


        [HttpPost]
        [Route("api/Store/Delete")]
        public IHttpActionResult Delete(StoreDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_storeDelete", model);
            return Ok();
        }

    }
}
