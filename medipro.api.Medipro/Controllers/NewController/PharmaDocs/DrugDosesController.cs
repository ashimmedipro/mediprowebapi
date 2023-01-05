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
    public class DrugDosesController : ApiController
    {
        [HttpPost]
        [Route("api/DrugDoses")]
        public IHttpActionResult Post(DrugDoses_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drug_dosesinsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DrugDoses/Update")]
        public IHttpActionResult Update(DrugDoses_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drug_dosesinsert", model);
            return Ok();
        }


        [HttpPost]
        [Route("api/DrugDoses/Delete")]
        public IHttpActionResult Delete(DrugDosesDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drug_dosesDelete", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/DrugDoses")]
        public IHttpActionResult Get()
        {
            DrugDoseList_dt Drugdoses = new DrugDoseList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugDosesSelect_dt>("sp_drug_dosesSelect").ToList();
            Drugdoses.Drugdoses = list;
            return Ok(Drugdoses);
        }

        [HttpPost]
        [Route("api/DrugDosesDetail")]
        public IHttpActionResult Post(DrugDosesDetail_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drug_doses_detailInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DrugDosesDetail/Update")]
        public IHttpActionResult Update(DrugDosesDetail_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drug_doses_detailInsert", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/DrugDosesDetail")]
        public IHttpActionResult Get(int sn)
        {
            DrugDosesDetailList_dt Drugdosesdetail = new DrugDosesDetailList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugDosesDetailSelect_dt>
                ("sp_Drug_Doses_DetailSelect", new { sn = sn }).ToList();
            Drugdosesdetail.Drugdosesdetail = list;
            return Ok(Drugdosesdetail);
        }
    }
}
