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
    public class DrugGenixController : ApiController
    { 
        [HttpGet]
        [Route("api/DrugGenix")]
        public IHttpActionResult Get(int md_code)
        {
            DrugGenixList_dt Druggeneric = new DrugGenixList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugGenixSelect_dt>
                ("sp_druggenericSelect", new { md_code = md_code }).ToList();
            Druggeneric.Druggeneric = list;
            return Ok(Druggeneric);
        }
    }
}
