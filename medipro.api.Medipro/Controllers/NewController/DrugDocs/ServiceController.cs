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
    public class ServiceController : ApiController
    {
        [HttpPost]
        [Route("api/Service")]
        public IHttpActionResult Post(Service_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ServiceInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Service/Update")]
        public IHttpActionResult Update(Service_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ServiceUpdate", model);
                return Ok();
        }

        [HttpGet]
        [Route("api/Service/{search}/{patho}")]
        public IHttpActionResult Get(string search, int patho)
        {
            ServiceList_dt Service = new ServiceList_dt();
            var list = DapperHelper.QueryStoredProcedure<Service_dt>
                ("sp_ServiceSelect", new { search =search, patho=patho}).ToList();
            Service.Service = list;
            return Ok(Service);
        }
    }
}
