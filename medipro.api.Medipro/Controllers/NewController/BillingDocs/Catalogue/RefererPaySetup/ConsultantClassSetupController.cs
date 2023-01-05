using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.RefererPaySetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.RefererPaySetup
{
    public class ConsultantClassSetupController : ApiController
    {
        [HttpGet]
        [Route("api/RefererSetup/ConsultantClassSetup/ConsultantNameGet")]
        public IHttpActionResult AcCodeGet(string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<ConsultantClassNameGet_dt>
                    ("sp_ConsultantClassGet", new { search = search }).ToList();
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


        //post

        [HttpPost]
        [Route("api/RefererSetup/ConsultantClassSetup/Insert")]
        public IHttpActionResult Insert(ConsultantClass_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_ConsultantClassAdd", model);
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

        //update

        [HttpPost]
        [Route("api/RefererSetup/ConsultantClassSetup/Update")]
        public IHttpActionResult Update(ConsultantClass_dt model)
        {
            try
            {

                DapperHelper.ExecuteStoredProcedure("sp_ConsultantClassUpdate", model);
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
