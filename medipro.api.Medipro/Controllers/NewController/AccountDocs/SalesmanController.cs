using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.AccountDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.AccountDocs
{
    public class SalesmanController : ApiController
    {
        [HttpPost]
        [Route("api/Salesman")]
        public IHttpActionResult Post(Salesman_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SALESMANInsert", model);
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

        [HttpPost]
        [Route("api/Salesman/Update")]
        public IHttpActionResult Update(Salesman_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_SALESMANUpdate", model);
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
        [Route("api/Salesman")]
        public IHttpActionResult Get()
        {
            try
            {

            
            SalesmanList_dt Salesman = new SalesmanList_dt();
            var list = DapperHelper.QueryStoredProcedure<Salesman_dt>
                ("sp_SALESMANSelect").ToList();
            Salesman.Salesman = list;
            return Ok(Salesman);

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
