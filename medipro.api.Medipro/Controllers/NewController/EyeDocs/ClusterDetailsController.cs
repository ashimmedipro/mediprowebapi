using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class ClusterDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/Cluster/Select")]
        public IHttpActionResult Get(int cluster_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<Cluster_dt>
                ("sp_ClusterSelectByClusterNo", new { cluster_no = cluster_no }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


        [HttpGet]
        [Route("api/Cluster/SelectMaxKesId")]
        public IHttpActionResult SelectMaxKesID(int clusterNo)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<ClusterMaxKesId_dt>
                ("sp_EyeRegGetMaxKesnobyClusterNo", new { clusterNo = clusterNo }).ToList();
            return Ok(list);

            }
            catch (Exception ex)
            {
                var except = ex.Message;
                return ResponseMessage(
           Request.CreateResponse(
               HttpStatusCode.InternalServerError,
               new { sucess = false, error_message = except }

               ));
            }
        }


    }
}
