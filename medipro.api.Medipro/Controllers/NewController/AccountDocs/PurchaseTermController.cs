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
    public class PurchaseTermController : ApiController
    {
        [HttpPost]
        [Route("api/PurchaseTerm")]
        public IHttpActionResult Post(PurchaseTerm_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_PurchaseTermsInsertUpdate", model);
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
        [Route("api/PurchaseTerm/{search}")]
        public IHttpActionResult Select(string search)
        {
            try
            {

            
            PurchaseTermList_dt Purchaseterm = new PurchaseTermList_dt();
            var list = DapperHelper.QueryStoredProcedure<PurchaseTermselect_dt>
                ("sp_purchaseTermsSearch", new { search = "" }).ToList();
            Purchaseterm.Purchaseterm = list;
            return Ok(Purchaseterm);

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
