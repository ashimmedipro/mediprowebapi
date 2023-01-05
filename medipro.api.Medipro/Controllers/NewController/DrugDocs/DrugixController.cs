using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.DrugDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.DrugDocs
{
    public class DrugixController : ApiController
    {
        [HttpPost]
        [Route("api/Drugix")]
        public IHttpActionResult Post(Drugix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrugInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Drugix/Update")]
        public IHttpActionResult Update(Drugix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrugUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Drugix")]
        public IHttpActionResult Get(int md_code)
        {
            DrugixList_dt Drug = new DrugixList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugixSelect_dt>
                ("sp_DrugGetdata", new { md_code = md_code }).ToList();
            Drug.Drug = list;
            return Ok(Drug);
        }

      


        [HttpPost]
        [Route("api/Drugix/Delete")]
        public IHttpActionResult Delete(DrugixDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrugDelete", model);
            return Ok();
        }
    }
}
