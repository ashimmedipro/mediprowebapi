using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue
{
    public class BedSetupController : ApiController
    {
        [HttpPost]
        [Route("api/BedRack/Insert")] 
        public IHttpActionResult Insert(BedRack_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_bedInsert", model);
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
        [Route("api/BedRack/Update")]
        public IHttpActionResult Update(BedRack_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_bedEdit", model);
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
        [Route("api/BedRack/Select")]
        public IHttpActionResult View(string search="")
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedRackSelect_dt>
                ("sp_bedSetupSelect",new { search=search}).ToList();
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
