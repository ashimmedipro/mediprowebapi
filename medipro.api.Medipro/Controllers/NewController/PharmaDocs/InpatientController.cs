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
    public class InpatientController : ApiController
    {
        [HttpPost]
        [Route("api/Inpatient")]
        public IHttpActionResult Post(Inpatient_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_InpatientInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Inpatient/Update")]
        public IHttpActionResult Update(Inpatient_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_InpatientUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Inpatient")]
        public IHttpActionResult Get(int ipdno)
        {
            var list = DapperHelper.QueryStoredProcedure<Inpatient_dt>
                ("sp_InpatientSelect", new { ipdno = ipdno }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Inpatient/Delete")]
        public IHttpActionResult Delete(InpatientDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_InpatientDelete", model);
            return Ok();
        }

    }
}
