using medipro.api.Medipro.Helpers;
using medipro.api.Medipro.Models.EyeDocs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace medipro.api.Medipro.Controllers.NewController.EyeDocs
{
    public class EyeRegistrationController : ApiController
    {
        [Route("api/EyeRegistration")]
        [HttpPost]
        public IHttpActionResult Post( EyeRegistration_dt model )
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Eye_RegistrationInsert", model);
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


        [Route("api/EyeRegistration/Update")]
        [HttpPost]
        public IHttpActionResult Update(EyeRegistration_dt model)
        {
            try
            {

            
            DapperHelper.ExecuteStoredProcedure("sp_Eye_RegistrationUpdate", model);
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
        [Route("api/EyeRegistration/Select")]
        public IHttpActionResult Get(string mrdno)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeRegistrationSelect_dt>
                ("sp_EyeRegistrationSelectAllByMrdno", new { mrdno = mrdno }).ToList();
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
        [Route("api/EyeRegistration/OpdBillSelect")]
        public IHttpActionResult OpdBillSelect(int consid, DateTime init, DateTime final, int grpid)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeRegOpdBillSelect_dt>
                ("sp_OpdBillForKesSelect", new { consid=consid, init=init, final=final,grpid=grpid }).ToList();
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
        [Route("api/EyeRegistration/OpdBillSelectAll")]
        public IHttpActionResult DateRange( DateTime init, DateTime final)
        {
            try
            {

            
            var list = DapperHelper.QueryStoredProcedure<EyeRegistrationAllSelect_dt>
                ("sp_EyeRegSelectAll", new {  init = init, final = final}).ToList();
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


        [Route("api/EyeRegistrationKesid/Update")]
        [HttpPost]
        public IHttpActionResult KesidUpdate(KesIdUpdate_dt model)
        {
            try
            {


                DapperHelper.ExecuteStoredProcedure("sp_EyeRegKesIdUpdate", model);
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
