using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.NewModels.BillingDocs;
using medipro.api.Medipro.Models.NewModels.BillingDocs.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.BillingDocs.Catalogue
{
    public class PatientInformationEditController : ApiController
    {
        //nagar vdc 
        [HttpGet]
        [Route("api/NagarVdc/Select")]
        public IHttpActionResult GetBySbCode(int dis_id, string search="")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<NagarVdcGet_dt>
                    ("sp_NagarVDCSelect", new { dis_id=dis_id, search=search }).ToList();
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


        //post or edit 

        [HttpPost]
        [Route("api/NagarVdc/Post")]
        public IHttpActionResult UpdateServGroup(NagarVdcAddEdit_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_NagarVDCInsertUpdate", model);
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

        //ethinics
        //post or edit 

        [HttpPost]
        [Route("api/Ethinics/Post")]
        public IHttpActionResult PostAndUpdate(EthinicsPost_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_ethincsInsertUpdate", model);
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
        [Route("api/Ethinic/Select")]
        public IHttpActionResult EthinicGet( string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<EthinicsGet_dt>
                    ("sp_EthinicsSelect", new {  search = search }).ToList();
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
