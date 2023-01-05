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
    public class EmpDeptController : ApiController
    {
        [HttpPost]
        [Route("api/EmpDept")]
        public IHttpActionResult Post(EmpDept_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmpdeptInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/EmpDept/Update")]
        public IHttpActionResult Update(EmpDept_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmpdeptUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/EmpDept/select")]
        public IHttpActionResult Get(int dptid)
        {
            var list = DapperHelper.QueryStoredProcedure<EmpDeptSelect_dt>
                ("sp_EmpdeptSelect", new { dptid = dptid }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/EmpDept/Delete")]
        public IHttpActionResult Delete(EmpDeptDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmpdeptDelete", model);
            return Ok();
        }
    }
}
