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
    public class IpdRegistrationController : ApiController
    {
        [HttpGet]
        [Route("api/IpdRegistration/bedrack/ViewData")]
        public IHttpActionResult ViewBedRack()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedRackView_dt>
                ("sp_BedrackListSelect").ToList();
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

        //with search 
        [HttpGet]
        [Route("api/Referer/ViewData")]
        public IHttpActionResult ViewReferer(string search)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<RefererView_dt>
                ("sp_RefererSelectIpdReg", new { search = search}).ToList();
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


        //without search 

        [HttpGet]
        [Route("api/Referer/ViewData")]
        public IHttpActionResult ViewReferer()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererView_dt>
                    ("sp_RefererSelectIpdReg", new { search =" "}).ToList();
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


        //

        [HttpPost]
        [Route("api/IpdRegistration/Insert")]
        public IHttpActionResult Insert(IpdRegistrationInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_IpdRegistrationInsert", model);
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



    }
}
