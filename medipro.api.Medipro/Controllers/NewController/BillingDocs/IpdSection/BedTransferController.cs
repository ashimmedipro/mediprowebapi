using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection
{
    public class BedTransferController : ApiController
    {
        [HttpGet]
        [Route("api/BedTransfer/SelectInpatient")]
        public IHttpActionResult Select()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedTransferGetInpatient_dt>
                ("sp_InpatientSelect").ToList();
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
        [Route("api/BedTransfer/BedRackParticularSelect")]
        public IHttpActionResult BedRackParticularSelect(string bedno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<BedTransferSelectBedRackParticular_dt>
                ("sp_BedrackParticularSelect", new {bedno = bedno }).ToList();
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
        [Route("api/BedTransfer/BedRackSelect")]
        public IHttpActionResult BedRackSelect()
        {
            try{
            
            var list = DapperHelper.QueryStoredProcedure<BedTransferSelectBedRack_dt>
                ("sp_BedrackSelect").ToList();
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
        [Route("api/BedTransfer/BedRecInsert")]
        public IHttpActionResult Insert(BedRecInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_BedTransfer", model);
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
