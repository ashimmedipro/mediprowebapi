using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.AccountDocs;
using medipro.api.Medipro.Models.NewModels.PharmaDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.PharmaDocs
{
    public class ChallanController : ApiController
    {
       

        [HttpGet]
        [Route("api/allChallanByDate")]   
        public IHttpActionResult GetChallanAll(DateTime init_date,DateTime final_date)
        {
            var list = DapperHelper.QueryStoredProcedure<allChallan_dt>
                ("sp_ChallanrecSelectByDate", new { init_date = init_date,final_date=final_date}).ToList();
            return Ok(list);
        }


        //sp_GetMdCodeForChallanrec QTY
        [HttpGet]
        [Route("api/DrugListChallan")]
        public IHttpActionResult GetDrugListChallan()
        {
            var list = DapperHelper.QueryStoredProcedure<challanGetDrugList_dt>
                ("sp_GetMdCodeForChallanrec")
                .ToList();
            return Ok(list);
        }


        //sp_SelectPartyByAc_CodeForChallanrec
        //search 
        [HttpGet]
        [Route("api/partyGetByAcCodeForChallan")]
        public IHttpActionResult GetPartyByAcCodeSearch(String search)
        {
            var list = DapperHelper.QueryStoredProcedure<partySelect_dt>
                ("  ", new { search=search}).ToList();
            return Ok(list);
        }

        //without search
        [HttpGet]
        [Route("api/partyGetByAcCodeForChallan")]
        public IHttpActionResult GetPartyByAcCodeSelect()
        {
            var list = DapperHelper.QueryStoredProcedure<partySelect_dt>
                ("sp_SelectPartyByAc_CodeForChallanrec", new { search = "" }).ToList();
            return Ok(list);
        }


        //RETUNRS QTY not used
        [HttpGet]
        [Route("api/challanGetStbalByMdCode")]
        public IHttpActionResult GetProdByMdCode(int md_code)
        {
            var list = DapperHelper.QueryStoredProcedure<challanGet_dt>
                ("sp_StbalSelectByMdCode", new { md_code = md_code}).ToList();
            return Ok(list);
        }


        //GET BATCHES
        [HttpGet]
        [Route("api/batchForChallanByMdCode")]
        public IHttpActionResult GetBalbyMdCode(int md_code)
        {
            var list = DapperHelper.QueryStoredProcedure <challanGetBatch_dt>
                ("sp_StbalSelectbydate", new { md_code = md_code }).ToList();
            return Ok(list);
        }


        //ChallanController Insert
        [HttpPost]
        [Route("api/challanMasterInsert")]
        public IHttpActionResult Post(challanInsert_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ChallanrecMasterInsert", model);
            return Ok();
        }

        //SEE CHALLAN TO SEE DETAILS
        [HttpGet]
        [Route("api/challanDetailsByInvno")]
        public IHttpActionResult GetChallanDetails (string inv_no)
        {
            var list = DapperHelper.QueryStoredProcedure<challanDetails_dt>
                ("sp_ChallanrecSelectbyInvno", new { inv_no = inv_no }).ToList();
            return Ok(list);
        }

        // sp_ChallanrecSelectByDate



        //public ActionResult Index()
        //{
        //    return View();
        //}
    }
}