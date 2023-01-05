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
    public class CashReceiptEntryController : ApiController
    {
        [HttpPost]
        [Route("api/CashReceiptEntryNew")]
        public IHttpActionResult Post(CashReceiptEntry_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ReceiptEntryInsert", model);

            return Ok();
        }

        [HttpGet]
        [Route("api/SelectLedgerBalanceByAccode")]
        public IHttpActionResult GetLedgerBalance(int ac_code, DateTime ddate, int firm)
        {

            var list = DapperHelper.QueryStoredProcedure<SelectLedgerBalancebyAccode_dt>
                ("sp_LedgerBalanceByAc_code", new { ac_code = ac_code, ddate = ddate, firm = firm }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/SelectPartyByAccode")]
        public IHttpActionResult GetParty()
        {

            var list = DapperHelper.QueryStoredProcedure<SelectPartybyAccode_dt>
                ("sp_SelectPartyByAc_Code").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/SelectBankByAccode")]
        public IHttpActionResult GetBank()
        {

            var list = DapperHelper.QueryStoredProcedure<SelectbankbyAccode_dt>
                ("sp_SelectBankByAc_Code").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/SelectAccodeBySbcode")]
        public IHttpActionResult GetAccode()
        {

            var list = DapperHelper.QueryStoredProcedure<SelectbankbyAccode_dt>
                ("sp_SelectbySb_code").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/SelectOpbalBalanceByAccode")]
        public IHttpActionResult GetOpbalrBalance(int ac_code, int firm)
        {

            var list = DapperHelper.QueryStoredProcedure<SelectOpbalBalancebyAccode_dt>
                ("sp_Op_balBalanceByAc_code", new { ac_code = ac_code,  firm = firm }).ToList();
            return Ok(list);
        }
    }
}
