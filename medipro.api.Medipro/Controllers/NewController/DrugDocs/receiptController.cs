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
    public class receiptController : ApiController
    {
        [HttpPost]
        [Route("api/receipt")]
        public IHttpActionResult Post(receipt_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ReceiptInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/receipt/Update")]
        public IHttpActionResult Update(receipt_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ReceiptUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/receipt")]
        public IHttpActionResult Get(int r_no)
        {
            receiptList_dt Receipt = new receiptList_dt();
            var list = DapperHelper.QueryStoredProcedure<receipt_dt>("sp_ReceiptGetdata",
                new { r_no = r_no }).ToList();
            Receipt.Receipt = list;
            return Ok(Receipt);
        }

        [HttpPost]
        [Route("api/receipt/Delete")]
        public IHttpActionResult Delete(receiptDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ReceiptDelete", model);
            return Ok();
        }
    }
}
