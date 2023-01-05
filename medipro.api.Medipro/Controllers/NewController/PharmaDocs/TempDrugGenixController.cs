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
    public class TempDrugGenixController : ApiController
    {
        [HttpPost]
        [Route("api/TempDrugGenix")]
        public IHttpActionResult Post(TempDrugGenix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Temp2DrugenericInsert", model);
            return Ok();
        }


        [HttpGet]
        [Route("api/tempDrugGenix")]
        public IHttpActionResult Get(int userid)
        {
            var list = DapperHelper.QueryStoredProcedure<tempDrugGenixSelect_dt>
                ("sp_temp_druggenericSelect", new { userid = userid }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/tempDrugGenix/Delete")]
        public IHttpActionResult Delete(tempDrugGenixDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_temp_druggenericDelete", model);
            return Ok();
        }


    }
}
