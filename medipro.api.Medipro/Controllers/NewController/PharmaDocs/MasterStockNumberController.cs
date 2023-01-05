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
    public class MasterStockNumberController : ApiController
    {
        [HttpPost]
        [Route("api/MasterStockNumber")]
        public IHttpActionResult Post(MasterStockNumber_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_master_stock_number_insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/MasterStockNumberMax")]
        public IHttpActionResult Postmax(MasterStockNumber_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_master_stock_number_MaxInsert", model);
            return Ok();
        }

    }
}
