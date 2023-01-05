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
    public class SalesController : ApiController
    {
        [HttpPost]
        [Route("api/Sales")]
        public IHttpActionResult Post(Sales_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Sales1Insert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Sales/Update")]
        public IHttpActionResult Update(Sales_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Sales1Update", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/Sales")]
        public IHttpActionResult get(int inv_no)
        {
            SalesList_dt Sales = new SalesList_dt();
            var list = DapperHelper.QueryStoredProcedure<Sales_dt>
                ("sp_Sales1Getdata", new { inv_no = inv_no }).ToList();
            Sales.Sales = list;
            return Ok(Sales);
        }


        [HttpPost]
        [Route("api/Sales/Delete")]
        public IHttpActionResult Delete(SalesDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_Sales1Delete ", model);
            return Ok();
        }
    }
}
