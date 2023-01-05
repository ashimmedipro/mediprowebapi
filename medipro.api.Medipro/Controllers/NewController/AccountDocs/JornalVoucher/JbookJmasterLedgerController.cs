using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.BMLDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.BMLDocs
{
    public class JbookJmasterLedgerController : ApiController
    {
        [HttpPost]
        [Route("api/JbookJmasterLedger")]
        public IHttpActionResult Post(JbookJmasterLedgerPosting_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_JbookJmasterLedgerPosting", model);
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
        [Route("api/JmasterSelectById")]
        public IHttpActionResult Get(string id)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<JmasterSelectById_dt>
                ("sp_JmasterSelectbyId", new { id = "" }).ToList();
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
        [Route("api/JbookSelectById")]
        public IHttpActionResult JmasterSelectById(string vr_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<JbookSelectById_dt>
                ("sp_JbookSelectById", new { vr_no=vr_no }).ToList();
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
        [Route("api/JbookList")]
        public IHttpActionResult JbookList(DateTime init, DateTime final, int firm, string search="", string vr_type="" )
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<JbookSelectById_dt>
                ("sp_JbookList", new { init = init, final=final, firm=firm, search=search, vr_type=vr_type }).ToList();
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
