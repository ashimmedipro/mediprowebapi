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
    public class PurchaseDetController : ApiController
    {
        [HttpPost]
        [Route("api/PurchaseDet")]
        public IHttpActionResult Post(TPurchDet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_tPurchDetInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/TPurchaseDet/Edit")]
        public IHttpActionResult Edit(TpurchdetEdit_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_tPurchDetEdit", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/PurchaseDet1")]
        public IHttpActionResult Posta(TPurchDet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_tpurchdet1", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/PurchaseDet/Update")]
        public IHttpActionResult Update(TPurchDet_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_tPurchDetUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/TPurchaseDet/{mode}/{userid}/{sn}/{inv_no}")]
        public IHttpActionResult Get(string mode, int userid, int sn, string inv_no)
        {
            var list= DapperHelper.QueryStoredProcedure<TPurchDetSelect_dt>("sp_tPurchDetSelect", new { mode
            = mode, userid = userid, sn = sn, inv_no = inv_no}).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/TpurchdetSelectDrugDetails")]
        public IHttpActionResult Get()
        {
            var list = DapperHelper.QueryStoredProcedure<TpurchdetSelectDrugDetails_dt>("sp_tpurchdetSelectDrugDetails").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/TempPurcdetSum/{userid}/{disc}/{cc_ex}/{vat_Free_prod}")]
        public IHttpActionResult Get(int userid, float disc, bool cc_ex, bool vat_Free_prod)
        {
            var list = DapperHelper.QueryStoredProcedure<TempPurcdetSum_dt>("sp_TempPurcdetSum",
                new { userid =userid, disc=disc, cc_ex=cc_ex, vat_Free_prod = vat_Free_prod }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/TempPurcdetSelectByUserid")]
        public IHttpActionResult Getuserid(int userid)
        {
            var list = DapperHelper.QueryStoredProcedure<TpurchdetSelectbyUserid_dt>("sp_tPurchdetSelectByUserid",
                new { userid = userid }).ToList();
            return Ok(list);
        }

        [HttpPost]
        [Route("api/tPurchaseDet/Delete")]
        public IHttpActionResult Delete(TPurchDetDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_tPurchdetDeletebysn", model);
            return Ok();
        }


    }
}
