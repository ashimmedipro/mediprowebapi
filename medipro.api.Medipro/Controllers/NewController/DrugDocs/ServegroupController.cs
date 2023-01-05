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
    public class ServegroupController : ApiController
    {
        [HttpPost]
        [Route("api/Servegroup")]
        public IHttpActionResult Post(Servegroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ServgroupInsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/Servegroup/Update")]
        public IHttpActionResult Update(Servegroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_ServgroupUpdate", model);
            return Ok();
        }


        [HttpGet]
        [Route("api/Servegroup/Select")]
        public IHttpActionResult Get(string search="")
        {
            ServegroupList_dt Servegroup = new ServegroupList_dt();
            var list = DapperHelper.QueryStoredProcedure<Servegroup_dt>("sp_ServgroupSelect", new { search=search}).ToList();
            Servegroup.Servegroup = list;
            return Ok(Servegroup);
        }


        //report

        [HttpGet]
        [Route("api/Servegroup/Report")]
        public IHttpActionResult Report(int grpid)
        {
            var list = DapperHelper.QueryStoredProcedure<ServegroupReport_dt>
                ("sp_ServiceGroupSetupReport", new { grpid = grpid }).ToList();
            return Ok(list);
        }
    }
}
