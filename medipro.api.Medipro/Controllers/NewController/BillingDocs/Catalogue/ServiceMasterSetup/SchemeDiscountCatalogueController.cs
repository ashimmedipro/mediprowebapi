using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue.ServiceMasterSetup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue.ServiceMasterSetup
{
    public class SchemeDiscountCatalogueController : ApiController
    {

        //post
        [HttpPost]
        [Route("api/SchemeDiscountCatalogue/Insert")]
        public IHttpActionResult PostServGroup(DiscountName_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_DiscountNameInsert", model);
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




        //get
        [HttpGet]
        [Route("api/SchemeDiscountCatalogue/DiscountNameGet")]
        public IHttpActionResult DisGet(string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<DiscountNameSelect_dt>
                    ("sp_DiscountNameSelect ", new { search = search }).ToList();
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

        //update

        [HttpPost]
        [Route("api/SchemeDiscountCatalogue/Update")]
        public IHttpActionResult Update(DiscountName_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_DiscountNameUpdate", model);
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
