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
    public class DrugRackGroupController : ApiController
    {

        [HttpPost]
        [Route("api/DrugRackGroup")]
        public IHttpActionResult Post(DrugRackGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drugrackgroupinsert", model);
            return Ok();
        }

        [HttpPost]
        [Route("api/DrugRackGroup/Update")]
        public IHttpActionResult Update(DrugRackGroup_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_drugrackgroupinsert", model);
            return Ok();
        }

        [HttpGet]
        [Route("api/DrugRackGroup/{search}")]
        public IHttpActionResult Get(string search)
        {
            var list = DapperHelper.QueryStoredProcedure<DrugRackGroupSelect_dt>
                ("sp_drugrackgroupselect", new { search = search }).ToList();
            return Ok(list);
        }

        [HttpGet]
        [Route("api/DrugRackGroups/{search}")]
        public IHttpActionResult GetAll(string search)
        {
            DrugRackGroupList_dt Drugrackgroup = new DrugRackGroupList_dt();
            var list = DapperHelper.QueryStoredProcedure<DrugRackGroupSelect_dt>
                ("sp_drugrackgroupselect", new { search = "" }).ToList();
            Drugrackgroup.Drugrackgroup = list;
            return Ok(Drugrackgroup);
        }

    }
}
