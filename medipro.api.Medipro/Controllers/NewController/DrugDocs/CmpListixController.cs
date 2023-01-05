using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.DrugDocs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace medipro.api.Medipro.Controllers.DrugDocs
{
    public class CmpListixController : ApiController
    {
        [HttpPost]
        [Route("api/CmpListix")]
        public IHttpActionResult Post(CmpListix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CmpListInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/CmpListix/Update")]
        public IHttpActionResult Update(CmpListix_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CmpListUpdate", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/CmpListix")]
        public IHttpActionResult get(int compcode)
        {
            CompanyList_dt cmplist = new CompanyList_dt();

            var list = DapperHelper.QueryStoredProcedure<CmpListix_dt> 
               ("sp_CmplistGetdata", new { compcode = compcode }).ToList();
            //var list1 = Newtonsoft.Json.JsonConvert.SerializeObject(list);

            cmplist.Cmplist = list;
            return Ok(cmplist);
        }


        [HttpPost]
        [Route("api/CmpListix/Delete")]
        public IHttpActionResult Delete(CmpListixDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_CmplistDelete", model);
            return Ok();
        }


    }
}
