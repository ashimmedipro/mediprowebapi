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
    public class DrugRackController : ApiController
    {
        [HttpPost]
        [Route("api/DrugRack")]
        public IHttpActionResult Post(DrugRack_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drugrackinsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DrugRack/Update")]
        public IHttpActionResult Update(DrugRack_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drugrackinsert", model);
            return Ok();
        }

      

        [HttpGet]
        [Route("api/DrugRack")]
        public IHttpActionResult Get(int sn)
        {
            DrugRackList_dt Drugrack = new DrugRackList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugRackSelect_dt>
                ("sp_drugrackselect", new { sn = sn }).ToList();
            Drugrack.Drugrack = list;
            return Ok(Drugrack);
        }





    }
}
