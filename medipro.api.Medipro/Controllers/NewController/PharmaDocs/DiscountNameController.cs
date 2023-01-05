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
    public class DiscountNameController : ApiController
    {
        [HttpPost]
        [Route("api/DiscountName")]
        public IHttpActionResult Post(DiscountName_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DiscountNameInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DiscountName/Update")]
        public IHttpActionResult Update(DiscountName_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DiscountNameUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/DiscountName")]
        public IHttpActionResult Get()
        {
            DiscountNameList_dt Discountname = new DiscountNameList_dt();
            var list = DapperHelper.QueryStoredProcedure<DiscountName_dt>
                ("sp_DiscountNameSelect").ToList();
            Discountname.Discountname = list;
            return Ok(Discountname);
        }

        [HttpGet]
        [Route("api/DiscountNameMax")]
        public IHttpActionResult Select()
        {
            var list = DapperHelper.QueryStoredProcedure<DiscountNameSelectMax_dt>
                ("sp_DiscountNameSelectMaxofDiscount_id").ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/DiscountName/Delete")]
        public IHttpActionResult Delete(DiscountNameDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_DiscountNameDelete", model);
            return Ok();
        }

        //REPORT

        [HttpGet]
        [Route("api/DiscountName/Report")]
        public IHttpActionResult Report()
        {
            var list = DapperHelper.QueryStoredProcedure<DiscountNameReprot_dt>
                ("sp_SchemeDiscountReport").ToList();
            return Ok(list);
        }

    }
}
