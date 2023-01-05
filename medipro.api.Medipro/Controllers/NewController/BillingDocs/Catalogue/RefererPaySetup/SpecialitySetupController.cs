using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.RefererPaySetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.RefererPaySetup
{
    public class SpecialitySetupController : ApiController
    {

        [HttpPost]
        [Route("api/RefererSetup/Speciality/Insert")]
        public IHttpActionResult Insert(Speciality_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_SPECIALITYInsert", model);
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
        [Route("api/RefererSetup/SpecialitySearch")]
        public IHttpActionResult AcCodeGet( string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<Speciality_dt>
                    ("sp_SpecialitySearch", new { search = search }).ToList();
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


        [HttpPost]
        [Route("api/RefererSetup/Speciality/Update")]
        public IHttpActionResult Update(Speciality_dt model)
        {
            try
            {

                DapperHelper.ExecuteStoredProcedure("sp_SpecialityUpdate", model);
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
