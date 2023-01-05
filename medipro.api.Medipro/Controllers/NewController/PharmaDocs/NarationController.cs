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
    public class NarationController : ApiController
    {
        [HttpPost]
        [Route("api/Naration")]
        public IHttpActionResult Post(Naration_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NARATION_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Naration/Update")]
        public IHttpActionResult Update(Naration_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NARATION_Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Naration")]
        public IHttpActionResult Get(int sn)
        {
            var list = DapperHelper.QueryStoredProcedure<Naration_dt>
                ("sp_NARATION_Select", new { sn = sn }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/Naration/Delete")]
        public IHttpActionResult Delete(NarationDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_NARATION_Delete", model);
            return Ok();
        }
    }
}
