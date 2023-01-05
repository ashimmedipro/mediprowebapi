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
    public class AdjVouchController : ApiController
    {
        [HttpPost]
        [Route("api/AdjVouch")]
        public IHttpActionResult Post(AdjVouch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjvouchInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AdjVouch/Update")]
        public IHttpActionResult Update(AdjVouch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjvouchUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AdjVouch")]
        public IHttpActionResult Get(string vr_no)
        {
            AdjVouchList_dt Adjvouch = new AdjVouchList_dt();
            var list = DapperHelper.QueryStoredProcedure<AdjVouch_dt>
                ("sp_AdjvouchSelect", new { vr_no = vr_no }).ToList();
            Adjvouch.Adjvouch = list;
            return Ok(Adjvouch);
        }

        [HttpPost]
        [Route("api/AdjVouch/Delete")]
        public IHttpActionResult Delete(AdjVouch_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AdjvouchDelete", model);
            return Ok();
        }
    }
}
    