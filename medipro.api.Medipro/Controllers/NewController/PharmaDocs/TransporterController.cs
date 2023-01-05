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
    public class TransporterController : ApiController
    {
        [HttpPost]
        [Route("api/Transporter")]
        public IHttpActionResult Post(Transporter_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_transpoterInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Transporter/Update")]
        public IHttpActionResult Update(Transporter_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_transpoterUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Transporter")]
        public IHttpActionResult Get()
        {
            TransporterList_dt Transporter = new TransporterList_dt();
            var list = DapperHelper.QueryStoredProcedure<Transporter_dt>
                ("sp_transporterSelect").ToList();
            Transporter.Transporter = list;
            return Ok(Transporter);
        }

        [HttpPost]
        [Route("api/Transporter/Delete")]
        public IHttpActionResult Delete(TransporterDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_transporterDelete", model);
            return Ok();
        }

    }
}
