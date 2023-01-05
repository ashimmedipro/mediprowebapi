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
    public class NewDrugGroupController : ApiController
    {
        [HttpPost]
        [Route("api/NewDrugGroup")]
        public IHttpActionResult Post(DrugGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DrugGroupInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/NewDrugGroup/Update")]
        public IHttpActionResult Update(DrugGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_druggroupUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/NewDrugGroup")]
        public IHttpActionResult Get( int grpid)
        {
            var list = DapperHelper.QueryStoredProcedure<DrugGroupSelect_dt>
                ("sp_druggroupSelect", new { grpid = grpid }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/NewDrugGroup/Delete")]
        public IHttpActionResult Delete(DrugGroupDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drugsgroupDelete", model);
            return Ok();
        }
    }
}
