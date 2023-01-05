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
    public class DivisionController : ApiController
    {
        [HttpPost]
        [Route("api/Division")]
        public IHttpActionResult Post(Division_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DivisionInsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/Division/Update")]
        public IHttpActionResult Update(Division_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DivisionUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Division/Select")]
        public IHttpActionResult Get()
        {
            DivisionList_dt division = new DivisionList_dt();
            var list = DapperHelper.QueryStoredProcedure<Division_dt>("sp_divisionSelect").ToList();
            division.Division = list;
            return Ok(division);
            
        }


        //report

        [HttpGet]
        [Route("api/Division/Report")]
        public IHttpActionResult Report(int dp_id)
        {
            var list = DapperHelper.QueryStoredProcedure<DivisionReport_dt>
                ("sp_DivisionReport", new { dp_id=dp_id}).ToList();
            return Ok(list);
        }


    }
}
