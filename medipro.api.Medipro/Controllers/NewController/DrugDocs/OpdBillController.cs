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
    public class OpdBillController : ApiController
    {
        [HttpPost]
        [Route("api/OpdBill")]
        public IHttpActionResult Post(OpdBill_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdbillInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/OpdBill/Update")]
        public IHttpActionResult Update(OpdBill_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdbillUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/OpdBill")]
        public IHttpActionResult Get(string inv_no)
        {
            OpdBillList_dt Opdbill = new OpdBillList_dt();
            var list = DapperHelper.QueryStoredProcedure<OpdBill_dt>("sp_OpdbillGetdata",
                new { inv_no = inv_no }).ToList();
            Opdbill.Opdbill = list;
            return Ok(Opdbill);
        }

        [HttpPost]
        [Route("api/OpdBill/Delete")]
        public IHttpActionResult Delete(OpdBillDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_OpdbillDelete ", model);
            return Ok();
        }
    }
}
