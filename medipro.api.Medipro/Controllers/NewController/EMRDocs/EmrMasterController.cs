using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EMRDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EMRDocs
{
 

    public class EmrMasterController : ApiController
    {
        //insert 

        [HttpPost]
        [Route("api/EMRMaster/Insert")]
        public IHttpActionResult Post(EmrMaster_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmrMasterInsert", model);

            return Ok();
        }


        //update

        [HttpPost]
        [Route("api/EMRMaster/Update")]
        public IHttpActionResult Update(EmrMaster_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmrMasterUpdate", model);
            return Ok();
        }

        //select

        [HttpGet]
        [Route("api/EMRMaster/Select")]

        public IHttpActionResult Get( )
        {
            var list = DapperHelper.QueryStoredProcedure<EmrMaster_dt>
                ("sp_EmrMasterSelect").ToList();
            return Ok(list);
        }


        //delete

        [HttpPost]
        [Route("api/EMRMaster/Delete")]
        public IHttpActionResult Delete(EmrMasterDelete_dt model)
        {
            DapperHelper.ExecuteStoredProcedure("sp_EmrMasterDelete", model);
            return Ok();
        }

    }

}
