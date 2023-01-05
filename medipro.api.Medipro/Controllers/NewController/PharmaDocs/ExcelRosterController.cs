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
    public class ExcelRosterController : ApiController
    {
        [HttpPost]
        [Route("api/Excelroster")]
        public IHttpActionResult Post(ExcelRoster_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ExcelRosterInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Excelroster1")]
        public IHttpActionResult Post(ExcelRoster1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_1ExcelRosterInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Excelroster1/Update")]
        public IHttpActionResult Update(ExcelRoster1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_1ExcelRosterUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Excelroster1")]
        public IHttpActionResult Get1(float emp_code)
        {
            var list = DapperHelper.QueryStoredProcedure<ExcelRoster1_dt>
                ("sp_1ExcelRosterSelect", new { emp_code = emp_code }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Excelroster1/Delete")]
        public IHttpActionResult Delete(ExcelRoster1_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_1ExcelRosterDelete", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Excelroster2")]
        public IHttpActionResult Post(ExcelRoaster2_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_2ExcelRosterInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Excelroster2/Update")]
        public IHttpActionResult Update(ExcelRoaster2_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_2ExcelRosterUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Excelroster2")]
        public IHttpActionResult Get2(float emp_code)
        {
            var list = DapperHelper.QueryStoredProcedure<ExcelRoaster2_dt>
                ("sp_2ExcelRosterSelect", new { emp_code = emp_code }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Excelroster2/Delete")]
        public IHttpActionResult Delete(ExcelRoaster2_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_2ExcelRosterDelete", model);
            return Ok();
        }
    }
}
