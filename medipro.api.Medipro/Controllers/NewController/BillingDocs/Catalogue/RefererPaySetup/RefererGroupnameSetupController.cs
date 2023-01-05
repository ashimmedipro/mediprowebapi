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
    public class RefererGroupnameSetupController : ApiController
    {
        [HttpGet]
        [Route("api/RefererSetup/RefererGroupnameSetup/TemplateGet")]
        public IHttpActionResult Get()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<Tempalate_dt>
                    ("sp_RefererTemplateNameGet").ToList();
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
        [Route("api/RefererSetup/RefererGroupnameSetup/TemplateInsert")]
        public IHttpActionResult Insert(Tempalate_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_RefererTemplateNameAdd", model);
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
        [Route("api/RefererSetup/RefererGroupnameSetup/TemplateUpdate")]
        public IHttpActionResult Update(Tempalate_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_RefererTemplateNameUpdate", model);
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
        [Route("api/RefererSetup/RefererGroupnameSetup/TemplateNameSelect")]
        public IHttpActionResult TemplateNameGet()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<TemplateNameSelect_dt>
                    ("sp_TemplateNameSelect").ToList();
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
        [Route("api/RefererSetup/RefererGroupnameSetup/TemplateServiceSelect")]
        public IHttpActionResult TemplateServiceSelect(int grpid, int sn)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<GroupnameOnClick_dt>
                    ("sp_referer_analysis_template_service_detailSelect", new { grpid=grpid, sn=sn}).ToList();
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
        [Route("api/RefererSetup/RefererGroupnameSetup/UpdateAll")]
        public IHttpActionResult UpdateAll(AllUpdate_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_referer_analysis_template_service_detailInsertBulk ", model);
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
        [Route("api/RefererSetup/RefererGroupnameSetup/Update")]
        public IHttpActionResult Update(SingleUpdate_dt model)
        {
            try
            {
                DapperHelper.ExecuteStoredProcedure("sp_referer_analysis_template_service_detailInsertSingle ", model);
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
