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
    public class SectorController : ApiController
    {
        [HttpPost]
        [Route("api/Sector")]
        public IHttpActionResult Post(Sector_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SECTORInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Sector/Update")]
        public IHttpActionResult Update(Sector_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_SECTORUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Sector")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<Sector_dt>
                ("sp_SECTORSelect").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/SectorInsertSelect")]
        public IHttpActionResult GetSelect()
        {
            var list = DapperHelper.QueryStoredProcedure<Sector_dt>
                ("sp_SectorInsertSelect").ToList();
            return Ok(list);
        }


    }
}
