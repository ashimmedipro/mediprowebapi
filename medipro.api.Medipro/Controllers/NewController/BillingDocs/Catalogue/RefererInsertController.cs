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
    public class RefererInsertController : ApiController
    {
        [HttpPost]
        [Route("api/Billing/Catalogue/Referer/Insert")]
        public IHttpActionResult Insert(RefererInsert_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_RefererInsert", model);
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
        [Route("api/salesman/Select")]
        public IHttpActionResult Get()
        {
            try
            {

                var list = DapperHelper.QueryStoredProcedure<SalesManGet_dt>
                        ("sp_SalesmanGet").ToList();
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
        [Route("api/Speciality/Select")]
        public IHttpActionResult Select()
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<SpecialityGet_dt>
                    ("sp_SpecialityGet").ToList();
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
        [Route("api/RefererSetup/Referer/Select")]
        public IHttpActionResult refererGet(string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererSetupGet_dt>
                    ("sp_RefererSetupRefererSelect", new { search=search}).ToList();
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
        [Route("api/RefererSetup/AcCodeGet")]
        public IHttpActionResult AcCodeGet(int firm , string search = "")
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<RefererSetupAcCodeGet_dt>
                    ("sp_RefererSetupAcCodeSelect", new {firm=firm, search = search }).ToList();
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


        //Referer Setup Update 

        [HttpPost]
        [Route("api/RefererSetup/Update")]
        public IHttpActionResult Update(RefererSetupUpdate_dt model)
        {
            try
            {

                DapperHelper.ExecuteStoredProcedure("sp_RefererSetupUpdate", model);
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

        //templateid get 

        [HttpGet]
        [Route("api/RefererSetup/TemplateId/Get")]
        public IHttpActionResult TemplateGet(int typeid)
        {
            try
            {


                var list = DapperHelper.QueryStoredProcedure<TemplateIdGet_dt>
                    ("sp_TemplateIdGetByTypeid", new { typeid=typeid}).ToList();
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







