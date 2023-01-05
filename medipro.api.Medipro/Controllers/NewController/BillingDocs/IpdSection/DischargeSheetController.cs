using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using medipro.api.Medipro.Models.NewModels.BillingDocs.IPDSection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.IpdSection
{
    public class DischargeSheetController : ApiController
    {
        [HttpGet]
        [Route("api/DischargeSheet/SelectInpatient")]
        public IHttpActionResult SelectInpatient()
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeSheetSelectInpatient_dt>
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



        //[HttpGet]
        //[Route("api/RefererSelect")]
        //public IHttpActionResult SelectReferer()
        //{
        //    var list = DapperHelper.QueryStoredProcedure<RefererSelect_dt>
        //        ("sp_RefererSpecialitySelect").ToList();//
        //    return Ok(list);
        //}


        [HttpPost]
        [Route("api/DischargeSheet/Insert")]
        public IHttpActionResult Insert(DischargeSheetInsert_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_DischargeSheetInsert", model);
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
        [Route("api/DischargeSheet/Select")]
        public IHttpActionResult Select(string inv_no)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<DischargeSheetSelect_dt>
                ("sp_DischargeSheetSelectByInvno",new {inv_no=inv_no }).ToList();
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
