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
    public class ProductDivisionController : ApiController
    {
        [HttpPost]
        [Route("api/ProductDivision")]
        public IHttpActionResult Post(ProductDivision_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_product_division_Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/ProductDivision/Update")]
        public IHttpActionResult Update(ProductDivision_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_product_division_Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/ProductDivision")]
        public IHttpActionResult Get(int div_id)
        {
            var list = DapperHelper.QueryStoredProcedure<ProductDivisionSelect_dt>
                ("sp_product_division_Select", new { div_id = div_id }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/ProductDivision/Delete")]
        public IHttpActionResult Delete(ProductDivisionDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_product_division_Delete", model);
            return Ok();
        }
    }
}
