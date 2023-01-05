using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.OPDSection.AdvancedandChangedSec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.AdvanceandChangeSec.AdvanceReceipt
{
    public class AdvanceReceiptController : ApiController
    {


        [HttpGet]
        [Route("api/OpdSection/Advancereceipt/AccodeCardSelect")]
        public IHttpActionResult AccodeCardSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<CardlistSelect_dt>
                ("sp_accodecardselect1").ToList();
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
        [Route("api/OpdSection/Advancereceipt/Advance/NewMember/Insert")]
        public IHttpActionResult Post(AdvanceNewMemberInsert_dt model)
        {
            try
            {

            

            DapperHelper.ExecuteStoredProcedure("sp_AdvanceNewMemberInsert", model);
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
        [Route("api/OpdSection/Advancereceipt/Advance/Insert")]
        public IHttpActionResult AdvancePost(AdvanceOldMemberInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_AdvanceOldMemberInsert", model);
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
        [Route("api/OpdSection/Advancereceipt/OldMemberSelect")]
        public IHttpActionResult OldMemberSelect()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<MemberSelect_dt>
                ("sp_AdvMemberSelect").ToList();
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
