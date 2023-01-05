using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs
{
    public class ServGroupController : ApiController
    {
        [HttpPost]
        [Route("api/servGroupInsert")]
        public IHttpActionResult PostServGroup(servGroupPost_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_servgroupInsert", model);
            return Ok();
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
        [Route("api/servGroupGet")]
        public IHttpActionResult GetServGroup(string search="")
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<servGroupGet_dt>
                ("sp_servgroupSelect", new { search = search }).ToList();
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


        //[HttpGet]
        //[Route("api/serviceGet")]
        //public IHttpActionResult GetService(int grpid, string search, string status)
        //{
        //    try
        //    {

            
        //    var list = DapperHelper.QueryStoredProcedure<serviceSelect_dt>
        //        ("sp_serviceSelect", new { grpid = grpid, search = search, status= status }).ToList();
        //    return Ok(list);
        //    }
        //    catch (Exception ex)
        //    {
        //        var except = ex.Message;
        //        return ResponseMessage(
        //   Request.CreateResponse(
        //       HttpStatusCode.InternalServerError,
        //       new { sucess = false, error_message = except }

        //       ));
        //    }
        //}

        [HttpPost]
        [Route("api/servGroupInsert/Update")]
        public IHttpActionResult UpdateServGroup(servGroupPost_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_servgroupUpdate", model);
            return Ok();
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

        //get by sbcode
        [HttpGet]
        [Route("api/servGroupGetBySbCode")]
        public IHttpActionResult GetBySbCode(int sb_code)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ServGrpgetBySbCode_dt>
                    ("sp_ConsultantSelectBySbCode",new { sb_code=sb_code}).ToList();
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
