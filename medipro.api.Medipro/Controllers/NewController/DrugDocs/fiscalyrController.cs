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
    public class fiscalyrController : ApiController
    {
        [HttpGet]
        [Route("api/fiscalyr")]
        public IHttpActionResult Get()
        {
            fiscalyearList_dt Fiscalyear = new fiscalyearList_dt();
            var list = DapperHelper.QueryStoredProcedure<fiscalyear_dt>("sp_fiscalyrSelect").ToList();
            Fiscalyear.Fiscalyear = list;
            return Ok(Fiscalyear);
        }

        [HttpPost]
        [Route("api/fiscalyr")]
        public IHttpActionResult Post(fiscalyrInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_FiscalyrInsert", model);
            return Ok();
        }
    }
}
