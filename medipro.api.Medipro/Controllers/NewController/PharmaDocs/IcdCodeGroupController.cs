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
    public class IcdCodeGroupController : ApiController
    {
        [HttpPost]
        [Route("api/IcdCodeGroup")]
        public IHttpActionResult Post(IcdCodeGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeGroupInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/IcdCodeGroup/Update")]
        public IHttpActionResult Update(IcdCodeGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeGroupUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/IcdCodeGroup")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<IcdCodeGroup_dt>
                ("sp_icdcodegroupSelect" ).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/IcdCodeGroup/Delete")]
        public IHttpActionResult Delete(IcdCodeGroupDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_IcdCodeGroupDelete", model);
            return Ok();
        }
    }
}
