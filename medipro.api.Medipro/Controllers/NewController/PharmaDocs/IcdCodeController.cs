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
    public class IcdCodeController : ApiController
    {
        [HttpPost]
        [Route("api/IcdCode")]
        public IHttpActionResult Post(IcdCode_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/IcdCode/Update")]
        public IHttpActionResult Update(IcdCode_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/IcdCode")]
        public IHttpActionResult Get(int icdgroup)
        {
            var list = DapperHelper.QueryStoredProcedure<IcdCode_dt>
                ("sp_icdcodeSelect", new { icdgroup = icdgroup }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/IcdCode/Delete")]
        public IHttpActionResult Delete(IcdCodeDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeDelete", model);
            return Ok();
        }
    }
}
