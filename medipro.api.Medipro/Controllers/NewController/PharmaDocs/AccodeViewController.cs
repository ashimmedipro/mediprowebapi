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
    public class AccodeViewController : ApiController
    {
        /* [HttpGet]
        [Route("api/AccodeView")]
        public IHttpActionResult Get()
        {
           var list = DapperHelper.QueryStoredProcedure<AccodeView_dt>
              ("sp_ac_code_viewSelect", new {search = "" }).ToList();
            return Ok(list);
        }*/

        [HttpGet]
        [Route("api/AccodeView/{search}")]
        public IHttpActionResult Search(string search)
        {
            AccodeViewList_dt Accodeview = new AccodeViewList_dt();
            var list = DapperHelper.QueryStoredProcedure<AccodeView_dt>
                ("sp_ac_code_viewSelect", new { search = search }).ToList();
            Accodeview.Accodeview = list;
            return Ok(Accodeview);
        }


        [HttpGet]
        [Route("api/AccodeSelectbyBank")]
        public IHttpActionResult GetBank(int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<Accode_byBank_dt>
                ("sp_ac_codeSelectBank", new { firm = firm }).ToList();
            return Ok(list);
        }

        

        [HttpGet]
        [Route("api/AccodeSelectbytds")]
        public IHttpActionResult Getbytds(int sb_code)
        {
            var list = DapperHelper.QueryStoredProcedure<SelectBytds_dt>
                ("sp_ac_code_tds_code_Select", new { sb_code = sb_code }).ToList();
            return Ok(list);
        }
    }
}
