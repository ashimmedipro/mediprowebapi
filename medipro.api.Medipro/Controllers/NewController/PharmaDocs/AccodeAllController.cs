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
    public class AccodeAllController : ApiController
    {
        [HttpPost]
        [Route("api/AccodeAll")]
        public IHttpActionResult Post(Ac_Code_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AcCodeInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AccodeAll/Update")]
        public IHttpActionResult Update(Ac_Code_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AcCodeUpdate", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/AccodeAll/Delete")]
        public IHttpActionResult Delete(Ac_Code_Delete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_AcCodeDelete", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/AccodeSelectAllbyfirm")]
        public IHttpActionResult Select(int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<accode_SelectByFirm_dt>
                ("sp_AccountCodeSelectByFirm", new { firm = firm }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectbysbcodeandfirmAll")]
        public IHttpActionResult Get(int sb_code,int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<Accode_byBank_dt>
                ("sp_AccountCodeSelect", new {sb_Code = sb_code, firm = firm }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectAll/{search}")]//for ac_code_select1
        public IHttpActionResult Search(string search)
        {
            var list = DapperHelper.QueryStoredProcedure<ac_code_select1_dt>
                ("sp_accodeselect1", new { search = search }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectbyitem")]
        public IHttpActionResult Selectitem(string item)
        {
            var list = DapperHelper.QueryStoredProcedure<ac_code_selectbyitem_dt>
                ("sp_ac_codeSelectbyItem", new { item = item }).ToList();
            return Ok(list);
        }


        [HttpGet]
        [Route("api/AccodeSelectbygroupname")]
        public IHttpActionResult SelectByName()
        {
            var list = DapperHelper.QueryStoredProcedure<ac_code_selectbygroupname_dt>
                ("sp_ac_codeSelectbyGroupName").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectbygroupCode")]
        public IHttpActionResult SelectByCode()
        {
            var list = DapperHelper.QueryStoredProcedure<ac_code_selectbygroupCode_dt>
                ("sp_ac_code_SelectGroupCode").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectSelector")]
        public IHttpActionResult SelectSelector()
        {
            var list = DapperHelper.QueryStoredProcedure<ac_code_selectSelector_dt>
                ("sp_ac_codeSelectSector").ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/AccodeSelectDepreciationAndMaintenance")]
        public IHttpActionResult SelectDepreciationAndMaintenance(int sb_code, int firm)
        {
            var list = DapperHelper.QueryStoredProcedure<Ac_CodeselectDepreciation_Maintenance_dt>
                ("sp_ac_codeSelectDepreciation_Maintainance", new { sb_Code = sb_code, firm = firm }).ToList();
            return Ok(list);
        }
    }
}
